using Presentacion.Base.Varios;
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
    public partial class _6_FormularioCreditoTipoTransaccion : Form
    {
        public bool realizoAlgunaOperacion;
        public _6_FormularioCreditoTipoTransaccion()
        {
            InitializeComponent();

            realizoAlgunaOperacion = false;
        }

        private void btnCreditoEfectivo_Click(object sender, EventArgs e)
        {
            var formularioNuevo = new _4_FormularioCreditoABM(Constante.TipoOperacion.Nuevo, Constante.TipoCredito.Efecitvo, null);
            realizoAlgunaOperacion = true;
            formularioNuevo.ShowDialog();

            if (realizoAlgunaOperacion)
            {
                Close();
            }
           
        }

        private void btnCreditoMuebles_Click(object sender, EventArgs e)
        {
            var formularioNuevo = new _4_FormularioCreditoABM(Constante.TipoOperacion.Nuevo, Constante.TipoCredito.Mueble, null);
            realizoAlgunaOperacion = true;
            formularioNuevo.ShowDialog();

            if (realizoAlgunaOperacion)
            {
                Close();
            }
        }
    }
}
