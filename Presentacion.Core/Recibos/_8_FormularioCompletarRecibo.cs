using Presentacion.Base.Varios;
using Servicio.Core.Cliente;
using Servicio.Core.Credito;
using Servicio.Core.Credito.Dto;
using Servicio.Core.Recibo;
using Servicio.Core.Recibo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Core.Recibos
{
    public partial class _8_FormularioCompletarRecibo : Form
    {
        private ReciboDto _recibo;
        private IClienteServicio _clienteServicio;
        private ICreditoServicio _creditoServicio;
        private IReciboServicio _reciboServicio;
        private List<ReciboDto> lista;
        private ReciboDto _reciboAnterior;
        private CreditoDto _credito;
        public bool realizoAlgunaOperacion;
        private decimal _pagado = 0m;
        private decimal _atraso = 0m;
        private string _estado;
        private decimal _pagoActual;
        private decimal _saldo;
        private decimal _totalAbonado;
        private string _fechaPago;

        public _8_FormularioCompletarRecibo(ReciboDto recibo)
        {
            InitializeComponent();

            _recibo = recibo;
            _clienteServicio = new ClienteServicio();
            _creditoServicio = new CreditoServicio();
            _reciboServicio = new ReciboServicio();

            txtPago.KeyPress += Validacion.NoLetras;
            txtPago.KeyPress += Validacion.NoSimbolos;
            txtPago.KeyPress += Validacion.NoInyeccion;

            dtpFechaPago.Value = DateTime.Now;

            CargarDatos();
            realizoAlgunaOperacion = false;
        }

        private void CargarDatos()
        {
            _credito = _creditoServicio.obtenerPorId(_recibo.CreditoId);
            var cliente = _clienteServicio.obtenerPorId(_recibo.ClienteId);
            lista = _reciboServicio.ObtenerPorCredito(_recibo.CreditoId, string.Empty).ToList();
            _estado = _recibo.Estado;

            foreach (var recibo in lista)
            {
                if (recibo.NumeroCuota == _recibo.NumeroCuota -1)
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
                    _atraso = _recibo.MontoCuota - _recibo.Pago;
                    break;
                }                

                if (item.NumeroCuota == _recibo.NumeroCuota)
                {
                    _atraso = _atraso - _recibo.Atraso;
                    break;
                }
            }

            lista.Reverse(); // probar desde aqui

            foreach (var item in lista)
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



            lblNumeroCuota.Text = _recibo.NumeroCuota.ToString();
            lblCuotasPendientes.Text = _recibo.CuotasPendiente.ToString();
            lblMontoCuota.Text = _recibo.MontoCuota.ToString("C2");
            lblCliente.Text = _recibo.ApyNomCliente;
            lblDni.Text = cliente.Dni.ToString();
            lblDireccionComercial.Text = cliente.DireccionComercial;
            lblDireccionParticular.Text = cliente.DireccionParticular;
            lblTelefono.Text = cliente.Telefono;
            lblCelular.Text = cliente.Celular;
            lblCredito.Text = _recibo.MontoCredito.ToString("c2");
            lblFechaCancelacion.Text = _credito.FechaCancelacion.ToShortDateString();


            if (_recibo.NumeroCuota == 1)
            {
                if (_recibo.Estado == Constante.EstadoRecibo.Impago)
                {
                    lblPagado.Text = "--";
                    lblSaldo.Text = "--";
                    lblUltimoPago.Text = "--";
                    lblAtraso.Text = "--";
                }
                else
                {
                    lblPagado.Text = _recibo.Pagado.ToString("c2");
                    lblSaldo.Text = _recibo.Saldo.ToString("c2"); 
                    lblUltimoPago.Text = "--";
                    lblAtraso.Text = "--";
                }
              //  _credito.Estado = Constante.EstadoCredito.PagadoParcial;
            }

            else
            {
                lblSaldo.Text = _recibo.Estado != Constante.EstadoRecibo.Impago ? _recibo.Saldo.ToString("c2") : _saldo.ToString("c2");
                lblUltimoPago.Text = _fechaPago;
                lblAtraso.Text = _atraso.ToString("c2");
                lblPagado.Text = _recibo.Estado != Constante.EstadoRecibo.Impago ? _recibo.Pagado.ToString("c2") : _pagado.ToString("c2");
            }

            if (_recibo.Pago > 0m)
            {
                txtPago.Text = _recibo.Pago.ToString();
                lblCompletado.Visible = true;
            }

        }

        private bool VerificarDatosObligatorios() 
        {
            var montoMaximo = _atraso > 0 ? _atraso + _recibo.MontoCuota : _saldo > _recibo.MontoCuota ?_recibo.MontoCuota * 2: _recibo.MontoCuota;

            if (string.IsNullOrWhiteSpace(txtPago.Text.Trim())
                || txtPago.Text == "0"
                || txtPago.Text == "00"
                || txtPago.Text == "000"
                || txtPago.Text == "0000"
                || txtPago.Text == "00000"
                || txtPago.Text == "000000"
                || txtPago.Text == "0000000"
                || decimal.Parse(txtPago.Text) > montoMaximo) return false;

            return true;
        }
    
        private bool CompletarRecibo()
        {
            _pagoActual = decimal.Parse(txtPago.Text) > _recibo.MontoCuota ? _recibo.MontoCuota : decimal.Parse(txtPago.Text);

            if (_pagoActual < _recibo.MontoCuota)
            {
                _estado = Constante.EstadoRecibo.PagadoParcial;
            }

            if (_pagoActual >= _recibo.MontoCuota)
            {
                _estado = Constante.EstadoRecibo.Pagado;

                foreach (var item in lista)
                {
                    if (item.Estado == Constante.EstadoRecibo.Atrasado && item.NumeroCuota + 1 == _recibo.NumeroCuota)
                    {
                        _pagado = _pagado + (decimal.Parse(txtPago.Text) - _pagoActual);
                        break;
                    }
                }

                if (_recibo.NumeroCuota - 1 == 1 && _recibo.Estado == Constante.EstadoRecibo.Atrasado)
                {
                    _pagado = decimal.Parse(txtPago.Text) - _pagoActual;
                }
            }


                try
                {

                   _recibo.FechaPago = dtpFechaPago.Value;
                   _recibo.Pago = _pagoActual <= _recibo.MontoCuota ? _pagoActual : _recibo.MontoCuota;
                   _recibo.Pagado = _pagado + _recibo.Pago;
                   _recibo.Atraso = _pagoActual <= _recibo.MontoCuota ? _recibo.MontoCuota - _pagoActual : 0m;
                   _recibo.Saldo = _recibo.MontoCredito - _recibo.Pagado;
                   _recibo.UltimoPago = _reciboAnterior != null ? _reciboAnterior.FechaPago.Date.ToShortDateString()
                                        + " " + _reciboAnterior.Pago.ToString("c2") : "--";
                   _recibo.Estado = _estado;

                   _reciboServicio.Modificar(_recibo);

                    var pagado = _recibo.Pagado;
                    var saldo = _recibo.Saldo;

                   foreach (var _item in lista)
                   {

                       if (_item.NumeroCuota > _recibo.NumeroCuota && _item.Estado != Constante.EstadoRecibo.Impago)
                       {
                        var reciboAnterior = new ReciboDto();

                            foreach (var recibo in lista)
                            {
                                if (recibo.NumeroCuota == _item.NumeroCuota - 1)
                                {
                                    reciboAnterior = recibo;
                                    break;
                                }
                            }

                            pagado = pagado + _item.Pago;
                            saldo = saldo - _item.Pago;

                            _item.Pagado = pagado;
                            _item.Saldo = saldo;
                            _item.UltimoPago = reciboAnterior != null ? reciboAnterior.FechaPago.Date.ToShortDateString()
                                        + " " + _reciboAnterior.Pago.ToString("c2") : "--";
                            _reciboServicio.Modificar(_item);
                       }
                   }

                 Mensaje.Mostrar("Los datos se grabaron correctamente.", Mensaje.Tipo.Informacion);
                   
                   realizoAlgunaOperacion = true;
                   
                   return true;
                       
                      
                }

                catch (Exception ex)
                {

                    Mensaje.Mostrar(ex.Message, Mensaje.Tipo.Stop);

                    return false;
                }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarDatosObligatorios())
            {
                CompletarRecibo();

                var listaReverse = _reciboServicio.ObtenerPorCredito(_recibo.CreditoId, string.Empty).ToList();

                listaReverse.Reverse(); // invierte el orden de los elementos de la lista

                if (decimal.Parse(txtPago.Text) > _recibo.MontoCuota)
                {
                    var pago = decimal.Parse(txtPago.Text) - _recibo.MontoCuota;

                    foreach (var item in listaReverse)
                    {
                        if (_recibo.NumeroCuota == 1)
                        {
                            break;
                        }

                        if (item.Estado == Constante.EstadoRecibo.PagadoParcial || item.Estado == Constante.EstadoRecibo.Atrasado
                            && item.NumeroCuota < _recibo.NumeroCuota)
                        {
                            if (item.Atraso <= pago )
                            {
                                var atrasoOriginal = item.Atraso; // atraso del recibo
                                var pagoOriginal = item.Pago; // pago anterior del recibo

                                item.Atraso = 0m;
                                item.Pagado = item.Pagado - pagoOriginal + item.MontoCuota; 
                                item.Pago = item.MontoCuota;
                                item.Saldo = item.MontoCredito - item.Pagado;
                                item.Estado = Constante.EstadoRecibo.Pagado;

                                _reciboServicio.Modificar(item);

                                pago = pago - atrasoOriginal; 
                            }

                            else
                            {
                                var pagoOriginal = item.Pago; // pago anterior del recibo

                                item.Atraso = item.Atraso - pago;
                                item.Pago = item.Pago + pago;
                                item.Pagado = item.Pagado - pagoOriginal + item.Pago; 
                                item.Saldo = item.MontoCredito - item.Pagado;
                                item.Estado = Constante.EstadoRecibo.PagadoParcial; // se agrega para el caso de recibos atrasados

                                _reciboServicio.Modificar(item);

                                pago = 0;
                            }

                            decimal pagado = item.Pagado;
                            decimal saldo = item.Saldo;

                            var listaAtualizada = _reciboServicio.ObtenerPorCredito(_recibo.CreditoId, string.Empty).ToList(); // lista actualizada

                            foreach (var _item in listaAtualizada)
                            {

                                if (_item.NumeroCuota > item.NumeroCuota && _item.Estado != Constante.EstadoRecibo.Impago)
                                {
                                    var reciboAnterior = new ReciboDto();

                                    foreach (var recibo in listaAtualizada)
                                    {
                                        if (recibo.NumeroCuota == _item.NumeroCuota - 1)
                                        {
                                            reciboAnterior = recibo;
                                            break;
                                        }
                                    }

                                    pagado = pagado + _item.Pago;
                                    saldo = saldo - _item.Pago;

                                    _item.Pagado = pagado;
                                    _item.Saldo = saldo;
                                    _item.UltimoPago = reciboAnterior != null ? reciboAnterior.FechaPago.Date.ToShortDateString()
                                                + " " + _reciboAnterior.Pago.ToString("c2") : "--";
                                    
                                    _reciboServicio.Modificar(_item);
                                }
                            }

                            if (pago == 0)
                            {
                               break;
                            }

                        }
                    }

                    var lista = _reciboServicio.ObtenerPorCredito(_recibo.CreditoId, string.Empty).ToList(); // lista actualizada luego del ciclo foreach anterior

                    foreach (var item in lista)
                    {
                        
                        if (pago == 0)
                        {

                            break;
                        }

                        if (item.Estado == Constante.EstadoRecibo.Impago && item.NumeroCuota - 1 == _recibo.NumeroCuota)
                        {
                            _totalAbonado = 0m;

                            var idReciboAnterior = item.NumeroCuota - 1 != 0 ? item.Id - 1 : 0;

                            var recibo = _reciboServicio.obtenerPorId(item.Id);
                            var reciboAnterior = new ReciboDto();

                            if (idReciboAnterior != 0)
                            {
                                reciboAnterior = _reciboServicio.obtenerPorId(idReciboAnterior);
                            }

                            recibo.FechaPago = dtpFechaPago.Value;
                            recibo.Pago = pago;
                            recibo.Pagado = reciboAnterior.Pagado + recibo.Pago;
                            recibo.Saldo = _recibo.MontoCredito - recibo.Pagado;
                            recibo.Atraso = recibo.MontoCuota - recibo.Pago;
                            recibo.UltimoPago = recibo.NumeroCuota - 1 != 0 ? reciboAnterior.FechaPago.Date.ToShortDateString()
                                     + " " + reciboAnterior.Pago.ToString("c2") : "--";

                            if (recibo.Pago < recibo.MontoCuota)
                            {
                                recibo.Estado = Constante.EstadoRecibo.PagadoParcial;
                            }
                            if (recibo.Pago >= recibo.MontoCuota)
                            {
                                recibo.Estado = Constante.EstadoRecibo.Pagado;
                            }

                            _reciboServicio.Modificar(recibo);

                            break;
                        }

                    }

                }

                var bandera = true;
                var _lista = _reciboServicio.ObtenerPorCredito(_credito.Id, string.Empty).ToList();
                _totalAbonado = 0m;


                foreach (var Item in _lista)
                {
                    _totalAbonado += Item.Pago;
                    if (Item.Estado != Constante.EstadoRecibo.Pagado)
                    {
                        bandera = false;
                    }
                }

                _credito.TotalAbonado = _totalAbonado;
                _credito.Estado = bandera == true ? Constante.EstadoCredito.Pagado : Constante.EstadoCredito.PagadoParcial; // probar

                _creditoServicio.Modificar(_credito);

                Close();
            }

        }
    }
}
