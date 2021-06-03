using Presentacion.Base;
using Presentacion.Base.Varios;
using Servicio.Core.Cliente;
using Servicio.Core.Cliente.Dto;
using Servicio.Core.Credito;
using Servicio.Core.Credito.Dto;
using Servicio.Core.Recibo;
using Servicio.Core.Recibo.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Core.Credito
{
    public partial class _12_FormularioRefinanciacionCredito : FormularioABM
    {
        private readonly ICreditoServicio _CreditoServicio;

        private readonly IClienteServicio _clienteServicio;

        private readonly IReciboServicio _reciboServicio;

        private string tipoTransaccion;

        private CreditoDto _credito;

        private ClienteDto _cliente;

        private decimal valorCuota;

        private int dias;

        private decimal monto;

        private int interesEfectivo = 30;

        public bool realizoAlgunaOperacion = false;

        public _12_FormularioRefinanciacionCredito(CreditoDto credito, string _tipoOperacion, string _tipoTransaccion, long? _entidadId)
               : base(_tipoOperacion, _entidadId)
        {
            InitializeComponent();

            _CreditoServicio = new CreditoServicio();

            _clienteServicio = new ClienteServicio();

            _reciboServicio = new ReciboServicio();

            _credito = credito;

            _cliente = _clienteServicio.obtenerPorId(_credito.ClienteId);

            Init(_tipoOperacion, _entidadId);

            tipoTransaccion = _tipoTransaccion;

            monto = (((_credito.Monto - _credito.TotalAbonado) * 30m) / 100m) + (_credito.Monto - _credito.TotalAbonado);
            monto = decimal.Round(monto, 2);


            dias = (int)nudCuotas.Value * 7;

            txtCodigo.Text = _CreditoServicio.ObtenerSiguienteCodigo().ToString();
            dtpEmision.Value = DateTime.Now;
            dtpCancelacion.Value = dtpEmision.Value.AddDays(dias);
            valorCuota = monto / 1m;
            this.Size = new Size(452, 466);
            txtMonto.Text = monto.ToString(); // monto Refinanciado
            txtCliente.Text = _credito.ApyNomCliente;
            txtPrecio.Text = valorCuota.ToString();
            lblInteres.Text = "INTERES 30 % SOBRE $" + (_credito.Monto - _credito.TotalAbonado).ToString();
            lblCobro.Text = "SE COBRA PRIMERA CUOTA EL " + dtpEmision.Value.AddDays(7).ToShortDateString();
            lblRefinanciacion.Text = "Refinanciacion Credito N° " + _credito.CodigoCredito.ToString();
            this.btnLimpiar.Visible = false;
            
        }

        private void nudCuotas_ValueChanged(object sender, EventArgs e)
        {

            dias = (int)nudCuotas.Value * 7;

            valorCuota = decimal.Parse(txtMonto.Text) / nudCuotas.Value;

            valorCuota = decimal.Round(valorCuota, 2);

            txtPrecio.Text = valorCuota.ToString();

            dtpCancelacion.Value = dtpEmision.Value.AddDays(dias);

            lblCobro.Text = "SE COBRA PRIMERA CUOTA EL " + dtpEmision.Value.AddDays(7).ToShortDateString();
        }

        public override bool EjecutarComandoNuevo()
        {
            try
            {
                var creditoNuevo = new CreditoDto
                {
                    CodigoCredito = int.Parse(txtCodigo.Text),
                    codigoCreditoBase = _credito.CodigoCredito,
                    TipoCredito = tipoTransaccion,
                    ClienteId = _cliente.Id,
                    Monto = monto,
                    FechaEmision = dtpEmision.Value,
                    CantidadCuotas = (int)nudCuotas.Value,
                    MontoCuota = valorCuota,
                    TotalAbonado = 0m,
                    Estado = Constante.EstadoCredito.Impago,
                    FechaCancelacion = dtpCancelacion.Value,
                    Interes = interesEfectivo,
                    Refinanciado = null
                };

                _CreditoServicio.Insertar(creditoNuevo);

                var credito = _CreditoServicio.obtenerPorCodigo(int.Parse(txtCodigo.Text));

                for (int i = 1; i <= (int)nudCuotas.Value; i++)
                {
                    var _dias = 7 * i;

                    var _fechaPago = new DateTime();

                    _fechaPago = dtpEmision.Value.AddDays(_dias);

                    var reciboNuevo = new ReciboDto
                    {
                        Numero = _reciboServicio.ObtenerSiguienteCodigo(),
                        MontoCredito = credito.Monto,
                        NumeroCuota = i,
                        CuotasPendiente = (int)nudCuotas.Value - i,
                        MontoCuota = valorCuota,
                        Saldo = credito.Monto,
                        UltimoPago = " Completar",
                        Atraso = 0m,
                        Pagado = 0m,
                        FechaPago = _fechaPago,
                        Pago = 0m,
                        Estado = Constante.EstadoRecibo.Impago,
                        CreditoId = credito.Id,
                        ClienteId = _cliente.Id
                        
                    };

                    _reciboServicio.Insertar(reciboNuevo);

                    //Modificar credito base por refinanciacion

                    _credito.Refinanciado = true;

                    _CreditoServicio.Modificar(_credito);
                }

                Mensaje.Mostrar("Los datos se grabaron Correctamente", Mensaje.Tipo.Informacion);

                realizoAlgunaOperacion = true;

                return true;
            }
            catch (Exception ex)
            {

                Mensaje.Mostrar(ex.Message, Mensaje.Tipo.Stop);

                return false;
            }
        }

        public override bool VerificarSiExiste()
        {
            return _CreditoServicio.VerificarSiExiste(entidadId, int.Parse(txtCodigo.Text));
        }

        public override bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text.Trim())) return false;
            if (string.IsNullOrWhiteSpace(txtMonto.Text.Trim()) || txtMonto.Text == 0m.ToString()) return false;
            if (string.IsNullOrWhiteSpace(nudCuotas.Value.ToString()) || nudCuotas.Value < 1) return false;
            if (string.IsNullOrWhiteSpace(txtPrecio.Text) || txtPrecio.Text == 0m.ToString()) return false;
            if (dtpEmision.Value >= dtpCancelacion.Value) return false;

            return true;
        }
    }
}
