using Presentacion.Base;
using Presentacion.Base.Varios;
using Servicio.Core.Recibo;
using Servicio.Core.Cliente;
using Servicio.Core.Recibo.Dto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Servicio.Core.Credito.Dto;
using Servicio.Core.Credito;

namespace Presentacion.Core.Recibos
{
    public partial class _11_FormularioConsultaRecibos : FormularioBase
    {
        private readonly IReciboServicio _reciboServicio;
        private readonly ICreditoServicio _creditoServicio;
        private readonly IClienteServicio _clienteServicio;

        private DateTime hoy = DateTime.Now;
        private DateTime lunes;
        private DateTime domingo;
        private int deltaLunes = 0;
        private int deltaDomingo = 0;
        private CultureInfo myCI = new CultureInfo("es-AR");

        private ReciboDto elementoSeleccionado;
        private bool puedeEjecutarComando = false;
        private List<ReciboDto> _lista;

        //variables para impresion
        private List<ReciboDto> lista;
        private List<ReciboDto> listaReversa;
        private string _fechaPago;
        private ReciboDto _recibo;
        private ReciboDto _reciboAnterior;
        private CreditoDto _creditoImprimir;
        private decimal _pagado = 0m;
        private decimal _saldo;
        private decimal _atraso = 0m;


        public _11_FormularioConsultaRecibos()
        {
            InitializeComponent();

            _reciboServicio = new ReciboServicio();
            _clienteServicio = new ClienteServicio();
            _creditoServicio = new CreditoServicio();

            ActualizarDatos(string.Empty);

            deltaLunes = DayOfWeek.Monday - hoy.DayOfWeek;
            deltaDomingo = (myCI.DateTimeFormat.FirstDayOfWeek + 7) - hoy.DayOfWeek; 
            lunes = hoy.AddDays(deltaLunes); // lunes de la semana actual
            domingo = hoy.AddDays(deltaDomingo); // domingo de la semana actual
            lblSemana.Text = "Para Imprimir Esta Semana " + lunes.ToShortDateString() + " Al " + domingo.ToShortDateString();
        }

        private void ActualizarDatos(string cadenaBuscar)
        {
            dgvGrilla.DataSource = _reciboServicio.ObtenerPorSemana(cadenaBuscar);
            FormatearGrilla(dgvGrilla);

            txtTotal.Text = RetornarTotal(cadenaBuscar).ToString("c2");
        }

        public override void FormatearGrilla(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["CLienteId"].Visible = false;
            dgvGrilla.Columns["CreditoId"].Visible = false;
            dgvGrilla.Columns["CuotasPendiente"].Visible = false;
            dgvGrilla.Columns["UltimoPago"].Visible = false;
            dgvGrilla.Columns["Atraso"].Visible = false;
            dgvGrilla.Columns["Saldo"].Visible = false;
            dgvGrilla.Columns["ApyNomCliente"].Visible = false;
            dgvGrilla.Columns["Interes"].Visible = false;
            dgvGrilla.Columns["Pagado"].Visible = false;
            dgvGrilla.Columns["Pago"].Visible = false;
            dgvGrilla.Columns["Estado"].Visible = false;

            dgvGrilla.Columns["Numero"].Visible = true;
            dgvGrilla.Columns["Numero"].Width = 50;
            dgvGrilla.Columns["Numero"].HeaderText = @"Codigo";
            dgvGrilla.Columns["Numero"].DisplayIndex = 0;

            dgvGrilla.Columns["NumeroCuota"].Visible = true;
            dgvGrilla.Columns["NumeroCuota"].Width = 50;
            dgvGrilla.Columns["NumeroCuota"].HeaderText = @"Numero Cuota";
            dgvGrilla.Columns["NumeroCuota"].DisplayIndex = 1;

            dgvGrilla.Columns["ApyNomCliente"].Visible = true;
            dgvGrilla.Columns["ApyNomCliente"].Width = 50;
            dgvGrilla.Columns["ApyNomCliente"].HeaderText = @"Cliente";
            dgvGrilla.Columns["ApyNomCliente"].DisplayIndex = 2;

            dgvGrilla.Columns["MontoCredito"].Visible = true;
            dgvGrilla.Columns["MontoCredito"].Width = 100;
            dgvGrilla.Columns["MontoCredito"].HeaderText = @"Monto Credito";
            dgvGrilla.Columns["MontoCredito"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["MontoCredito"].DisplayIndex = 3;

            dgvGrilla.Columns["MontoCuota"].Visible = true;
            dgvGrilla.Columns["MontoCuota"].Width = 50;
            dgvGrilla.Columns["MontoCuota"].HeaderText = @"Monto Cuota";
            dgvGrilla.Columns["MontoCuota"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["MontoCuota"].DisplayIndex = 4;

            dgvGrilla.Columns["FechaPago"].Visible = true;
            dgvGrilla.Columns["FechaPago"].Width = 100;
            dgvGrilla.Columns["FechaPago"].HeaderText = @"Fecha Pago";
            dgvGrilla.Columns["FechaPago"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaPago"].DisplayIndex = 5;

            dgvGrilla.Columns["CodigoCredito"].Visible = true;
            dgvGrilla.Columns["CodigoCredito"].Width = 100;
            dgvGrilla.Columns["CodigoCredito"].HeaderText = @"Codigo Credito";
            dgvGrilla.Columns["CodigoCredito"].DisplayIndex = 6;
        }

        private decimal RetornarTotal(string cadenaBuscar)
        {
            _lista = _reciboServicio.ObtenerPorSemana(cadenaBuscar).ToList();

            var total = 0m;

            foreach (var item in _lista)
            {
                total += item.MontoCuota;
            }

            return total;
        }

        private void CargarDatosImpresion()
        {

            _creditoImprimir = _creditoServicio.obtenerPorId(_recibo.CreditoId);
            lista = _reciboServicio.ObtenerPorCredito(_recibo.CreditoId, string.Empty).ToList();
            listaReversa = _reciboServicio.ObtenerPorCredito(_recibo.CreditoId, string.Empty).ToList();
            _pagado = 0m;
            _saldo = 0m;
            _atraso = 0m;


            foreach (var recibo in lista)
            {
                if (recibo.NumeroCuota == _recibo.NumeroCuota - 1)
                {
                    _reciboAnterior = recibo;
                    break;
                }
            }

            foreach (var item in lista)
            {
                _pagado += item.Pago;

                if (item.NumeroCuota == _recibo.NumeroCuota)
                {
                    if (_recibo.NumeroCuota == 1)
                    {
                        _pagado = 0m;
                        break;
                    }
                    else
                    {
                        _pagado = _pagado - item.Pago;
                        break;
                    }

                }
            }

            foreach (var item in lista)
            {
                _atraso += item.Atraso;

                if (_recibo.NumeroCuota == 1)
                {
                    _atraso = 0m;
                    break;
                }

                if (item.NumeroCuota == _recibo.NumeroCuota)
                {
                    _atraso = _atraso - _recibo.Atraso;
                    break;
                }
            }

            listaReversa.Reverse(); // probar desde aqui

            foreach (var item in listaReversa)
            {
                if (_recibo.NumeroCuota == 1)
                {
                    _fechaPago = "--";
                    break;
                }

                if (item.NumeroCuota < _recibo.NumeroCuota)
                {
                    if (item.Pago > 0)
                    {
                        _fechaPago = item.FechaPago.Date.ToShortDateString()
                                     + " " + item.Pago.ToString("c2");

                        break;
                    }
                    else
                    {
                        _fechaPago = "--";
                    }


                }
            }

            // _saldo = _recibo.NumeroCuota > 1 ? _reciboAnterior.Saldo : 0m; // saldo del recibo anterior
            _saldo = _recibo.MontoCredito - _pagado;

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (puedeEjecutarComando)
            {
                var formularioCompletar1 = new _9_FormularioVerRecibo((ReciboDto)elementoSeleccionado);
                formularioCompletar1.ShowDialog();
            }
            else
            {
                Mensaje.Mostrar("Debe seleccionar un recibo para poder continuar.", Mensaje.Tipo.Informacion);
            }
        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            elementoSeleccionado = (ReciboDto)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            _recibo = elementoSeleccionado;
        }

        private void dgvGrilla_DataSourceChanged(object sender, EventArgs e)
        {
            puedeEjecutarComando = dgvGrilla.RowCount > 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(txtBuscar.Text.Trim());

            txtTotal.Text = RetornarTotal(txtBuscar.Text.Trim()).ToString("c2");

        }

        private void ImprimirTodos(object sender, PrintPageEventArgs e)
        {
            Font fontTextoFinal = new Font("Arial", 8, FontStyle.Bold);
            int ancho = 300;
            int y = 0;

            int _x = 0;
            int _y = 0;
            int _ancho = 420;
            int _alto = 370;

            int _x1 = 420;
            int _y1 = 0;
            int _ancho1 = 480;
            int _alto1 = 370;

            decimal cantidadRecibos = 0;
            bool paginaExtra = false;


            foreach (var item in _lista)
            {
                _recibo = item;

                CargarDatosImpresion();

                cantidadRecibos += 1;

                RectangleF recuadro = new RectangleF(_x, _y, _ancho, _alto);
                RectangleF recuadro2 = new RectangleF(_x1, _y1, _ancho1, _alto1);

                var cliente = _clienteServicio.obtenerPorId(item.ClienteId);

                e.Graphics.DrawString("Cuota N° " + item.NumeroCuota, Font, Brushes.Black, new RectangleF(260, y += 20, ancho, 20));
                e.Graphics.DrawString("Cuota N° " + item.NumeroCuota, Font, Brushes.Black, new RectangleF(680, y, ancho, 20));
                e.Graphics.DrawString("Cuota Pend: " + item.CuotasPendiente, Font, Brushes.Black, new RectangleF(260, y += 20, ancho, 20));
                e.Graphics.DrawString("Cuota Pend: " + item.CuotasPendiente, Font, Brushes.Black, new RectangleF(680, y, ancho, 20));
                e.Graphics.DrawString("Cuota " + item.MontoCuota.ToString("c2"), Font, Brushes.Black, new RectangleF(260, y += 20, ancho, 20));
                e.Graphics.DrawString("Cuota " + item.MontoCuota.ToString("c2"), Font, Brushes.Black, new RectangleF(680, y, ancho, 20));

                e.Graphics.DrawString("Cliente: " + item.ApyNomCliente, Font, Brushes.Black, new RectangleF(20, y += 20, ancho + 300, 20));
                e.Graphics.DrawString("Cliente: " + item.ApyNomCliente, Font, Brushes.Black, new RectangleF(440, y, ancho + 300, 20));
                e.Graphics.DrawString("Codigo: " + cliente.NumeroCliente , Font, Brushes.Black, new RectangleF(260, y, ancho + 300, 20));
                e.Graphics.DrawString("Codigo: " + cliente.NumeroCliente , Font, Brushes.Black, new RectangleF(680, y, ancho + 300, 20));
                e.Graphics.DrawString("Dni: " + cliente.Dni, Font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
                e.Graphics.DrawString("Dni: " + cliente.Dni, Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                e.Graphics.DrawString("Direccion Particular: " + cliente.DireccionParticular, Font, Brushes.Black, new RectangleF(20, y += 20, ancho + 100, 20));
                e.Graphics.DrawString("Direccion Particular: " + cliente.DireccionParticular, Font, Brushes.Black, new RectangleF(440, y, ancho + 100, 20));
                e.Graphics.DrawString("Direccion Comercial: " + cliente.DireccionComercial, Font, Brushes.Black, new RectangleF(20, y += 20, ancho + 100, 20));
                e.Graphics.DrawString("Direccion Comercial: " + cliente.DireccionComercial, Font, Brushes.Black, new RectangleF(440, y, ancho + 100, 20));
                e.Graphics.DrawString("Tel: " + cliente.Telefono, Font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
                e.Graphics.DrawString("Tel: " + cliente.Telefono, Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                e.Graphics.DrawString("Cel: " + cliente.Celular, Font, Brushes.Black, new RectangleF(260, y, ancho, 20));
                e.Graphics.DrawString("Cel: " + cliente.Celular, Font, Brushes.Black, new RectangleF(680, y, ancho, 20));
                //salto de linea

                e.Graphics.DrawString("Credito", Font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));
                e.Graphics.DrawString("Credito", Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                e.Graphics.DrawString("Pagado", Font, Brushes.Black, new RectangleF(90, y, ancho, 20));
                e.Graphics.DrawString("Pagado", Font, Brushes.Black, new RectangleF(510, y, ancho, 20));
                e.Graphics.DrawString("Saldo", Font, Brushes.Black, new RectangleF(160, y, ancho, 20));
                e.Graphics.DrawString("Saldo", Font, Brushes.Black, new RectangleF(580, y, ancho, 20));
                e.Graphics.DrawString("Ult. Pago", Font, Brushes.Black, new RectangleF(230, y, ancho, 20));
                e.Graphics.DrawString("Ult. Pago", Font, Brushes.Black, new RectangleF(650, y, ancho, 20));
                e.Graphics.DrawString("Atraso", Font, Brushes.Black, new RectangleF(355, y, ancho, 20));
                e.Graphics.DrawString("Atraso", Font, Brushes.Black, new RectangleF(770, y, ancho, 20));
                //linea de abajo

                e.Graphics.DrawString(item.MontoCredito.ToString("c2"), Font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
                e.Graphics.DrawString(item.MontoCredito.ToString("c2"), Font, Brushes.Black, new RectangleF(440, y, ancho, 20));

                if (item.NumeroCuota > 1)
                {
                    var pagado = _recibo.Estado != Constante.EstadoRecibo.Impago ? _pagado.ToString("c2") : _pagado.ToString("c2");

                    e.Graphics.DrawString(pagado, Font, Brushes.Black, new RectangleF(90, y, ancho, 20));
                    e.Graphics.DrawString(pagado, Font, Brushes.Black, new RectangleF(510, y, ancho, 20));
                }
                else
                {

                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(100, y, ancho, 20));
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(520, y, ancho, 20));
                }

                if (item.NumeroCuota > 1)
                {
                    var saldo = _recibo.Estado != Constante.EstadoRecibo.Impago ? _saldo.ToString("c2") : _saldo.ToString("c2");

                    e.Graphics.DrawString(saldo, Font, Brushes.Black, new RectangleF(160, y, ancho, 20));
                    e.Graphics.DrawString(saldo, Font, Brushes.Black, new RectangleF(580, y, ancho, 20));
                }
                else
                {
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(160, y, ancho, 20));
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(580, y, ancho, 20));
                }

                if (item.NumeroCuota > 1)
                {
                    var ultPago = _fechaPago;

                    e.Graphics.DrawString(ultPago, Font, Brushes.Black, new RectangleF(230, y, ancho, 20));
                    e.Graphics.DrawString(ultPago, Font, Brushes.Black, new RectangleF(650, y, ancho, 20));
                }
                else
                {
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(230, y, ancho, 20));
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(650, y, ancho, 20));
                }

                if (item.NumeroCuota > 1)
                {
                    var atraso = _atraso.ToString("c2");

                    e.Graphics.DrawString(atraso, Font, Brushes.Black, new RectangleF(355, y, ancho, 20));
                    e.Graphics.DrawString(atraso, Font, Brushes.Black, new RectangleF(770, y, ancho, 20));
                }
                else
                {
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(355, y, ancho, 20));
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(770, y, ancho, 20));
                }
                // salto de linea

                e.Graphics.DrawString("Fecha Pago:   /   /  ", Font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));
                e.Graphics.DrawString("Fecha Pago:   /   /  ", Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                e.Graphics.DrawString("Pago: $", Font, Brushes.Black, new RectangleF(260, y, ancho, 20));
                e.Graphics.DrawString("Pago: $", Font, Brushes.Black, new RectangleF(700, y, ancho, 20));
                //salto de linea

                e.Graphics.DrawString("Firma Cobrador:", Font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));
                e.Graphics.DrawString("Firma Cobrador:", Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                //salto de linea

                e.Graphics.DrawString("CONSERVAR EL COMPROBANTE", fontTextoFinal, Brushes.Black, new RectangleF(100, y += 40, ancho, 20));
                e.Graphics.DrawString("CONSERVAR EL COMPROBANTE", fontTextoFinal, Brushes.Black, new RectangleF(540, y, ancho, 20));
                e.Graphics.DrawString("", Font, Brushes.Black, new RectangleF(540, y += 30, ancho, 20));
                //salto de linea

                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(recuadro));
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(recuadro2));

                _y += 370;
                _y1 += 370;

                var valor = cantidadRecibos / 3;

                string numero = valor.ToString();

                char[] test = numero.ToCharArray();

                for (int i = 0; i < test.Length; i++)
                {
                    if (test[i] == ',') // si el numero contiene una coma accede se cunple la condicion
                    {
                        paginaExtra = false;
                        break;
                    }
                    else
                    {
                        paginaExtra = true;
                    }
                }

                if (paginaExtra)
                {
                    break;
                }

            }

            if (_lista.Count > 2)
            {
                ReciboDto[] arreglo = new ReciboDto[_lista.Count];
                var _contador = 0;


                foreach (var item in _lista) // agrego a un arreglo los elementos de la lista
                {
                    
                    arreglo[_contador] = item;

                    _contador += 1;
                }

                var contador = 0;

                foreach (var item in arreglo)
                {
                    if (contador < 3)
                    {
                        _lista.Remove(item); // remuevo de la lista los elementos ya impresos

                        contador += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (paginaExtra) // si la lista contiene mas de 3 elementos se genera una nueva pagina
            {
                e.HasMorePages = true;
            }

           
        }

        private void ImprimirSeleccionado(object sender, PrintPageEventArgs e)
        {
            CargarDatosImpresion();

            List<ReciboDto> _lista2 = new List<ReciboDto>();

            _lista2.Add(elementoSeleccionado);

            Font fontTextoFinal = new Font("Arial", 8, FontStyle.Bold);
            int ancho = 300;
            int y = 0;

            int _x = 0;
            int _y = 0;
            int _ancho = 420;
            int _alto = 370;

            int _x1 = 420;
            int _y1 = 0;
            int _ancho1 = 480;
            int _alto1 = 370;


            foreach (var item in _lista2)
            {
                RectangleF recuadro = new RectangleF(_x, _y, _ancho, _alto);
                RectangleF recuadro2 = new RectangleF(_x1, _y1, _ancho1, _alto1);

                var cliente = _clienteServicio.obtenerPorId(item.ClienteId);

                e.Graphics.DrawString("Cuota N° " + item.NumeroCuota, Font, Brushes.Black, new RectangleF(260, y += 20, ancho, 20));
                e.Graphics.DrawString("Cuota N° " + item.NumeroCuota, Font, Brushes.Black, new RectangleF(680, y, ancho, 20));
                e.Graphics.DrawString("Cuota Pend: " + item.CuotasPendiente, Font, Brushes.Black, new RectangleF(260, y += 20, ancho, 20));
                e.Graphics.DrawString("Cuota Pend: " + item.CuotasPendiente, Font, Brushes.Black, new RectangleF(680, y, ancho, 20));
                e.Graphics.DrawString("Cuota " + item.MontoCuota.ToString("c2"), Font, Brushes.Black, new RectangleF(260, y += 20, ancho, 20));
                e.Graphics.DrawString("Cuota " + item.MontoCuota.ToString("c2"), Font, Brushes.Black, new RectangleF(680, y, ancho, 20));

                e.Graphics.DrawString("Cliente: " + item.ApyNomCliente, Font, Brushes.Black, new RectangleF(20, y += 20, ancho + 300, 20));
                e.Graphics.DrawString("Cliente: " + item.ApyNomCliente, Font, Brushes.Black, new RectangleF(440, y, ancho + 300, 20));
                e.Graphics.DrawString("Codigo: " + cliente.NumeroCliente, Font, Brushes.Black, new RectangleF(260, y, ancho + 300, 20));
                e.Graphics.DrawString("Codigo: " + cliente.NumeroCliente, Font, Brushes.Black, new RectangleF(680, y, ancho + 300, 20));
                e.Graphics.DrawString("Dni: " + cliente.Dni, Font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
                e.Graphics.DrawString("Dni: " + cliente.Dni, Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                e.Graphics.DrawString("Direccion Particular: " + cliente.DireccionParticular, Font, Brushes.Black, new RectangleF(20, y += 20, ancho + 100, 20));
                e.Graphics.DrawString("Direccion Particular: " + cliente.DireccionParticular, Font, Brushes.Black, new RectangleF(440, y, ancho + 100, 20));
                e.Graphics.DrawString("Direccion Comercial: " + cliente.DireccionComercial, Font, Brushes.Black, new RectangleF(20, y += 20, ancho + 100, 20));
                e.Graphics.DrawString("Direccion Comercial: " + cliente.DireccionComercial, Font, Brushes.Black, new RectangleF(440, y, ancho + 100, 20));
                e.Graphics.DrawString("Tel: " + cliente.Telefono, Font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
                e.Graphics.DrawString("Tel: " + cliente.Telefono, Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                e.Graphics.DrawString("Cel: " + cliente.Celular, Font, Brushes.Black, new RectangleF(260, y, ancho, 20));
                e.Graphics.DrawString("Cel: " + cliente.Celular, Font, Brushes.Black, new RectangleF(680, y, ancho, 20));
                //salto de linea

                e.Graphics.DrawString("Credito", Font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));
                e.Graphics.DrawString("Credito", Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                e.Graphics.DrawString("Pagado", Font, Brushes.Black, new RectangleF(90, y, ancho, 20));
                e.Graphics.DrawString("Pagado", Font, Brushes.Black, new RectangleF(510, y, ancho, 20));
                e.Graphics.DrawString("Saldo", Font, Brushes.Black, new RectangleF(160, y, ancho, 20));
                e.Graphics.DrawString("Saldo", Font, Brushes.Black, new RectangleF(580, y, ancho, 20));
                e.Graphics.DrawString("Ult. Pago", Font, Brushes.Black, new RectangleF(230, y, ancho, 20));
                e.Graphics.DrawString("Ult. Pago", Font, Brushes.Black, new RectangleF(650, y, ancho, 20));
                e.Graphics.DrawString("Atraso", Font, Brushes.Black, new RectangleF(355, y, ancho, 20));
                e.Graphics.DrawString("Atraso", Font, Brushes.Black, new RectangleF(770, y, ancho, 20));
                //linea de abajo

                e.Graphics.DrawString(item.MontoCredito.ToString("c2"), Font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
                e.Graphics.DrawString(item.MontoCredito.ToString("c2"), Font, Brushes.Black, new RectangleF(440, y, ancho, 20));

                if (item.NumeroCuota > 1)
                {
                    var pagado = _recibo.Estado != Constante.EstadoRecibo.Impago ? _pagado.ToString("c2") : _pagado.ToString("c2");

                    e.Graphics.DrawString(pagado, Font, Brushes.Black, new RectangleF(90, y, ancho, 20));
                    e.Graphics.DrawString(pagado, Font, Brushes.Black, new RectangleF(510, y, ancho, 20));
                }
                else
                {

                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(100, y, ancho, 20));
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(520, y, ancho, 20));
                }

                if (item.NumeroCuota > 1)
                {
                    var saldo = _recibo.Estado != Constante.EstadoRecibo.Impago ? _saldo.ToString("c2") : _saldo.ToString("c2");

                    e.Graphics.DrawString(saldo, Font, Brushes.Black, new RectangleF(160, y, ancho, 20));
                    e.Graphics.DrawString(saldo, Font, Brushes.Black, new RectangleF(580, y, ancho, 20));
                }
                else
                {
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(160, y, ancho, 20));
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(580, y, ancho, 20));
                }

                if (item.NumeroCuota > 1)
                {
                    var ultPago = _fechaPago;

                    e.Graphics.DrawString(ultPago, Font, Brushes.Black, new RectangleF(230, y, ancho, 20));
                    e.Graphics.DrawString(ultPago, Font, Brushes.Black, new RectangleF(650, y, ancho, 20));
                }
                else
                {
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(230, y, ancho, 20));
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(650, y, ancho, 20));
                }

                if (item.NumeroCuota > 1)
                {
                    var atraso = _atraso.ToString("c2");

                    e.Graphics.DrawString(atraso, Font, Brushes.Black, new RectangleF(355, y, ancho, 20));
                    e.Graphics.DrawString(atraso, Font, Brushes.Black, new RectangleF(770, y, ancho, 20));
                }
                else
                {
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(355, y, ancho, 20));
                    e.Graphics.DrawString("---", Font, Brushes.Black, new RectangleF(770, y, ancho, 20));
                }
                // salto de linea

                e.Graphics.DrawString("Fecha Pago:   /   /  ", Font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));
                e.Graphics.DrawString("Fecha Pago:   /   /  ", Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                e.Graphics.DrawString("Pago: $", Font, Brushes.Black, new RectangleF(260, y, ancho, 20));
                e.Graphics.DrawString("Pago: $", Font, Brushes.Black, new RectangleF(700, y, ancho, 20));
                //salto de linea

                e.Graphics.DrawString("Firma Cobrador:", Font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));
                e.Graphics.DrawString("Firma Cobrador:", Font, Brushes.Black, new RectangleF(440, y, ancho, 20));
                //salto de linea

                e.Graphics.DrawString("CONSERVAR EL COMPROBANTE", fontTextoFinal, Brushes.Black, new RectangleF(100, y += 40, ancho, 20));
                e.Graphics.DrawString("CONSERVAR EL COMPROBANTE", fontTextoFinal, Brushes.Black, new RectangleF(540, y, ancho, 20));
                e.Graphics.DrawString("", Font, Brushes.Black, new RectangleF(540, y += 30, ancho, 20));
                //salto de linea

                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(recuadro));
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(recuadro2));

                _y += 370;
                _y1 += 370;

            }
        }
        
        private void btnImprimirTodos_Click(object sender, EventArgs e)
        {
            if (puedeEjecutarComando)
            {

                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;

                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    ps.PrinterName = printer;

                    if (ps.IsDefaultPrinter)
                        break;
                }

                PaperSize tamañoHoja = new PaperSize();
                tamañoHoja.RawKind = (int)PaperKind.A4;

                printDocument1.DefaultPageSettings.PaperSize = tamañoHoja;
                printDocument1.PrintPage += ImprimirTodos;
                printDocument1.Print();
            }
            else
            {
                Mensaje.Mostrar("Debe Haber Uno o Mas Recibos Para Poder Continuar.", Mensaje.Tipo.Informacion);
            }

        }

        private void btnImprimirSeleccionado_Click(object sender, EventArgs e)
        {

            if (puedeEjecutarComando)
            {
                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;

                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    ps.PrinterName = printer;

                    if (ps.IsDefaultPrinter)
                        break;
                }

                PaperSize tamañoHoja = new PaperSize();
                tamañoHoja.RawKind = (int)PaperKind.A4;

                printDocument1.DefaultPageSettings.PaperSize = tamañoHoja;

                printDocument1.PrintPage += ImprimirSeleccionado;
                printDocument1.Print();
            }
            else
            {
                Mensaje.Mostrar("Debe Seleccionar un Recibo Para Poder Continuar.", Mensaje.Tipo.Informacion);
            }

        }
    }
}
