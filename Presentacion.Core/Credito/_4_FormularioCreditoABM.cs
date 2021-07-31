using Presentacion.Base;
using Presentacion.Base.Varios;
using Presentacion.Core.Clientes;
using Servicio.Core.Cliente;
using Servicio.Core.Cliente.Dto;
using Servicio.Core.Credito;
using Servicio.Core.Credito.Dto;
using Servicio.Core.Recibo;
using Servicio.Core.Recibo.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Presentacion.Core.Credito
{
    public partial class _4_FormularioCreditoABM : FormularioABM
    {
        private readonly ICreditoServicio _CreditoServicio;

        private readonly IClienteServicio _clienteServicio;

        private readonly IReciboServicio _reciboServicio;

        private string tipoTransaccion;
        
        private ClienteDto _cliente;

        private CreditoDto _credito;

        private decimal valorCuota;

        private int dias;

        private decimal monto;

        private List<ReciboDto> lista;

        private int interesEfectivo = 30;

        private int? valorInteres;

        private decimal valorMonto;



        public _4_FormularioCreditoABM(string _tipoOperacion, string _tipoTransaccion, long? _entidadId)
               : base(_tipoOperacion, _entidadId)
        {
            InitializeComponent();

            _CreditoServicio = new CreditoServicio();

            _clienteServicio = new ClienteServicio();

            _reciboServicio = new ReciboServicio();

            tipoTransaccion = _tipoTransaccion;

            Init(_tipoOperacion, _entidadId);

            if (_tipoOperacion == Constante.TipoOperacion.Nuevo)
            {
                dias = (int)nudCuotas.Value * 7;
                txtCodigo.Text = _CreditoServicio.ObtenerSiguienteCodigo().ToString();
                dtpCancelacion.Value = dtpEmision.Value.AddDays(dias);
                
                if(_tipoTransaccion == Constante.TipoCredito.Efecitvo)
                {
                    valorCuota = (((1000m / 5m) * 30m) / 100m) + (1000m / 5m);
                    Text = "Crear Credito Efectivo";
                    this.Size = new System.Drawing.Size(425, 430);
                    txtPrecio.Text = valorCuota.ToString();
                    nudCuotas.Maximum = 12;
                    lblInteres6.Text = "Interes 30%";
                    lblCobro.Text = "SE COBRA PRIMERA CUOTA EL " + dtpEmision.Value.AddDays(7).ToShortDateString();
                    
                }

                if (_tipoTransaccion == Constante.TipoCredito.Mueble)
                {
                    Text = "Crear Credito Mueble";
                    lblInteres6.Visible = false;
                    valorCuota = 1000m / 5m;
                    txtPrecio.Text = valorCuota.ToString();
                    nudCuotas.Maximum = 50;
                }
            }

            if (_tipoOperacion == Constante.TipoOperacion.Modificar)
            {
                _credito = _CreditoServicio.obtenerPorId(_entidadId);

                if (_tipoTransaccion == Constante.TipoCredito.Efecitvo)
                {
                    Text = "Modificar Credito Efectivo";
                    this.Size = new System.Drawing.Size(425, 430);
                    nudCuotas.Maximum = 12;

                }

                if (_tipoTransaccion == Constante.TipoCredito.Mueble)
                {
                    Text = "Modificar Credito Mueble";
                    lblInteres6.Visible = false;
                    nudCuotas.Maximum = 50;
                }
            }

            if (_tipoOperacion == Constante.TipoOperacion.Eliminar)
            {
                _credito = _CreditoServicio.obtenerPorId(_entidadId);

                if (_tipoTransaccion == Constante.TipoCredito.Efecitvo)
                {
                    Text = "Eliminar Credito Efectivo";
                    this.Size = new System.Drawing.Size(425, 430);

                }

                if (_tipoTransaccion == Constante.TipoCredito.Mueble)
                {
                    Text = "Eliminar Credito Mueble";
                    lblInteres6.Visible = false;
                }

            }

            txtMonto.KeyPress += Validacion.NoLetras;
            txtMonto.KeyPress += Validacion.NoSimbolos;
            txtMonto.KeyPress += Validacion.NoInyeccion;

        }

        public override void CargarDatos(long? _entidadId)
        {
            var credito = _CreditoServicio.obtenerPorId(_entidadId.Value);
            _cliente = _clienteServicio.obtenerPorId(credito.ClienteId);
            tipoTransaccion = credito.TipoCredito;
            valorInteres = credito.Interes;

            txtCodigo.Text = credito.CodigoCredito.ToString();
            txtCliente.Text = credito.ApyNomCliente;
            dtpEmision.Value = credito.FechaEmision;
            nudCuotas.Value = credito.CantidadCuotas;
            txtPrecio.Text = credito.MontoCuota.ToString();
            dtpCancelacion.Value = credito.FechaCancelacion;

            switch (credito.CantidadCuotas)
            {
                case 5:
                    lblInteres6.Text = "Interes 30%";
                    break;
                case 6:
                    lblInteres6.Text = "Interes 36%";
                    break;
                case 7:
                    lblInteres6.Text = "Interes 42%";
                    break;
                case 8:
                    lblInteres6.Text = "Interes 48%";
                    break;
                case 9:
                    lblInteres6.Text = "Interes 54%";
                    break;
                case 10:
                    lblInteres6.Text = "Interes 60%";
                    break;
                case 11:
                    lblInteres6.Text = "Interes 66%";
                    break;
                case 12:
                    lblInteres6.Text = "Interes 72%";
                    break;
            }


            if (tipoTransaccion == Constante.TipoCredito.Efecitvo)
            {
                if (!string.IsNullOrEmpty(txtMonto.Text) && nudCuotas.Value >= 1)
                {
                  
                    switch (nudCuotas.Value)
                    {
                        case 5m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 30) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 30) / 100;

                            interesEfectivo = 30;
 
                            break;
                        case 6m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 36) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 36) / 100;

                            interesEfectivo = 36;

                            break;
                        case 7m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 42) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 42) / 100;

                            interesEfectivo = 42;
                            break;
                        case 8m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 48) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 48) / 100;

                            interesEfectivo = 48;
                            break;
                        case 9m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 54) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 54) / 100;

                            interesEfectivo = 54;
                            break;
                        case 10m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 60) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 60) / 100;

                            interesEfectivo = 60;
                            break;
                        case 11m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 66) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 66) / 100;

                            interesEfectivo = 66;
                            break;
                        case 12m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 72) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 72) / 100;

                            interesEfectivo = 72;
                            break;
                    }

                    valorMonto = credito.Monto - ((interesEfectivo * credito.Monto) / (100 + interesEfectivo)); //probar
                    valorMonto = decimal.Round(valorMonto, 0);
                    txtMonto.Text = valorMonto.ToString();
                }

                else
                {
                    valorCuota = 0m;
                }

            }

            if (tipoTransaccion == Constante.TipoCredito.Mueble)
            {
                valorCuota = !string.IsNullOrEmpty(txtMonto.Text) && nudCuotas.Value >= 1 ? decimal.Parse(txtMonto.Text) /
                nudCuotas.Value : 0m;
                monto = !string.IsNullOrEmpty(txtMonto.Text) ? decimal.Parse(txtMonto.Text) : 0m;
                monto = decimal.Round(monto, 0);
                txtMonto.Text = credito.Monto.ToString(); //probar
            }

            valorCuota = decimal.Round(valorCuota, 2);

        }

        public override void LimpiarDatos(object obj)
        {
            txtCliente.Clear();
            txtMonto.Text = "1000";

            if (tipoTransaccion == Constante.TipoCredito.Efecitvo)
            {
                monto = 1300m;
            }

            if (tipoTransaccion == Constante.TipoCredito.Mueble)
            {
                monto = 1000m;
            }

            nudCuotas.Value = 5m;
            valorCuota = (((1000m / 5m) * 30m) / 100m) + (1000m / 5m);
            txtPrecio.Text = valorCuota.ToString();
            dtpEmision.Value = System.DateTime.Now;
            dtpCancelacion.Value = System.DateTime.Now;

            if (tipoTransaccion == Constante.TipoCredito.Mueble)
            {
                valorCuota = 1000m / 5m;
                txtPrecio.Text = valorCuota.ToString();
            }


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

        private void btnSeleccionarCliente_Click(object sender, System.EventArgs e)
        {
            var formularioLookUp = new _5_FormularioLookUpClientes(null);

            formularioLookUp.ShowDialog();

             _cliente = (ClienteDto)formularioLookUp.elementoSeleccionado;

            if (formularioLookUp.Entidad != null)
            {
                txtCliente.Text = _cliente.ApyNom;
            }

            else
            {
                _cliente = null;
                txtCliente.Text = string.Empty;
            }    
        }

        public override bool EjecutarComandoNuevo()
        {

            try
            {
                var creditoNuevo = new CreditoDto
                {
                    CodigoCredito = int.Parse(txtCodigo.Text),
                    codigoCreditoBase = null,
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

                if (tipoTransaccion == Constante.TipoCredito.Mueble)
                {
                    creditoNuevo.Interes = null;
                }

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
                        ClienteId = _cliente.Id,
                        CodigoCredito = credito.CodigoCredito
                    };

                    _reciboServicio.Insertar(reciboNuevo);
                }
                
                Mensaje.Mostrar("Los datos se grabaron Correctamente", Mensaje.Tipo.Informacion);

                return true;
            }
            catch (Exception ex)
            {

                Mensaje.Mostrar(ex.Message, Mensaje.Tipo.Stop);

                return false;
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (tipoTransaccion == Constante.TipoCredito.Efecitvo)
            {
                if (!string.IsNullOrEmpty(txtMonto.Text) && nudCuotas.Value >= 1)
                {

                    switch (nudCuotas.Value)
                    {
                        case 5m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 30) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 30) / 100;

                            interesEfectivo = 30;
                            break;
                        case 6m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 36) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 36) / 100;

                            interesEfectivo = 36;
                            break;
                        case 7m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 42) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 42) / 100;

                            interesEfectivo = 42;
                            break;
                        case 8m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 48) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 48) / 100;

                            interesEfectivo = 48;
                            break;
                        case 9m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 54) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 54) / 100;

                            interesEfectivo = 54;
                            break;
                        case 10m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 60) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 60) / 100;

                            interesEfectivo = 60;
                            break;
                        case 11m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 66) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 66) / 100;

                            interesEfectivo = 66;
                            break;
                        case 12m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 72) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 72) / 100;

                            interesEfectivo = 72;
                            break;
                    }
                }

                else
                {
                    valorCuota = 0m;
                }

            }
 
            if (tipoTransaccion == Constante.TipoCredito.Mueble)
            {
                valorCuota = !string.IsNullOrEmpty(txtMonto.Text) && nudCuotas.Value >= 1 ? decimal.Parse(txtMonto.Text) /
                nudCuotas.Value : 0m;
                monto = !string.IsNullOrEmpty(txtMonto.Text) ? decimal.Parse(txtMonto.Text) : 0m;
            }

            valorCuota = decimal.Round(valorCuota, 2);
            monto = decimal.Round(monto, 0);

            txtPrecio.Text = valorCuota.ToString();
        }

        private void nudCuotas_ValueChanged(object sender, EventArgs e)
        {
            dias = (int)nudCuotas.Value * 7;

            if (tipoTransaccion == Constante.TipoCredito.Efecitvo)
            {
                if (!string.IsNullOrEmpty(txtMonto.Text) && nudCuotas.Value >= 1)
                {

                    switch (nudCuotas.Value)
                    {
                        case 5m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 30) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 30) / 100;

                            interesEfectivo = 30;

                            lblInteres6.Text = "Interes 30%";
                            break;

                        case 6m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 36) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 36) / 100;

                            interesEfectivo = 36;

                            lblInteres6.Text = "Interes 36%";
                            break;
                        case 7m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 42) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 42) / 100;

                            interesEfectivo = 42;

                            lblInteres6.Text = "Interes 42%";
                            break;
                        case 8m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 48) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 48) / 100;

                            interesEfectivo = 48;

                            lblInteres6.Text = "Interes 48%";
                            break;
                        case 9m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 54) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 54) / 100;

                            interesEfectivo = 54;

                            lblInteres6.Text = "Interes 54%";
                            break;
                        case 10m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 60) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 60) / 100;

                            interesEfectivo = 60;

                            lblInteres6.Text = "Interes 60%";
                            break;
                        case 11m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 66) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 66) / 100;

                            interesEfectivo = 66;

                            lblInteres6.Text = "Interes 66%";
                            break;
                        case 12m:
                            valorCuota = ((decimal.Parse(txtMonto.Text) / nudCuotas.Value) * 72) / 100 + (decimal.Parse(txtMonto.Text) / nudCuotas.Value);

                            monto = decimal.Parse(txtMonto.Text) + (decimal.Parse(txtMonto.Text) * 72) / 100;

                            interesEfectivo = 72;

                            lblInteres6.Text = "Interes 72%";
                            break;
                    }
                }

                else
                {
                    valorCuota = 0m;
                }
            }

            if (tipoTransaccion == Constante.TipoCredito.Mueble)
            {
                valorCuota = !string.IsNullOrEmpty(txtMonto.Text) && nudCuotas.Value >= 1 ? decimal.Parse(txtMonto.Text) /
                nudCuotas.Value : 0m;
                monto = decimal.Parse(txtMonto.Text);
            }

            valorCuota = decimal.Round(valorCuota, 2);

            monto = decimal.Round(monto, 0);

            txtPrecio.Text = valorCuota.ToString();

            dtpCancelacion.Value = dtpEmision.Value.AddDays(dias);
        }

        public override bool EjecutarComandoModificar()
        {
        
            try
            {
                var creditoModificar = new CreditoDto
                {
                    Id = entidadId.Value,
                    ClienteId = _cliente.Id,
                    Monto = monto,
                    CantidadCuotas = (int)nudCuotas.Value,
                    MontoCuota = valorCuota,
                    Interes = interesEfectivo,
                    FechaEmision = dtpEmision.Value,
                    FechaCancelacion = dtpCancelacion.Value,
                    Estado = _credito.Estado
                    
                };

                if (tipoTransaccion == Constante.TipoCredito.Mueble)
                {
                    creditoModificar.Interes = null;
                }

                _CreditoServicio.Modificar(creditoModificar);

                lista = _reciboServicio.ObtenerPorCredito(entidadId.Value, string.Empty).ToList(); //probar desde aqui

                foreach (var item in lista)
                {
                    _reciboServicio.Eliminar(item.Id);
                }

                for (int i = 1; i <= (int)nudCuotas.Value; i++)
                {
                    var _dias = 7 * i;

                    var _fechaPago = new DateTime();

                    _fechaPago = dtpEmision.Value.AddDays(_dias);

                    var reciboNuevo = new ReciboDto
                    {
                        Numero = _reciboServicio.ObtenerSiguienteCodigo(),
                        MontoCredito = creditoModificar.Monto,
                        NumeroCuota = i,
                        CuotasPendiente = (int)nudCuotas.Value - i,
                        MontoCuota = valorCuota,
                        Saldo = creditoModificar.Monto,
                        UltimoPago = " Completar",
                        Atraso = 0m,
                        Pagado = 0m,
                        FechaPago = _fechaPago,
                        Pago = 0m,
                        Estado = Constante.EstadoRecibo.Impago,
                        CreditoId = creditoModificar.Id,
                        ClienteId = _cliente.Id,
                        CodigoCredito = creditoModificar.CodigoCredito
                    };

                    _reciboServicio.Insertar(reciboNuevo);
                }

                // hasta aqui

                //var recibos = _reciboServicio.ObtenerPorCredito(entidadId, string.Empty);

                //var _dias = 7;

                //var _fechaPago = new DateTime();

                //_fechaPago = dtpEmision.Value.AddDays(_dias);

                //foreach (var item in recibos)
                //{
                //    item.FechaPago = _fechaPago;
                //    item.MontoCredito = monto;
                //    item.MontoCuota = valorCuota;
                //    item.ClienteId = creditoModificar.ClienteId;

                //    _reciboServicio.Modificar(item);

                //    _dias += 7;

                //    _fechaPago = dtpEmision.Value.AddDays(_dias);
                //}

                Mensaje.Mostrar("Los datos se Modificaron Correctamente.", Mensaje.Tipo.Informacion);

                return true;
            }
            catch (Exception ex)
            {

                Mensaje.Mostrar(ex.Message, Mensaje.Tipo.Stop);

                return false;
            }
        }

        public override bool EjecutarComandoEliminar()
        {
            try
            {
                lista = _reciboServicio.ObtenerPorCredito(entidadId.Value, string.Empty).ToList();

                foreach (var item in lista)
                {
                    _reciboServicio.Eliminar(item.Id);
                }

                if (_credito.Refinanciado == true)
                {
                    long idCreditoRefinanciado = 0;

                    var refinanciacion = _CreditoServicio.obtenerRefinanciacion(_credito.CodigoCredito, _credito.ClienteId);

                    foreach (var item in refinanciacion)
                    {
                        idCreditoRefinanciado = item.Id;
                    }
                    
                    var _lista = _reciboServicio.ObtenerPorCredito(idCreditoRefinanciado, string.Empty).ToList();

                    foreach (var item in _lista)
                    {
                        _reciboServicio.Eliminar(item.Id);
                    }

                    _CreditoServicio.Eliminar(idCreditoRefinanciado);
                }

                _CreditoServicio.Eliminar(entidadId.Value);

                Mensaje.Mostrar(@"Los Datos se Eliminaron Correctamente.", Mensaje.Tipo.Informacion);

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

        private void dtpEmision_ValueChanged(object sender, EventArgs e)
        {
            dias = ((int)nudCuotas.Value) * 7;

            dtpCancelacion.Value = dtpEmision.Value.AddDays(dias);

            lblCobro.Text = "SE COBRA PRIMERA CUOTA EL " + dtpEmision.Value.AddDays(7).ToShortDateString();
        }
    }
}
