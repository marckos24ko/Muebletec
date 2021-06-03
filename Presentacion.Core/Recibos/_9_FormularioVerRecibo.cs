using Presentacion.Base.Varios;
using Servicio.Core.Cliente;
using Servicio.Core.Credito;
using Servicio.Core.Credito.Dto;
using Servicio.Core.Recibo;
using Servicio.Core.Recibo.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Core.Recibos
{
    public partial class _9_FormularioVerRecibo : Form
    {
        private ReciboDto _recibo;
        private IClienteServicio _clienteServicio;
        private ICreditoServicio _creditoServicio;
        private IReciboServicio _reciboServicio;
        private List<ReciboDto> lista;
        private ReciboDto _reciboAnterior;
        private CreditoDto _credito;
        private decimal _pagado = 0m;
        private decimal _saldo;
        private decimal _atraso = 0m;

        public _9_FormularioVerRecibo(ReciboDto recibo)
        {
            InitializeComponent();

            _recibo = recibo;
            _clienteServicio = new ClienteServicio();
            _creditoServicio = new CreditoServicio();
            _reciboServicio = new ReciboServicio();

            CargarDatos();
        }

        private void CargarDatos()
        {
            _credito = _creditoServicio.obtenerPorId(_recibo.CreditoId);
            var cliente = _clienteServicio.obtenerPorId(_recibo.ClienteId);
            var saldo = _credito.Monto - _credito.TotalAbonado;
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
                    _atraso = _recibo.MontoCuota - _recibo.Pago;
                    break;
                }

                if (item.NumeroCuota == _recibo.NumeroCuota)
                {
                    _atraso = _atraso - _recibo.Atraso;
                    break;
                }
            }

            _saldo = _recibo.NumeroCuota > 1 ? _reciboAnterior.Saldo : 0m; // saldo del recibo anterior


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
            lblPago.Text = _recibo.Pago != 0m ? _recibo.Pago.ToString("c2") : "--";
            lblFechaPago.Text = _recibo.Pago != 0m ? _recibo.FechaPago.ToShortDateString() : "--";

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
            }

            else
            {
                lblSaldo.Text = _recibo.Estado != Constante.EstadoRecibo.Impago ? _recibo.Saldo.ToString("c2") : _saldo.ToString("c2");
                lblUltimoPago.Text = _reciboAnterior.Pago > 0m ? _reciboAnterior.FechaPago.Date.ToShortDateString()
                                     + " " + _reciboAnterior.Pago.ToString("c2") : "--";
                lblAtraso.Text = _atraso.ToString("c2");
                lblPagado.Text = _recibo.Estado != Constante.EstadoRecibo.Impago ? _recibo.Pagado.ToString("c2") : _pagado.ToString("c2");
            }

        }
    }
}
