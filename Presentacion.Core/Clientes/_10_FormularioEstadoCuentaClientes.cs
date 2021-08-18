using Presentacion.Base.Varios;
using Servicio.Core.Cliente;
using Servicio.Core.Cliente.Dto;
using Servicio.Core.Credito;
using Servicio.Core.Credito.Dto;
using Servicio.Core.Recibo;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Core.Clientes
{
    public partial class _10_FormularioEstadoCuentaClientes : Form
    {

        private readonly ICreditoServicio _creditoServicio;
        private readonly IReciboServicio _reciboServicio;
        private readonly IClienteServicio _clienteServicio;
        private long _clienteId;
        public CreditoDto _creditoSeleccionado;
        private CreditoDto _refinanciacionSeleccionada;
        private ClienteDto _cliente;

        public _10_FormularioEstadoCuentaClientes(long clienteId)
        {
            InitializeComponent();

            _creditoServicio = new CreditoServicio();
            _reciboServicio = new ReciboServicio();
            _clienteServicio = new ClienteServicio();
            _clienteId = clienteId;

            ActualizarDatosCreditos(string.Empty);

            _cliente = _clienteServicio.obtenerPorId(clienteId);

        }

        private void ActualizarDatosCreditos(string cadenaBuscar)
        {
            dgvGrillaCreditos.DataSource = _creditoServicio.ObtenerTodosPorCliente(_clienteId, cadenaBuscar);
            FormatearGrillaCreditos(dgvGrillaCreditos);

            if (dgvGrillaCreditos.RowCount == 0)
            {
                _creditoSeleccionado = null;
                lblDeuda.Text = "NO HAY CREDITOS DISPONIBLES";
                lblDeuda.ForeColor = Color.White;
            }
        }

        private void FormatearGrillaCreditos(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["FechaEmision"].Visible = false;
            dgvGrilla.Columns["CantidadCuotas"].Visible = false;
            dgvGrilla.Columns["MontoCuota"].Visible = false;
            dgvGrilla.Columns["ApyNomCliente"].Visible = false;
            dgvGrilla.Columns["ClienteId"].Visible = false;
            dgvGrilla.Columns["TipoCredito"].Visible = false;
            dgvGrilla.Columns["Interes"].Visible = false;
            dgvGrilla.Columns["Extension"].Visible = false;
            dgvGrilla.Columns["Refinanciado"].Visible = false;
            dgvGrilla.Columns["CodigoCreditoBase"].Visible = false;


            dgvGrilla.Columns["CodigoCredito"].Visible = true;
            dgvGrilla.Columns["CodigoCredito"].Width = 50;
            dgvGrilla.Columns["CodigoCredito"].HeaderText = @"Código";
            dgvGrilla.Columns["CodigoCredito"].DisplayIndex = 0;

            dgvGrilla.Columns["Monto"].Visible = true;
            dgvGrilla.Columns["Monto"].Width = 100;
            dgvGrilla.Columns["Monto"].HeaderText = @"Monto";
            dgvGrilla.Columns["Monto"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["Monto"].DisplayIndex = 1;

            dgvGrilla.Columns["TotalAbonado"].Visible = true;
            dgvGrilla.Columns["TotalAbonado"].Width = 100;
            dgvGrilla.Columns["TotalAbonado"].HeaderText = @"Total Abonado";
            dgvGrilla.Columns["TotalAbonado"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["TotalAbonado"].DisplayIndex = 2;

            dgvGrilla.Columns["Estado"].Visible = true;
            dgvGrilla.Columns["Estado"].Width = 100;
            dgvGrilla.Columns["Estado"].HeaderText = @"Estado";
            dgvGrilla.Columns["Estado"].DefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            dgvGrilla.Columns["Estado"].DisplayIndex = 3;

            dgvGrilla.Columns["FechaCancelacion"].Visible = true;
            dgvGrilla.Columns["FechaCancelacion"].Width = 100;
            dgvGrilla.Columns["FechaCancelacion"].HeaderText = @"Cancelacion";
            dgvGrilla.Columns["FechaCancelacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaCancelacion"].DisplayIndex = 4;

            dgvGrilla.Columns["RefinanciadoStr"].Visible = true;
            dgvGrilla.Columns["RefinanciadoStr"].Width = 100;
            dgvGrilla.Columns["RefinanciadoStr"].HeaderText = @"Refinanciado";
            dgvGrilla.Columns["RefinanciadoStr"].DisplayIndex = 5;

        }

        private void FormatearGrillaRefinanciacion(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["FechaEmision"].Visible = false;
            dgvGrilla.Columns["CantidadCuotas"].Visible = false;
            dgvGrilla.Columns["MontoCuota"].Visible = false;
            dgvGrilla.Columns["ApyNomCliente"].Visible = false;
            dgvGrilla.Columns["ClienteId"].Visible = false;
            dgvGrilla.Columns["TipoCredito"].Visible = false;
            dgvGrilla.Columns["Interes"].Visible = false;
            dgvGrilla.Columns["Extension"].Visible = false;
            dgvGrilla.Columns["Refinanciado"].Visible = false;
            dgvGrilla.Columns["CodigoCreditoBase"].Visible = false;
            dgvGrilla.Columns["RefinanciadoStr"].Visible = false;


            dgvGrilla.Columns["CodigoCredito"].Visible = true;
            dgvGrilla.Columns["CodigoCredito"].Width = 50;
            dgvGrilla.Columns["CodigoCredito"].HeaderText = @"Código";
            dgvGrilla.Columns["CodigoCredito"].DisplayIndex = 0;

            dgvGrilla.Columns["Monto"].Visible = true;
            dgvGrilla.Columns["Monto"].Width = 100;
            dgvGrilla.Columns["Monto"].HeaderText = @"Monto";
            dgvGrilla.Columns["Monto"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["Monto"].DisplayIndex = 1;

            dgvGrilla.Columns["TotalAbonado"].Visible = true;
            dgvGrilla.Columns["TotalAbonado"].Width = 100;
            dgvGrilla.Columns["TotalAbonado"].HeaderText = @"Total Abonado";
            dgvGrilla.Columns["TotalAbonado"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["TotalAbonado"].DisplayIndex = 2;

            dgvGrilla.Columns["Estado"].Visible = true;
            dgvGrilla.Columns["Estado"].Width = 100;
            dgvGrilla.Columns["Estado"].HeaderText = @"Estado";
            dgvGrilla.Columns["Estado"].DefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            dgvGrilla.Columns["Estado"].DisplayIndex = 3;

            dgvGrilla.Columns["FechaCancelacion"].Visible = true;
            dgvGrilla.Columns["FechaCancelacion"].Width = 100;
            dgvGrilla.Columns["FechaCancelacion"].HeaderText = @"Cancelacion";
            dgvGrilla.Columns["FechaCancelacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaCancelacion"].DisplayIndex = 4;

        }

        private void ActualizarDatosRecibos(string cadenaBuscar, long? creditoId)
        {
            if (_creditoSeleccionado != null)
            {
                dgvGrillaRecibos.DataSource = _reciboServicio.ObtenerPorCredito(creditoId, cadenaBuscar);
                FormatearGrillaRecibos(dgvGrillaRecibos);

                ActualizarDatosCreditoRefinanciado();

            }
            else
            {
                dgvGrillaRecibos.DataSource = _reciboServicio.ObtenerPorCredito(null, cadenaBuscar);
                FormatearGrillaRecibos(dgvGrillaRecibos);
            }
          
        }

        private void ActualizarDatosCreditoRefinanciado()
        {
            if (_creditoSeleccionado != null)
            {



                if (_creditoSeleccionado.Refinanciado == true)
                {

                    dgvRefinanciacion.DataSource = _creditoServicio.obtenerRefinanciacion(_creditoSeleccionado.CodigoCredito, _creditoSeleccionado.ClienteId);
                    FormatearGrillaRefinanciacion(dgvRefinanciacion);

                    dgvRefinanciacion.Visible = true;
                    lblRefinanciacion.Visible = true;


                    if (_refinanciacionSeleccionada.Estado == Constante.EstadoCredito.Pagado)
                    {
                        lblDeuda.Text = "CREDITO REFINANCIADO " + _creditoSeleccionado.CodigoCredito + " PAGADO";
                        lblDeuda.ForeColor = Color.Lime;
                    }
                    else
                    {
                        lblDeuda.Text = "CREIDTO REFINANCIADO " + _creditoSeleccionado.CodigoCredito + " CON DEUDA";
                        lblDeuda.Text.ToUpper();
                        lblDeuda.ForeColor = Color.Red;
                    }

                }
                else
                {
                    _refinanciacionSeleccionada = null;

                    dgvRefinanciacion.Visible = false;
                    lblRefinanciacion.Visible = false;
                    lblReciboRefinanciacion.Visible = false;
                    dgvGrillaRecibosRefinanciacion.Visible = false;
                    txtBusquedaRecibosRefinanciados.Visible = false;
                    lblBusquedaRecibosRefinanciados.Visible = false;
                    iconRecibosRefinanciados.Visible = false;

                }

            }
            else
            {
                _refinanciacionSeleccionada = null;

                dgvRefinanciacion.Visible = false;
                lblRefinanciacion.Visible = false;
                lblReciboRefinanciacion.Visible = false;
                dgvGrillaRecibosRefinanciacion.Visible = false;
                txtBusquedaRecibosRefinanciados.Visible = false;
                lblBusquedaRecibosRefinanciados.Visible = false;
                iconRecibosRefinanciados.Visible = false;

            }

        }

        private void ActualizarDatosRecibosRefinanciado(string cadenaBuscar)
        {
            if (_refinanciacionSeleccionada != null)
            {
                dgvGrillaRecibosRefinanciacion.DataSource = _reciboServicio.ObtenerPorCredito(_refinanciacionSeleccionada.Id, cadenaBuscar);
                FormatearGrillaRecibos(dgvGrillaRecibosRefinanciacion);

                dgvGrillaRecibosRefinanciacion.Visible = true;
                lblReciboRefinanciacion.Visible = true;
                txtBusquedaRecibosRefinanciados.Visible = true;
                lblBusquedaRecibosRefinanciados.Visible = true;
                iconRecibosRefinanciados.Visible = true;

            }

            else
            {
               
                lblReciboRefinanciacion.Visible = false;
                dgvGrillaRecibosRefinanciacion.Visible = false;
                txtBusquedaRecibosRefinanciados.Visible = false;
                lblBusquedaRecibosRefinanciados.Visible = false;
                iconRecibosRefinanciados.Visible = false;
            }
        }
        
        private void FormatearGrillaRecibos(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Numero"].Visible = false;
            dgvGrilla.Columns["CLienteId"].Visible = false;
            dgvGrilla.Columns["CreditoId"].Visible = false;
            dgvGrilla.Columns["CuotasPendiente"].Visible = false;
            dgvGrilla.Columns["UltimoPago"].Visible = false;
            dgvGrilla.Columns["Saldo"].Visible = false;
            dgvGrilla.Columns["ApyNomCliente"].Visible = false;
            dgvGrilla.Columns["Interes"].Visible = false;
            dgvGrilla.Columns["Pagado"].Visible = false;
            dgvGrilla.Columns["MontoCredito"].Visible = false;
            dgvGrilla.Columns["MontoCuota"].Visible = false;
            dgvGrilla.Columns["CodigoCredito"].Visible = false;

            dgvGrilla.Columns["NumeroCuota"].Visible = true;
            dgvGrilla.Columns["NumeroCuota"].Width = 100;
            dgvGrilla.Columns["NumeroCuota"].HeaderText = @"Numero Cuota";
            dgvGrilla.Columns["NumeroCuota"].DisplayIndex = 0;

            dgvGrilla.Columns["Pago"].Visible = true;
            dgvGrilla.Columns["Pago"].Width = 100;
            dgvGrilla.Columns["Pago"].HeaderText = @"Pago";
            dgvGrilla.Columns["Pago"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["Pago"].DisplayIndex = 1;

            dgvGrilla.Columns["FechaPago"].Visible = true;
            dgvGrilla.Columns["FechaPago"].Width = 100;
            dgvGrilla.Columns["FechaPago"].HeaderText = @"Fecha Pago";
            dgvGrilla.Columns["FechaPago"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaPago"].DisplayIndex = 2;

            dgvGrilla.Columns["Atraso"].Visible = true;
            dgvGrilla.Columns["Atraso"].Width = 100;
            dgvGrilla.Columns["Atraso"].HeaderText = @"Atraso";
            dgvGrilla.Columns["Atraso"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["Atraso"].DisplayIndex = 3;

            dgvGrilla.Columns["Estado"].Visible = true;
            dgvGrilla.Columns["Estado"].Width = 100;
            dgvGrilla.Columns["Estado"].HeaderText = @"Estado";
            dgvGrilla.Columns["Estado"].DefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            dgvGrilla.Columns["Estado"].DisplayIndex = 4;
        }
        
        private void dgvGrillaCreditos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrillaCreditos.RowCount > 0)
            {
                _creditoSeleccionado = (CreditoDto)dgvGrillaCreditos.Rows[e.RowIndex].DataBoundItem;

                if (_creditoSeleccionado.Estado == Constante.EstadoCredito.Pagado)
                {
                    lblDeuda.Text = "CREDITO " + _creditoSeleccionado.CodigoCredito + " PAGADO";
                    lblDeuda.ForeColor = Color.Lime;
                }
                else
                {
                    lblDeuda.Text = "CREIDTO " + _creditoSeleccionado.CodigoCredito + " CON DEUDA";
                    lblDeuda.Text.ToUpper();
                    lblDeuda.ForeColor = Color.Red;

                }
            }
            
        }

        private void txtBuscarCredito_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatosCreditos(txtBuscarCredito.Text.Trim());

            if (_creditoSeleccionado == null)
            {
                ActualizarDatosRecibos(string.Empty, null);
                FormatearGrillaRecibos(dgvGrillaRecibos);
                ActualizarDatosCreditoRefinanciado();
            }
        }

        private void _10_FormularioEstadoCuentaClientes_Load(object sender, EventArgs e)
        {
            lblCliente.Text = _cliente.ApyNom + " / " + _cliente.NumeroCliente;
        }

        private void dgvGrillaCreditos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_creditoSeleccionado != null)
            {
                ActualizarDatosRecibos(string.Empty, _creditoSeleccionado.Id);
            }
            else
            {
                Mensaje.Mostrar("Seleccione un elemento de la lista para poder continuar.", Mensaje.Tipo.Informacion);
            }
        }

        private void txtBuscarRecibos_TextChanged(object sender, EventArgs e)
        {
            if (_creditoSeleccionado != null)
            {
                ActualizarDatosRecibos(txtBuscarRecibos.Text.Trim(), _creditoSeleccionado.Id);
            }
            else
            {
                ActualizarDatosRecibos(txtBuscarRecibos.Text.Trim(), null);
            }
           
        }

        private void dgvGrillaRecibos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGrillaRecibos.Rows)
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

        private void dgvRefinanciacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRefinanciacion.RowCount > 0)
            {
                _refinanciacionSeleccionada = (CreditoDto)dgvRefinanciacion.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _refinanciacionSeleccionada = null;
            }

            ActualizarDatosRecibosRefinanciado(string.Empty);


        }

        private void dgvRefinanciacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvRefinanciacion.Rows)
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

        private void dgvGrillaRecibosRefinanciacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGrillaRecibosRefinanciacion.Rows)
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

        private void txtBusquedaRecibosRefinanciados_TextChanged(object sender, EventArgs e)
        {
            if (_refinanciacionSeleccionada != null)
            {
                ActualizarDatosRecibosRefinanciado(txtBusquedaRecibosRefinanciados.Text.Trim());
            }
        }

        private void dgvGrillaCreditos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGrillaCreditos.Rows)
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
