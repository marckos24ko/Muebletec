using Presentacion.Base;
using Presentacion.Base.Varios;
using Servicio.Core.Cliente;
using Servicio.Core.Cliente.Dto;
using System;

namespace Presentacion.Core.Clientes
{
    public partial class _2_FormularioClientesABM : FormularioABM
    {

        private readonly IClienteServicio _clienteServicio;
        private long? _clienteId;


        public _2_FormularioClientesABM(string _tipoOperacion, long? _entidadId)
            : base(_tipoOperacion, _entidadId)

        {
            InitializeComponent();

            _clienteServicio = new ClienteServicio();

            Init(_tipoOperacion, entidadId);


            if (_tipoOperacion == Constante.TipoOperacion.Nuevo)
            {
                _clienteId = null;
                txtCodigo.Text = _clienteServicio.ObtenerSiguienteCodigo().ToString();
            }

            if (_tipoOperacion == Constante.TipoOperacion.Modificar)
            {
                _clienteId = entidadId;
            }

            if (_tipoOperacion == Constante.TipoOperacion.Eliminar)
            {
                _clienteId = entidadId;

            }

            txtApellido.KeyPress += Validacion.NoNumeros;
            txtApellido.KeyPress += Validacion.NoSimbolos;
            txtApellido.KeyPress += Validacion.NoInyeccion;

            txtNombre.KeyPress += Validacion.NoNumeros;
            txtNombre.KeyPress += Validacion.NoSimbolos;
            txtNombre.KeyPress += Validacion.NoInyeccion;

            txtDni.KeyPress += Validacion.NoLetras;
            txtDni.KeyPress += Validacion.NoSimbolos;
            txtDni.KeyPress += Validacion.NoInyeccion;

            txtDireccionParticular.KeyPress += Validacion.NoInyeccion;

            txtDireccionComercial.KeyPress += Validacion.NoInyeccion;

            txtTelefono.KeyPress += Validacion.NoLetras;
            txtTelefono.KeyPress += Validacion.NoSimbolos;
            txtTelefono.KeyPress += Validacion.NoInyeccion;

            txtCelular.KeyPress += Validacion.NoLetras;
            txtCelular.KeyPress += Validacion.NoSimbolos;
            txtCelular.KeyPress += Validacion.NoInyeccion;


            txtApellido.Enter += txt_Enter;
            txtApellido.Leave += txt_Leave;

            txtNombre.Enter += txt_Enter;
            txtNombre.Leave += txt_Leave;

            txtDni.Enter += txt_Enter;
            txtDni.Leave += txt_Leave;

            txtDireccionComercial.Enter += txt_Enter;
            txtDireccionComercial.Leave += txt_Leave;

            txtDireccionParticular.Enter += txt_Enter;
            txtDireccionParticular.Leave += txt_Leave;

            txtTelefono.Enter += txt_Enter;
            txtTelefono.Leave += txt_Leave;

            txtCelular.Enter += txt_Enter;
            txtCelular.Leave += txt_Leave;
        }

        public override void CargarDatos(long? _entidadId)
        {
            var cliente = _clienteServicio.obtenerPorId(_entidadId.Value);

            txtCodigo.Text = cliente.NumeroCliente.ToString();
            txtApellido.Text = cliente.Apellido;
            txtNombre.Text = cliente.Nombre;
            txtDni.Text = cliente.Dni.ToString();
            txtDireccionComercial.Text = cliente.DireccionComercial;
            txtDireccionParticular.Text = cliente.DireccionParticular;
            txtTelefono.Text = cliente.Telefono;
            txtCelular.Text = cliente.Celular;

        }

        public override void LimpiarDatos(object obj)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtDireccionComercial.Clear();
            txtDireccionParticular.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
        }

        public override bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text.Trim())) return false;
            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim())) return false;
            if (string.IsNullOrWhiteSpace(txtDni.Text.Trim())) return false;
            if (string.IsNullOrWhiteSpace(txtDireccionComercial.Text.Trim())) return false;
            if (string.IsNullOrWhiteSpace(txtDireccionParticular.Text.Trim())) return false;
            if (string.IsNullOrWhiteSpace(txtTelefono.Text.Trim())) return false;
            if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim())) return false;

            return true;
        }

        public override bool EjecutarComandoNuevo()
        {
            try
            {
                _clienteServicio.Insertar(new ClienteDto
                {
                    NumeroCliente = int.Parse(txtCodigo.Text),
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text,
                    Dni = int.Parse(txtDni.Text),
                    DireccionComercial = txtDireccionComercial.Text,
                    DireccionParticular = txtDireccionParticular.Text,
                    Telefono = txtTelefono.Text,
                    Celular = txtCelular.Text

                });

                Mensaje.Mostrar("Los datos se grabaron Correctamente", Mensaje.Tipo.Informacion);

                return true;
            }
            catch (Exception ex)
            {

                Mensaje.Mostrar(ex.Message, Mensaje.Tipo.Stop);

                return false;
            }
        }

        public override bool EjecutarComandoModificar()
        {
            try
            {
                _clienteServicio.Modificar(new ClienteDto
                {
                    Id = entidadId.Value,
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text,
                    Dni = int.Parse(txtDni.Text),
                    DireccionComercial = txtDireccionComercial.Text,
                    DireccionParticular = txtDireccionParticular.Text,
                    Telefono = txtTelefono.Text,
                    Celular = txtCelular.Text
                });

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
                _clienteServicio.Eliminar(entidadId.Value);

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
            return _clienteServicio.VerificarSiExiste(entidadId, txtApellido.Text, txtNombre.Text, int.Parse(txtDni.Text));
        }
    }
}
