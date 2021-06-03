using Presentacion.Base.Varios;
using System;
using System.Windows.Forms;

namespace Presentacion.Base
{
    public partial class FormularioEnPanelBase : FormularioBase
    {
        private bool puedeEjecutarComando;
        public object elementoSeleccionado;
        public object elementoSeleccionado2;

        public bool ModoConsulta
        {
            set
            {
                this.btnNuevo.Visible = !value;
                this.btnEliminar.Visible = !value;
                this.btnModificar.Visible = !value;
            }
        }

        public string Titulo
        {
            set { lblTitulo.Text = value; }
        }

        public FormularioEnPanelBase()
        {
            InitializeComponent();

            // Color cuando recibe o pierde el foco
            this.txtBuscar.Leave += new EventHandler(this.txt_Leave);
            this.txtBuscar.Enter += new EventHandler(this.txt_Enter);

            this.puedeEjecutarComando = false;

        }

        private void FormularioEnPanelBase_Load(object sender, EventArgs e)
        {
            VerificarFechaCancelacionCredito();
            ActualizarDatos(string.Empty);
        }

        public virtual void btnNuevo_Click(object sender, EventArgs e)
        {
            if (EjecutarComandoNuevo())
            {
                ActualizarDatos(string.Empty);
            }
        }

        public virtual void btnModificar_Click(object sender, EventArgs e)
        {
            if (puedeEjecutarComando)
            {
                if (EjecutarComandoModificar())
                {
                    ActualizarDatos(string.Empty);
                }
            }
            else
            {
                Mensaje.Mostrar(Constante.Mensaje.NoHayDatosCargados, Mensaje.Tipo.Informacion);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (puedeEjecutarComando)
            {
                if (EjecutarComandoEliminar())
                {
                    ActualizarDatos(string.Empty);
                }
            }
            else
            {
                Mensaje.Mostrar(Constante.Mensaje.NoHayDatosCargados, Mensaje.Tipo.Informacion);
            }
        }

        public virtual void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.EntidadId = this.dgvGrilla.RowCount > 0 ? Convert.ToInt64(this.dgvGrilla["Id", e.RowIndex].Value) : (long?)null;

            elementoSeleccionado = (object)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
        }

        public virtual void ActualizarDatos(string cadenaBuscar)
        {

        }

        public virtual bool EjecutarComandoNuevo()
        {
            return true;
        }

        public virtual bool EjecutarComandoModificar()
        {
            return true;
        }

        public virtual bool EjecutarComandoEliminar()
        {
            return true;
        }

        public virtual bool EjecutarComandoExtra()
        {
            return true;
        }

        public virtual bool EjecutarComandoRefinanciar()
        {
            return true;
        }

        public virtual bool EjecutarComandoReciboRefinanciar()
        {
            return true;
        }
        
        private void dgvGrilla_DataSourceChanged(object sender, EventArgs e)
        {
            this.puedeEjecutarComando = this.dgvGrilla.RowCount > 0;
        }

        public virtual void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(this.txtBuscar.Text.Trim());
        }

        public virtual void VerificarFechaCancelacionCredito()
        {
            
        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            if (puedeEjecutarComando)
            {
                EjecutarComandoExtra();

                ActualizarDatos(string.Empty);
            }

            else
            {
                Mensaje.Mostrar(Constante.Mensaje.NoHayDatosCargados, Mensaje.Tipo.Informacion);
            }
        }

        private void btnRefinanciar_Click(object sender, EventArgs e)
        {
            if (puedeEjecutarComando)
            {
                if (EjecutarComandoRefinanciar())
                {
                    ActualizarDatos(string.Empty);
                }
                
            }
            else
            {
                Mensaje.Mostrar(Constante.Mensaje.NoHayDatosCargados, Mensaje.Tipo.Informacion);
            }
        }

        private void btnRecibosRefinanciar_Click(object sender, EventArgs e)
        {
            if (puedeEjecutarComando)
            {
                if (EjecutarComandoReciboRefinanciar())
                {
                    ActualizarDatos(string.Empty);
                }

                else
                {
                    Mensaje.Mostrar(Constante.Mensaje.NoHayDatosCargados, Mensaje.Tipo.Informacion);
                    
                }
            }
        }

        public virtual void dgvGrillaRefinanciacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            elementoSeleccionado2 = (object)dgvGrillaRefinanciacion.Rows[e.RowIndex].DataBoundItem;
        }

        public virtual void dgvGrilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        public virtual void dgvGrillaRefinanciacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
