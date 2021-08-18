using Presentacion.Base;
using Presentacion.Base.Varios;
using Servicio.Core.Credito;
using Servicio.Core.Credito.Dto;
using Servicio.Core.Recibo;
using Servicio.Core.Recibo.Dto;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using Servicio.Core.Cliente;
using System;

namespace Presentacion.Core.Recibos
{
    public partial class _7_FormularioConsultaRecibosCredito : Form
    {
        private readonly IReciboServicio _reciboServicio;
        private readonly ICreditoServicio _creditoServicio;
        private readonly IClienteServicio _clienteServicio;
        private CreditoDto credito;
        private ReciboDto elementoSeleccionado;
        public bool RealizoAlgunaOperacion = true;
        private bool puedeEjecutarComando;
        private List<ReciboDto> lista;
        private decimal pagado;
        private decimal saldo;
        private decimal pago;
        private decimal _totalAbonado = 0m;

        //variables para impresion
        private ReciboDto _recibo;
        private ReciboDto _reciboAnterior;
        private CreditoDto _creditoImprimir;
        private decimal _pagado = 0m;
        private decimal _saldo;
        private decimal _atraso = 0m;

        public _7_FormularioConsultaRecibosCredito(CreditoDto _credito)
        {
            InitializeComponent();

            _reciboServicio = new ReciboServicio();
            _creditoServicio = new CreditoServicio();
            _clienteServicio = new ClienteServicio();

            credito = _credito;
            this.lblCodigoCredito.Text = credito.CodigoCredito.ToString();
            puedeEjecutarComando = false;

            this.lblCancelacion.Text = credito.FechaCancelacion.ToShortDateString();
            this.lblCancelacion.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            this.lblCancelacion.ForeColor = credito.FechaCancelacion.Date >= System.DateTime.Now.Date ?
                                            _credito.Extension == true ? _credito.TotalAbonado == _credito.Monto ?  Color.Green : Color.Blue :
                                            _credito.TotalAbonado == _credito.Monto ? Color.Green : Color.DarkGray :
                                            _credito.Extension == true ? _credito.TotalAbonado == _credito.Monto ? Color.Green : Color.Red : Color.Red ;
            
            this.lblInfoCredito.Text = credito.FechaCancelacion.Date >= System.DateTime.Now.Date ?
                                            _credito.TotalAbonado == _credito.Monto ? "Credito Abonado Completo" : "Credito Abonado Incompleto" :
                                            _credito.TotalAbonado == _credito.Monto ? "Credito Abonado Completo" : "Credito Abonado Incompleto";

            this.lblInfoCredito.ForeColor = credito.FechaCancelacion.Date >= System.DateTime.Now.Date ?
                                            _credito.TotalAbonado == _credito.Monto ? Color.Green : Color.DarkGray :
                                            _credito.TotalAbonado == _credito.Monto ? Color.Green : Color.Red;

            if (_credito.FechaCancelacion < System.DateTime.Now)
            {
                btnAtrasar.Visible = false;
                btnCompletar.Visible = false;
            }

            if (_credito.TipoCredito == Constante.TipoCredito.Refinanciado)
            {
                this.lblTitulo.Text = "Recibos de Rnanciacion N°: "; 
            }
        }

        public void ActualizarDatos(string cadenaBuscar)
        {
            dgvGrilla.DataSource = _reciboServicio.ObtenerPorCredito(credito.Id, cadenaBuscar);
            FormatearGrilla(dgvGrilla);

            var creditoACtualizado = _creditoServicio.obtenerPorId(credito.Id);

            this.lblCancelacion.ForeColor = creditoACtualizado.FechaCancelacion.Date >= System.DateTime.Now.Date ?
                                            creditoACtualizado.Extension == true ? creditoACtualizado.TotalAbonado == creditoACtualizado.Monto ? Color.Green : Color.Blue :
                                            creditoACtualizado.TotalAbonado == creditoACtualizado.Monto ? Color.Green : Color.DarkGray :
                                            creditoACtualizado.Extension == true ? creditoACtualizado.TotalAbonado == creditoACtualizado.Monto ? Color.Green : Color.Red : Color.Red;

            this.lblInfoCredito.Text = creditoACtualizado.FechaCancelacion.Date >= System.DateTime.Now.Date ?
                                       creditoACtualizado.TotalAbonado == creditoACtualizado.Monto ? "Credito Abonado Completo" : "Credito Abonado Incompleto" :
                                       creditoACtualizado.TotalAbonado == creditoACtualizado.Monto ? "Credito Abonado Completo" : "Credito Abonado Incompleto";

            this.lblInfoCredito.ForeColor = creditoACtualizado.FechaCancelacion.Date >= System.DateTime.Now.Date ?
                                            creditoACtualizado.TotalAbonado == creditoACtualizado.Monto ? Color.Green : Color.DarkGray :
                                            creditoACtualizado.TotalAbonado == creditoACtualizado.Monto ? Color.Green : Color.Red;
        }

        private void FormatearGrilla(DataGridView dgvGriila)
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
            dgvGrilla.Columns["Numero"].Visible = false;
            dgvGrilla.Columns["CodigoCredito"].Visible = false;

            dgvGrilla.Columns["NumeroCuota"].Visible = true;
            dgvGrilla.Columns["NumeroCuota"].Width = 50;
            dgvGrilla.Columns["NumeroCuota"].HeaderText = @"Numero Cuota";
            dgvGrilla.Columns["NumeroCuota"].DisplayIndex = 0;

            dgvGrilla.Columns["MontoCredito"].Visible = true;
            dgvGrilla.Columns["MontoCredito"].Width = 100;
            dgvGrilla.Columns["MontoCredito"].HeaderText = @"Monto Credito";
            dgvGrilla.Columns["MontoCredito"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["MontoCredito"].DisplayIndex = 1;

            dgvGrilla.Columns["MontoCuota"].Visible = true;
            dgvGrilla.Columns["MontoCuota"].Width = 50;
            dgvGrilla.Columns["MontoCuota"].HeaderText = @"Monto Cuota";
            dgvGrilla.Columns["MontoCuota"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["MontoCuota"].DisplayIndex = 3;

            dgvGrilla.Columns["Pago"].Visible = true;
            dgvGrilla.Columns["Pago"].Width = 100;
            dgvGrilla.Columns["Pago"].HeaderText = @"Pago";
            dgvGrilla.Columns["Pago"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["Pago"].DisplayIndex = 4;

            dgvGrilla.Columns["FechaPago"].Visible = true;
            dgvGrilla.Columns["FechaPago"].Width = 100;
            dgvGrilla.Columns["FechaPago"].HeaderText = @"Fecha Pago";
            dgvGrilla.Columns["FechaPago"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaPago"].DisplayIndex = 5;

            dgvGrilla.Columns["Estado"].Visible = true;
            dgvGrilla.Columns["Estado"].Width = 100;
            dgvGrilla.Columns["Estado"].HeaderText = @"Estado";
            dgvGrilla.Columns["Estado"].DefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            dgvGrilla.Columns["Estado"].DisplayIndex = 6;

        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            elementoSeleccionado = (ReciboDto)dgvGrilla.Rows[e.RowIndex].DataBoundItem;

            _recibo = elementoSeleccionado;
        }

        private void _7_FormularioConsultaRecibosCredito_Load(object sender, System.EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            ActualizarDatos(txtBuscar.Text.Trim());
        }

        private void btnCompletar_Click(object sender, System.EventArgs e)
        {
            
            if (puedeEjecutarComando)
            {
                var recibo = (ReciboDto)elementoSeleccionado;

                lista = _reciboServicio.ObtenerPorCredito(credito.Id, string.Empty).ToList();


                    if (recibo.Pago > 0m)
                    {
                        if (Mensaje.Mostrar("Este Recibo ya fue completado anteriormente. Desea Modificarlo?", Mensaje.Tipo.Pregunta) == DialogResult.Yes)
                        {
                            var formularioCompletar = new _8_FormularioCompletarRecibo((ReciboDto)elementoSeleccionado);

                            formularioCompletar.ShowDialog();

                            if (formularioCompletar.realizoAlgunaOperacion)
                            {
                                ActualizarDatos(string.Empty);
                            }
                        }

                    }
                    else
                    {
                        var formularioCompletar1 = new _8_FormularioCompletarRecibo((ReciboDto)elementoSeleccionado);
                        formularioCompletar1.ShowDialog();

                        if (formularioCompletar1.realizoAlgunaOperacion)
                        {
                            ActualizarDatos(string.Empty);
                        }

                    }
            }
            else
            {
                Mensaje.Mostrar("Debe seleccionar un recibo para poder continuar.", Mensaje.Tipo.Informacion);
            }
        }

        private void dgvGrilla_DataSourceChanged(object sender, System.EventArgs e)
        {
            puedeEjecutarComando = this.dgvGrilla.RowCount > 0;

        }

        private void CargarDatosImpresion()
        {
            _creditoImprimir = _creditoServicio.obtenerPorId(_recibo.CreditoId);
            lista = _reciboServicio.ObtenerPorCredito(_recibo.CreditoId, string.Empty).ToList();

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

            _saldo = _recibo.NumeroCuota > 1 ? _reciboAnterior.Saldo : 0m; // saldo del recibo anterior

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
                    var ultPago = _reciboAnterior.Pago > 0m ? _reciboAnterior.FechaPago.Date.ToShortDateString()
                                     + " " + _reciboAnterior.Pago.ToString("c2") : "---";

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

        private void btnVer_Click(object sender, System.EventArgs e)
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

        private void btnAtrasar_Click(object sender, System.EventArgs e)
        {
            if (puedeEjecutarComando)
            {
                var recibo = (ReciboDto)elementoSeleccionado;

                if (recibo.Estado != Constante.EstadoRecibo.Atrasado)
                {

                    var idReciboAnterior = recibo.NumeroCuota - 1 != 0 ? recibo.Id - 1 : 0;

                    var reciboAnterior = new ReciboDto();

                    if (idReciboAnterior != 0)
                    {
                        reciboAnterior = _reciboServicio.obtenerPorId(idReciboAnterior);
                    }

                    lista = _reciboServicio.ObtenerPorCredito(credito.Id, string.Empty).ToList();

                    foreach (var item in lista)
                    {
                        pagado += item.Pago;

                        if (recibo.NumeroCuota == 1)
                        {
                            pagado = 0m;
                            saldo = item.MontoCredito;
                            break;
                        }

                        if (item.NumeroCuota == recibo.NumeroCuota - 1)
                        {
                            saldo = item.Saldo;
                            break;
                        }

                    }

                    pago = recibo.Pago;

                    if (recibo.Pago > 0m)
                    {
                        if (Mensaje.Mostrar("Este Recibo ya fue completado anteriormente. Desea Atrasarlo?", Mensaje.Tipo.Pregunta) == DialogResult.Yes)
                        {
                            recibo.Pagado = pagado;
                            recibo.Estado = Constante.EstadoRecibo.Atrasado;
                            recibo.Saldo = saldo;
                            recibo.Pago = 0m;
                            recibo.Atraso = recibo.MontoCuota;
                            recibo.UltimoPago = recibo.NumeroCuota - 1 != 0 ? reciboAnterior.FechaPago.Date.ToShortDateString()
                                         + " " + reciboAnterior.Pago.ToString("c2") : "--";

                            _reciboServicio.Modificar(recibo);

                            foreach (var item in lista)
                            {
                                if (item.NumeroCuota > recibo.NumeroCuota && item.Estado != Constante.EstadoRecibo.Impago)
                                {
                                    item.Saldo = item.Saldo + pago;
                                    item.Pagado = item.Pagado - pago;

                                    _reciboServicio.Modificar(item);
                                }
                            }

                            //actualizacion de credito

                            var _lista = _reciboServicio.ObtenerPorCredito(credito.Id, string.Empty).ToList();
                            _totalAbonado = 0m;


                            foreach (var Item in _lista)
                            {
                                _totalAbonado += Item.Pago;
                            }

                            credito.TotalAbonado = _totalAbonado;
                            credito.Estado = credito.Monto == credito.TotalAbonado ? Constante.EstadoCredito.Pagado : credito.TotalAbonado > 0m ?
                                             Constante.EstadoCredito.PagadoParcial : Constante.EstadoCredito.Impago;

                            _creditoServicio.Modificar(credito);

                            ActualizarDatos(string.Empty);
                        }

                    }
                    else
                    {
                        if (Mensaje.Mostrar("Seguro Desea Atrasar este Recibo?", Mensaje.Tipo.Pregunta) == DialogResult.Yes)
                        {
                            recibo.Pagado = pagado;
                            recibo.Estado = Constante.EstadoRecibo.Atrasado;
                            recibo.Atraso = recibo.MontoCuota;
                            recibo.Saldo = saldo;
                            recibo.UltimoPago = recibo.NumeroCuota - 1 != 0 ? reciboAnterior.FechaPago.Date.ToShortDateString()
                                         + " " + reciboAnterior.Pago.ToString("c2") : "--";

                            _reciboServicio.Modificar(recibo);


                            foreach (var item in lista)
                            {
                                if (item.NumeroCuota > recibo.NumeroCuota && item.Estado != Constante.EstadoRecibo.Impago)
                                {
                                    item.Saldo = item.Saldo + pago;
                                    item.Pagado = item.Pagado - pago;

                                    _reciboServicio.Modificar(item);
                                }
                            }

                            //actualizacion de credito

                            var _lista = _reciboServicio.ObtenerPorCredito(credito.Id, string.Empty).ToList();
                            _totalAbonado = 0m;


                            foreach (var Item in _lista)
                            {
                                _totalAbonado += Item.Pago;
                            }

                            credito.TotalAbonado = _totalAbonado;
                            credito.Estado = credito.Monto == credito.TotalAbonado ? Constante.EstadoCredito.Pagado : credito.Monto > 0m ?
                                            Constante.EstadoCredito.PagadoParcial : Constante.EstadoCredito.Impago;

                            _creditoServicio.Modificar(credito);

                            ActualizarDatos(string.Empty);
                        }

                    }
                }

                else
                {
                    Mensaje.Mostrar("Debe seleccionar un recibo que no este atrasado para poder continuar.", Mensaje.Tipo.Informacion);
                }
            }

            else
            {
                Mensaje.Mostrar("Debe seleccionar un recibo para poder continuar.", Mensaje.Tipo.Informacion);
            }
        }

        private void btnImprimir_Click(object sender, System.EventArgs e)
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
                Mensaje.Mostrar("Debe seleccionar un recibo para poder continuar.", Mensaje.Tipo.Informacion);
            }

        }

        private void dgvGrilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGrilla.Rows)
            {
                if (Convert.ToString(row.Cells["Estado"].Value) != "Pagado")
                {

                    row.Cells["Estado"].Style.ForeColor = Color.Red;
                }
                else
                {
                    row.Cells["Estado"].Style.ForeColor = Color.Green;
                }
            }
        }
    }
    
}
