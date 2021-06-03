namespace Presentacion.Core.Clientes
{
    partial class _10_FormularioEstadoCuentaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBarraBotones = new System.Windows.Forms.Panel();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.IconTitulo = new FontAwesome.Sharp.IconButton();
            this.dgvGrillaCreditos = new System.Windows.Forms.DataGridView();
            this.ImgBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscarCredito = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblRecibos = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscarRecibos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGrillaRecibos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvRefinanciacion = new System.Windows.Forms.DataGridView();
            this.lblRefinanciacion = new System.Windows.Forms.Label();
            this.lblReciboRefinanciacion = new System.Windows.Forms.Label();
            this.dgvGrillaRecibosRefinanciacion = new System.Windows.Forms.DataGridView();
            this.iconRecibosRefinanciados = new FontAwesome.Sharp.IconPictureBox();
            this.txtBusquedaRecibosRefinanciados = new System.Windows.Forms.TextBox();
            this.lblBusquedaRecibosRefinanciados = new System.Windows.Forms.Label();
            this.pnlBarraBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefinanciacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaRecibosRefinanciacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecibosRefinanciados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraBotones
            // 
            this.pnlBarraBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBarraBotones.Controls.Add(this.lblDeuda);
            this.pnlBarraBotones.Controls.Add(this.lblCliente);
            this.pnlBarraBotones.Controls.Add(this.lblTitulo);
            this.pnlBarraBotones.Controls.Add(this.IconTitulo);
            this.pnlBarraBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraBotones.Name = "pnlBarraBotones";
            this.pnlBarraBotones.Size = new System.Drawing.Size(1074, 52);
            this.pnlBarraBotones.TabIndex = 3;
            // 
            // lblDeuda
            // 
            this.lblDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeuda.Location = new System.Drawing.Point(642, 9);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(417, 38);
            this.lblDeuda.TabIndex = 13;
            this.lblDeuda.Text = "Deuda";
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCliente.Location = new System.Drawing.Point(266, 5);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(370, 38);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente/NumeroCliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(76, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 38);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Estado de Cuenta:";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IconTitulo
            // 
            this.IconTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconTitulo.FlatAppearance.BorderSize = 0;
            this.IconTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.IconTitulo.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.IconTitulo.IconColor = System.Drawing.Color.White;
            this.IconTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconTitulo.IconSize = 50;
            this.IconTitulo.Location = new System.Drawing.Point(0, 0);
            this.IconTitulo.Name = "IconTitulo";
            this.IconTitulo.Size = new System.Drawing.Size(70, 52);
            this.IconTitulo.TabIndex = 4;
            this.IconTitulo.UseVisualStyleBackColor = true;
            // 
            // dgvGrillaCreditos
            // 
            this.dgvGrillaCreditos.AllowUserToAddRows = false;
            this.dgvGrillaCreditos.AllowUserToDeleteRows = false;
            this.dgvGrillaCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrillaCreditos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrillaCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaCreditos.Location = new System.Drawing.Point(11, 98);
            this.dgvGrillaCreditos.Name = "dgvGrillaCreditos";
            this.dgvGrillaCreditos.ReadOnly = true;
            this.dgvGrillaCreditos.Size = new System.Drawing.Size(558, 255);
            this.dgvGrillaCreditos.TabIndex = 12;
            this.dgvGrillaCreditos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaCreditos_CellEnter);
            this.dgvGrillaCreditos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrillaCreditos_CellFormatting);
            this.dgvGrillaCreditos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaCreditos_RowEnter);
            // 
            // ImgBuscar
            // 
            this.ImgBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ImgBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ImgBuscar.IconColor = System.Drawing.Color.White;
            this.ImgBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImgBuscar.IconSize = 59;
            this.ImgBuscar.Location = new System.Drawing.Point(11, 359);
            this.ImgBuscar.Name = "ImgBuscar";
            this.ImgBuscar.Size = new System.Drawing.Size(60, 59);
            this.ImgBuscar.TabIndex = 17;
            this.ImgBuscar.TabStop = false;
            // 
            // txtBuscarCredito
            // 
            this.txtBuscarCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCredito.Location = new System.Drawing.Point(77, 389);
            this.txtBuscarCredito.MaxLength = 4;
            this.txtBuscarCredito.Name = "txtBuscarCredito";
            this.txtBuscarCredito.Size = new System.Drawing.Size(492, 22);
            this.txtBuscarCredito.TabIndex = 16;
            this.txtBuscarCredito.TextChanged += new System.EventHandler(this.txtBuscarCredito_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBuscar.Location = new System.Drawing.Point(77, 359);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(492, 27);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Busqueda";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreditos
            // 
            this.lblCreditos.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCreditos.Location = new System.Drawing.Point(12, 57);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(89, 38);
            this.lblCreditos.TabIndex = 13;
            this.lblCreditos.Text = "Creditos";
            this.lblCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecibos
            // 
            this.lblRecibos.BackColor = System.Drawing.Color.Transparent;
            this.lblRecibos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibos.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRecibos.Location = new System.Drawing.Point(617, 57);
            this.lblRecibos.Name = "lblRecibos";
            this.lblRecibos.Size = new System.Drawing.Size(89, 38);
            this.lblRecibos.TabIndex = 19;
            this.lblRecibos.Text = "Recibos";
            this.lblRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 59;
            this.iconPictureBox1.Location = new System.Drawing.Point(616, 258);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 59);
            this.iconPictureBox1.TabIndex = 22;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtBuscarRecibos
            // 
            this.txtBuscarRecibos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRecibos.Location = new System.Drawing.Point(682, 288);
            this.txtBuscarRecibos.MaxLength = 4;
            this.txtBuscarRecibos.Name = "txtBuscarRecibos";
            this.txtBuscarRecibos.Size = new System.Drawing.Size(377, 22);
            this.txtBuscarRecibos.TabIndex = 21;
            this.txtBuscarRecibos.TextChanged += new System.EventHandler(this.txtBuscarRecibos_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(682, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Busqueda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvGrillaRecibos
            // 
            this.dgvGrillaRecibos.AllowUserToAddRows = false;
            this.dgvGrillaRecibos.AllowUserToDeleteRows = false;
            this.dgvGrillaRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrillaRecibos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrillaRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaRecibos.Location = new System.Drawing.Point(616, 98);
            this.dgvGrillaRecibos.Name = "dgvGrillaRecibos";
            this.dgvGrillaRecibos.ReadOnly = true;
            this.dgvGrillaRecibos.Size = new System.Drawing.Size(443, 134);
            this.dgvGrillaRecibos.TabIndex = 18;
            this.dgvGrillaRecibos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrillaRecibos_CellFormatting);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(587, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 497);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // dgvRefinanciacion
            // 
            this.dgvRefinanciacion.AllowUserToAddRows = false;
            this.dgvRefinanciacion.AllowUserToDeleteRows = false;
            this.dgvRefinanciacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRefinanciacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRefinanciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefinanciacion.Location = new System.Drawing.Point(12, 484);
            this.dgvRefinanciacion.Name = "dgvRefinanciacion";
            this.dgvRefinanciacion.ReadOnly = true;
            this.dgvRefinanciacion.Size = new System.Drawing.Size(558, 64);
            this.dgvRefinanciacion.TabIndex = 24;
            this.dgvRefinanciacion.Visible = false;
            this.dgvRefinanciacion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRefinanciacion_CellFormatting);
            this.dgvRefinanciacion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefinanciacion_RowEnter);
            // 
            // lblRefinanciacion
            // 
            this.lblRefinanciacion.BackColor = System.Drawing.Color.Transparent;
            this.lblRefinanciacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefinanciacion.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRefinanciacion.Location = new System.Drawing.Point(12, 457);
            this.lblRefinanciacion.Name = "lblRefinanciacion";
            this.lblRefinanciacion.Size = new System.Drawing.Size(246, 24);
            this.lblRefinanciacion.TabIndex = 25;
            this.lblRefinanciacion.Text = "Refinanciacion";
            this.lblRefinanciacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRefinanciacion.Visible = false;
            // 
            // lblReciboRefinanciacion
            // 
            this.lblReciboRefinanciacion.BackColor = System.Drawing.Color.Transparent;
            this.lblReciboRefinanciacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReciboRefinanciacion.ForeColor = System.Drawing.Color.DarkGray;
            this.lblReciboRefinanciacion.Location = new System.Drawing.Point(617, 332);
            this.lblReciboRefinanciacion.Name = "lblReciboRefinanciacion";
            this.lblReciboRefinanciacion.Size = new System.Drawing.Size(205, 24);
            this.lblReciboRefinanciacion.TabIndex = 27;
            this.lblReciboRefinanciacion.Text = "Recibos Refinanciacion ";
            this.lblReciboRefinanciacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReciboRefinanciacion.Visible = false;
            // 
            // dgvGrillaRecibosRefinanciacion
            // 
            this.dgvGrillaRecibosRefinanciacion.AllowUserToAddRows = false;
            this.dgvGrillaRecibosRefinanciacion.AllowUserToDeleteRows = false;
            this.dgvGrillaRecibosRefinanciacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrillaRecibosRefinanciacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrillaRecibosRefinanciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaRecibosRefinanciacion.Location = new System.Drawing.Point(617, 359);
            this.dgvGrillaRecibosRefinanciacion.Name = "dgvGrillaRecibosRefinanciacion";
            this.dgvGrillaRecibosRefinanciacion.ReadOnly = true;
            this.dgvGrillaRecibosRefinanciacion.Size = new System.Drawing.Size(442, 131);
            this.dgvGrillaRecibosRefinanciacion.TabIndex = 26;
            this.dgvGrillaRecibosRefinanciacion.Visible = false;
            this.dgvGrillaRecibosRefinanciacion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrillaRecibosRefinanciacion_CellFormatting);
            // 
            // iconRecibosRefinanciados
            // 
            this.iconRecibosRefinanciados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconRecibosRefinanciados.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconRecibosRefinanciados.IconColor = System.Drawing.Color.White;
            this.iconRecibosRefinanciados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRecibosRefinanciados.IconSize = 59;
            this.iconRecibosRefinanciados.Location = new System.Drawing.Point(616, 496);
            this.iconRecibosRefinanciados.Name = "iconRecibosRefinanciados";
            this.iconRecibosRefinanciados.Size = new System.Drawing.Size(60, 59);
            this.iconRecibosRefinanciados.TabIndex = 30;
            this.iconRecibosRefinanciados.TabStop = false;
            this.iconRecibosRefinanciados.Visible = false;
            // 
            // txtBusquedaRecibosRefinanciados
            // 
            this.txtBusquedaRecibosRefinanciados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaRecibosRefinanciados.Location = new System.Drawing.Point(682, 526);
            this.txtBusquedaRecibosRefinanciados.MaxLength = 4;
            this.txtBusquedaRecibosRefinanciados.Name = "txtBusquedaRecibosRefinanciados";
            this.txtBusquedaRecibosRefinanciados.Size = new System.Drawing.Size(377, 22);
            this.txtBusquedaRecibosRefinanciados.TabIndex = 29;
            this.txtBusquedaRecibosRefinanciados.Visible = false;
            this.txtBusquedaRecibosRefinanciados.TextChanged += new System.EventHandler(this.txtBusquedaRecibosRefinanciados_TextChanged);
            // 
            // lblBusquedaRecibosRefinanciados
            // 
            this.lblBusquedaRecibosRefinanciados.BackColor = System.Drawing.Color.Transparent;
            this.lblBusquedaRecibosRefinanciados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaRecibosRefinanciados.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBusquedaRecibosRefinanciados.Location = new System.Drawing.Point(682, 496);
            this.lblBusquedaRecibosRefinanciados.Name = "lblBusquedaRecibosRefinanciados";
            this.lblBusquedaRecibosRefinanciados.Size = new System.Drawing.Size(377, 27);
            this.lblBusquedaRecibosRefinanciados.TabIndex = 28;
            this.lblBusquedaRecibosRefinanciados.Text = "Busqueda";
            this.lblBusquedaRecibosRefinanciados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBusquedaRecibosRefinanciados.Visible = false;
            // 
            // _10_FormularioEstadoCuentaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1074, 561);
            this.Controls.Add(this.iconRecibosRefinanciados);
            this.Controls.Add(this.txtBusquedaRecibosRefinanciados);
            this.Controls.Add(this.lblBusquedaRecibosRefinanciados);
            this.Controls.Add(this.lblReciboRefinanciacion);
            this.Controls.Add(this.dgvGrillaRecibosRefinanciacion);
            this.Controls.Add(this.lblRefinanciacion);
            this.Controls.Add(this.dgvRefinanciacion);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblRecibos);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtBuscarRecibos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGrillaRecibos);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.ImgBuscar);
            this.Controls.Add(this.txtBuscarCredito);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvGrillaCreditos);
            this.Controls.Add(this.pnlBarraBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(982, 470);
            this.Name = "_10_FormularioEstadoCuentaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado de Cuenta";
            this.Load += new System.EventHandler(this._10_FormularioEstadoCuentaClientes_Load);
            this.pnlBarraBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefinanciacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaRecibosRefinanciacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRecibosRefinanciados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraBotones;
        public System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.Label lblTitulo;
        public FontAwesome.Sharp.IconButton IconTitulo;
        public System.Windows.Forms.DataGridView dgvGrillaCreditos;
        private FontAwesome.Sharp.IconPictureBox ImgBuscar;
        public System.Windows.Forms.TextBox txtBuscarCredito;
        private System.Windows.Forms.Label lblBuscar;
        public System.Windows.Forms.Label lblCreditos;
        public System.Windows.Forms.Label lblRecibos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.TextBox txtBuscarRecibos;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvGrillaRecibos;
        public System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.DataGridView dgvRefinanciacion;
        public System.Windows.Forms.Label lblRefinanciacion;
        public System.Windows.Forms.Label lblReciboRefinanciacion;
        public System.Windows.Forms.DataGridView dgvGrillaRecibosRefinanciacion;
        private FontAwesome.Sharp.IconPictureBox iconRecibosRefinanciados;
        public System.Windows.Forms.TextBox txtBusquedaRecibosRefinanciados;
        private System.Windows.Forms.Label lblBusquedaRecibosRefinanciados;
    }
}