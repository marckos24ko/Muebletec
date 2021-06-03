using System;
using System.Windows.Forms;

namespace Presentacion.Base
{
    public partial class FormularioLookUp : FormularioBase
    {
        private bool puedeEjecutarComando;
        public object Entidad { get; set; }
        public object elementoSeleccionado;

        public FormularioLookUp()
                
        {
            InitializeComponent();

            this.puedeEjecutarComando = false;

            // Color cuando recibe o pierde el foco
            this.txtBuscar.Leave += new EventHandler(this.txt_Leave);
            this.txtBuscar.Enter += new EventHandler(this.txt_Enter);
            
        }

        public virtual void ActualizarDatos(string cadenaBuscar)
        {

        }

        private void dgvGrilla_DataSourceChanged(object sender, EventArgs e)
        {
            this.puedeEjecutarComando = this.dgvGrilla.RowCount > 0;
        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Entidad = this.dgvGrilla.RowCount > 0 ? dgvGrilla.Rows[e.RowIndex].DataBoundItem : null;

            elementoSeleccionado = (object)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
        }

        private void dgvGrilla_DoubleClick(object sender, EventArgs e)
        {
            if (!puedeEjecutarComando) return;
            this.Close();
        }

        private void FormularioLookUp_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }
        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(this.txtBuscar.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Entidad = null;
            this.Close();
        }

        public virtual void dgvGrilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
