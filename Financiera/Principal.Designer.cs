namespace Financiera
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloFormSeleccionado = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.btnRecibo = new FontAwesome.Sharp.IconButton();
            this.btnCredito = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnRecibo);
            this.panelMenu.Controls.Add(this.btnCredito);
            this.panelMenu.Controls.Add(this.btnCliente);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 488);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 55);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUEBELTEC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBarraTitulo.Controls.Add(this.lblTituloFormSeleccionado);
            this.pnlBarraTitulo.Controls.Add(this.iconRestaurar);
            this.pnlBarraTitulo.Controls.Add(this.iconMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.iconMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.iconCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1087, 55);
            this.pnlBarraTitulo.TabIndex = 2;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblTituloFormSeleccionado
            // 
            this.lblTituloFormSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloFormSeleccionado.AutoSize = true;
            this.lblTituloFormSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblTituloFormSeleccionado.Location = new System.Drawing.Point(443, 15);
            this.lblTituloFormSeleccionado.Name = "lblTituloFormSeleccionado";
            this.lblTituloFormSeleccionado.Size = new System.Drawing.Size(63, 26);
            this.lblTituloFormSeleccionado.TabIndex = 7;
            this.lblTituloFormSeleccionado.Text = "Inicio";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 55);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1087, 433);
            this.panelContenedor.TabIndex = 1;
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestaurar.Image = global::Financiera.Properties.Resources.Restaurar;
            this.iconRestaurar.Location = new System.Drawing.Point(1031, 3);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(25, 25);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaurar.TabIndex = 5;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            this.iconRestaurar.Click += new System.EventHandler(this.iconRestaurar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Financiera.Properties.Resources.Minimizar;
            this.iconMinimizar.Location = new System.Drawing.Point(1000, 3);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 4;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.Image = global::Financiera.Properties.Resources.Maximizar;
            this.iconMaximizar.Location = new System.Drawing.Point(1031, 3);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximizar.TabIndex = 3;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = global::Financiera.Properties.Resources.Cerrar;
            this.iconCerrar.Location = new System.Drawing.Point(1062, 3);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // btnRecibo
            // 
            this.btnRecibo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecibo.FlatAppearance.BorderSize = 0;
            this.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibo.ForeColor = System.Drawing.Color.White;
            this.btnRecibo.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnRecibo.IconColor = System.Drawing.Color.White;
            this.btnRecibo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibo.Location = new System.Drawing.Point(0, 175);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRecibo.Size = new System.Drawing.Size(220, 60);
            this.btnRecibo.TabIndex = 3;
            this.btnRecibo.Text = "Recibo";
            this.btnRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecibo.UseVisualStyleBackColor = true;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCredito.FlatAppearance.BorderSize = 0;
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.ForeColor = System.Drawing.Color.White;
            this.btnCredito.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnCredito.IconColor = System.Drawing.Color.White;
            this.btnCredito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.Location = new System.Drawing.Point(0, 115);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCredito.Size = new System.Drawing.Size(220, 60);
            this.btnCredito.TabIndex = 2;
            this.btnCredito.Text = "Credito";
            this.btnCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnCliente.IconColor = System.Drawing.Color.White;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 55);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCliente.Size = new System.Drawing.Size(220, 60);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 488);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCliente;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnRecibo;
        private FontAwesome.Sharp.IconButton btnCredito;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblTituloFormSeleccionado;
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
    }
}

