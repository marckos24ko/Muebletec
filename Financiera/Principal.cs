using FontAwesome.Sharp;
using Presentacion.Base;
using Presentacion.Core.Clientes;
using Presentacion.Core.Credito;
using Presentacion.Core.Recibos;
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Financiera
{
    public partial class Principal : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //public Form form;
        public FormWindowState _estadoVentana;
        private string formularioAbierto = string.Empty;

        public Principal()
        {
            InitializeComponent();

            CultureInfo myCI = new CultureInfo("es-AR");
            Calendar myCal = myCI.Calendar;

            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            var fecha = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);

            leftBorderBtn = new Panel(); // inicializamos el panel
            leftBorderBtn.Size = new Size(7, 40); // definimos en ancho y largo
            panelMenu.Controls.Add(leftBorderBtn); // agregamos el boton al panel
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // se usa para que al maximizar no sobrepase la pantalla

            formularioAbierto = "Inicio";
            this.Reset();
        }

        private void AbrirFormEnPanel(object formulario)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form form = formulario as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.WindowState = this.WindowState;

            form.Show();
        }

        private void ActivarBoton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = ListaColores.CambiarBrilloColor(Color.FromArgb(51, 51, 76), 0.1);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                lblTituloFormSeleccionado.Text = currentBtn.Text.ToUpper();

            }

        }

        private void DesactivarBoton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void Reset()
        {
            formularioAbierto = "Inicio";
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            lblTituloFormSeleccionado.Text = "INICIO";
            AbrirFormEnPanel(new Inicio());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            formularioAbierto = "Cliente";
            ActivarBoton(sender);
            leftBorderBtn.Anchor = AnchorStyles.Top;
            AbrirFormEnPanel(new _1_FormularioConsultaClientes());
           
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            formularioAbierto = "Credito";
            ActivarBoton(sender);
            leftBorderBtn.Anchor = AnchorStyles.Top;
            AbrirFormEnPanel(new _3_FormularioConsultaCredito());
           
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            formularioAbierto = "Recibo";
            ActivarBoton(sender);
            leftBorderBtn.Anchor = AnchorStyles.Top;
            AbrirFormEnPanel(new _11_FormularioConsultaRecibos());
        }

        // codigo de palabras reservadas para poder mover la ventana con barra de titulo generada por nosotros mismos

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            // implementacion metodos en envento MouseDown para mover barra de titulos
            if (this.WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            _estadoVentana = this.WindowState;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            _estadoVentana = this.WindowState;
            
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //_estadoVentana = this.WindowState;
            iconMaximizar.Visible = true;
            iconRestaurar.Visible = false;

            switch (formularioAbierto)
            {
                case "Cliente":

                    AbrirFormEnPanel(new _1_FormularioConsultaClientes());

                    break;

                case "Recibo":

                    AbrirFormEnPanel(new _11_FormularioConsultaRecibos());

                    break;

                case "Credito":

                    AbrirFormEnPanel(new _3_FormularioConsultaCredito());

                    break;

                case "Inicio":

                    Reset();

                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
