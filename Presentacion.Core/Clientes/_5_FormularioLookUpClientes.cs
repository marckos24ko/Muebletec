using Presentacion.Base;
using Servicio.Core.Cliente;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System;
using System.Drawing;

namespace Presentacion.Core.Clientes
{
    public partial class _5_FormularioLookUpClientes : FormularioLookUp
    {
        private readonly IClienteServicio _clienteServicio;

        public _5_FormularioLookUpClientes()
        {
            InitializeComponent();

            _clienteServicio = new ClienteServicio();

        }

        public _5_FormularioLookUpClientes(long? id) 
               : this()
        {

            IconTitulo.IconChar = IconChar.UserAlt;

            lblTitulo.Text = @"Lista de Clientes Activos";
        }

        public override void ActualizarDatos(string cadenaBuscar)
        {
            dgvGrilla.DataSource = _clienteServicio.ObtenerClientesActivos(cadenaBuscar);
            FormatearGrilla(dgvGrilla);
        }

        public override void FormatearGrilla(DataGridView dgvGrilla)
        {

            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Nombre"].Visible = false;
            dgvGrilla.Columns["Apellido"].Visible = false;
            dgvGrilla.Columns["DireccionComercial"].Visible = false;
            dgvGrilla.Columns["DireccionParticular"].Visible = false;
            dgvGrilla.Columns["Telefono"].Visible = false;
            dgvGrilla.Columns["Celular"].Visible = false;
            dgvGrilla.Columns["Estado"].Visible = false;

            dgvGrilla.Columns["NumeroCliente"].Visible = true;
            dgvGrilla.Columns["NumeroCliente"].Width = 50;
            dgvGrilla.Columns["NumeroCliente"].HeaderText = @"Código";
            dgvGrilla.Columns["NumeroCliente"].DisplayIndex = 0;

            dgvGrilla.Columns["ApyNom"].Visible = true;
            dgvGrilla.Columns["ApyNom"].Width = 100;
            dgvGrilla.Columns["ApyNom"].HeaderText = @"Apellido y Nombre";
            dgvGrilla.Columns["ApyNom"].DisplayIndex = 1;

            dgvGrilla.Columns["Dni"].Visible = true;
            dgvGrilla.Columns["Dni"].Width = 100;
            dgvGrilla.Columns["Dni"].HeaderText = @"DNI";
            dgvGrilla.Columns["Dni"].DisplayIndex = 2;

            dgvGrilla.Columns["EstadoStr"].Visible = true;
            dgvGrilla.Columns["EstadoStr"].Width = 100;
            dgvGrilla.Columns["EstadoStr"].HeaderText = @"Estado";
            dgvGrilla.Columns["EstadoStr"].DefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            dgvGrilla.Columns["EstadoStr"].DisplayIndex = 3;

        }

        public override void dgvGrilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGrilla.Rows)
            {
                if (Convert.ToString(row.Cells["EstadoStr"].Value) != "Activo")
                {

                    row.Cells["EstadoStr"].Style.ForeColor = Color.Red;
                }
                else
                {
                    row.Cells["EstadoStr"].Style.ForeColor = Color.Green;
                }
            }
        }

    }
}
