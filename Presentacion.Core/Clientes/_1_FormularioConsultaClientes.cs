using FontAwesome.Sharp;
using Presentacion.Base;
using Presentacion.Base.Varios;
using Servicio.Core.Cliente;
using Servicio.Core.Cliente.Dto;
using Servicio.Core.Credito;
using Servicio.Core.Credito.Dto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Core.Clientes
{
    public partial class _1_FormularioConsultaClientes : FormularioEnPanelBase
    {
        private readonly IClienteServicio _clienteServicio;

        private readonly ICreditoServicio _creditoServicio;

        private ClienteDto _clienteSeleccionado;

        private List<CreditoDto> listaCreditos;

        public _1_FormularioConsultaClientes()
            : this(new ClienteServicio())
        {
            Titulo = @"Lista de Clientes"; //TItulo
        }

        public _1_FormularioConsultaClientes(IClienteServicio clienteServicio)
        {
            InitializeComponent();

            _clienteServicio = new ClienteServicio();
            _creditoServicio = new CreditoServicio();

            btnEstadoCuenta.Visible = true;

            lblTituloRefinanciacion.Visible = false;

            pnlRefinanciacion.Visible = false;

            btnRefinanciar.Visible = true;
            btnRefinanciar.Text = "Cambiar Estado";
            btnRefinanciar.IconChar = IconChar.UserCheck;
            btnRefinanciar.IconSize = 45;

            ActualizarDatos(string.Empty);

        }

        public override void ActualizarDatos(string cadenaBuscar)
        {
            dgvGrilla.DataSource = _clienteServicio.ObtenerPorFiltro(cadenaBuscar);
            FormatearGrilla(dgvGrilla);
        }

        public override void FormatearGrilla(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Nombre"].Visible = false;
            dgvGrilla.Columns["Apellido"].Visible = false;
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

            dgvGrilla.Columns["DireccionParticular"].Visible = true;
            dgvGrilla.Columns["DireccionParticular"].Width = 100;
            dgvGrilla.Columns["DireccionParticular"].HeaderText = @"Dirección Particular";
            dgvGrilla.Columns["DireccionParticular"].DisplayIndex = 3;

            dgvGrilla.Columns["DireccionComercial"].Visible = true;
            dgvGrilla.Columns["DireccionComercial"].Width = 100;
            dgvGrilla.Columns["DireccionComercial"].HeaderText = @"Dirección Comercial";
            dgvGrilla.Columns["DireccionComercial"].DisplayIndex = 4;

            dgvGrilla.Columns["Celular"].Visible = true;
            dgvGrilla.Columns["Celular"].Width = 100;
            dgvGrilla.Columns["Celular"].HeaderText = @"Celular";
            dgvGrilla.Columns["Celular"].DisplayIndex = 5;

            dgvGrilla.Columns["Telefono"].Visible = true;
            dgvGrilla.Columns["Telefono"].Width = 100;
            dgvGrilla.Columns["Telefono"].HeaderText = @"Telefono";
            dgvGrilla.Columns["Telefono"].DisplayIndex = 6;

            dgvGrilla.Columns["EstadoStr"].Visible = true;
            dgvGrilla.Columns["EstadoStr"].Width = 100;
            dgvGrilla.Columns["EstadoStr"].HeaderText = @"Estado";
            dgvGrilla.Columns["EstadoStr"].DefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            dgvGrilla.Columns["EstadoStr"].DisplayIndex = 7;
        }

        public override bool EjecutarComandoNuevo()

        {
            var cantidadClientes = _clienteServicio.VerificarCantidadClientes();

            if (cantidadClientes == 200)
            {
                Mensaje.Mostrar("HA LLEGADO AL LIMITE DE 200 CLIENTES, NO SE PUEDE AGREGAR MAS.", Mensaje.Tipo.Error);

                return false;
            }

            var formularioNuevo = new _2_FormularioClientesABM(Constante.TipoOperacion.Nuevo, null)
            {
                Text = "Crear Cliente"
            };

            formularioNuevo.ShowDialog();

            return formularioNuevo.RealizoAlgunaOperacion;

        }

        public override bool EjecutarComandoModificar()
        {

            listaCreditos = _creditoServicio.ObtenerPorCliente(_clienteSeleccionado.Id, string.Empty).ToList();


            foreach (var item in listaCreditos)
            {
                if (item.ClienteId == _clienteSeleccionado.Id)
                {
                    if( Mensaje.Mostrar("Este Cliente tiene Creditos Asociados a su Cuenta, Desea Modificarlo?", Mensaje.Tipo.Pregunta) ==
                        DialogResult.Yes)
                    {
                        var _formularioModificar = new _2_FormularioClientesABM(Constante.TipoOperacion.Modificar, EntidadId)
                        {
                            Text = "Modificar Cliente"
                        };

                        _formularioModificar.ShowDialog();

                        return _formularioModificar.RealizoAlgunaOperacion;
                    }    
                    else
                    {
                        return false;
                    }

                    
                }
            }

            var formularioModificar = new _2_FormularioClientesABM(Constante.TipoOperacion.Modificar, EntidadId)
            {
                Text = "Modificar Cliente"
            };

            formularioModificar.ShowDialog();

            return formularioModificar.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar()
        {
            listaCreditos = _creditoServicio.ObtenerPorCliente(_clienteSeleccionado.Id, string.Empty).ToList();


            foreach (var item in listaCreditos)
            {
                if (item.ClienteId == _clienteSeleccionado.Id)
                {
                    Mensaje.Mostrar("No se puede Eliminar el Cliente porque tiene Creditos Asociados a su Cuenta.", Mensaje.Tipo.Advertencia);

                    return false;
                }
            }

            var formularioEliminar = new _2_FormularioClientesABM(Constante.TipoOperacion.Eliminar, EntidadId)
            {
                Text = "Eliminar Cliente"
            };

            formularioEliminar.ShowDialog();

            return formularioEliminar.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoExtra()
        {
            var formulario = new _10_FormularioEstadoCuentaClientes(EntidadId.Value);
            formulario.ShowDialog();

            ActualizarDatos(string.Empty);

            return true;
        }

        public override bool EjecutarComandoRefinanciar()
        {
            if (Mensaje.Mostrar("El cliente se encuentra" + " " + _clienteSeleccionado.EstadoStr.ToUpper() + ". \n" + "Desea cambiar su Estado ?", Mensaje.Tipo.Pregunta) ==
                                 DialogResult.Yes)

            {
                _clienteSeleccionado.Estado = _clienteSeleccionado.Estado == true ? false : true;

                _clienteServicio.Modificar(_clienteSeleccionado);

                return true;
            }

            else
            {
                return false;
            }
        }

        public override void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvGrilla_RowEnter(sender, e);

            _clienteSeleccionado = (ClienteDto)elementoSeleccionado;

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
