namespace Presentacion.Core.Recibos
{
    partial class _7_FormularioConsultaRecibosCredito
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.IconTitulo = new FontAwesome.Sharp.IconButton();
            this.pnlBarraBotones = new System.Windows.Forms.Panel();
            this.lblCancelacion = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblCodigoCredito = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.ImgBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnCompletar = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnVer = new FontAwesome.Sharp.IconButton();
            this.btnAtrasar = new FontAwesome.Sharp.IconButton();
            this.lblInfoCredito = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlBarraBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(61, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(245, 38);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Recibos de Credito N°:";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IconTitulo
            // 
            this.IconTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconTitulo.FlatAppearance.BorderSize = 0;
            this.IconTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.IconTitulo.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.IconTitulo.IconColor = System.Drawing.Color.White;
            this.IconTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconTitulo.IconSize = 30;
            this.IconTitulo.Location = new System.Drawing.Point(0, 0);
            this.IconTitulo.Name = "IconTitulo";
            this.IconTitulo.Size = new System.Drawing.Size(55, 52);
            this.IconTitulo.TabIndex = 4;
            this.IconTitulo.UseVisualStyleBackColor = true;
            // 
            // pnlBarraBotones
            // 
            this.pnlBarraBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBarraBotones.Controls.Add(this.lblCancelacion);
            this.pnlBarraBotones.Controls.Add(this.lbl1);
            this.pnlBarraBotones.Controls.Add(this.lblCodigoCredito);
            this.pnlBarraBotones.Controls.Add(this.lblTitulo);
            this.pnlBarraBotones.Controls.Add(this.IconTitulo);
            this.pnlBarraBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraBotones.MaximumSize = new System.Drawing.Size(1230, 52);
            this.pnlBarraBotones.MinimumSize = new System.Drawing.Size(100, 52);
            this.pnlBarraBotones.Name = "pnlBarraBotones";
            this.pnlBarraBotones.Size = new System.Drawing.Size(599, 52);
            this.pnlBarraBotones.TabIndex = 3;
            // 
            // lblCancelacion
            // 
            this.lblCancelacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelacion.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCancelacion.Location = new System.Drawing.Point(505, 5);
            this.lblCancelacion.Name = "lblCancelacion";
            this.lblCancelacion.Size = new System.Drawing.Size(96, 38);
            this.lblCancelacion.TabIndex = 14;
            this.lblCancelacion.Text = "fecha";
            this.lblCancelacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl1.Location = new System.Drawing.Point(381, 6);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(118, 38);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Cancelacion :";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigoCredito
            // 
            this.lblCodigoCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblCodigoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCredito.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCodigoCredito.Location = new System.Drawing.Point(312, 5);
            this.lblCodigoCredito.Name = "lblCodigoCredito";
            this.lblCodigoCredito.Size = new System.Drawing.Size(63, 38);
            this.lblCodigoCredito.TabIndex = 12;
            this.lblCodigoCredito.Text = "N°";
            this.lblCodigoCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 55);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(589, 189);
            this.dgvGrilla.TabIndex = 12;
            this.dgvGrilla.DataSourceChanged += new System.EventHandler(this.dgvGrilla_DataSourceChanged);
            this.dgvGrilla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrilla_CellFormatting);
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            // 
            // ImgBuscar
            // 
            this.ImgBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ImgBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ImgBuscar.IconColor = System.Drawing.Color.White;
            this.ImgBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImgBuscar.IconSize = 59;
            this.ImgBuscar.Location = new System.Drawing.Point(12, 281);
            this.ImgBuscar.Name = "ImgBuscar";
            this.ImgBuscar.Size = new System.Drawing.Size(60, 59);
            this.ImgBuscar.TabIndex = 17;
            this.ImgBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(78, 312);
            this.txtBuscar.MaxLength = 500;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(523, 22);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBuscar.Location = new System.Drawing.Point(78, 282);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(523, 27);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Busqueda";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCompletar
            // 
            this.btnCompletar.FlatAppearance.BorderSize = 0;
            this.btnCompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCompletar.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnCompletar.IconColor = System.Drawing.Color.White;
            this.btnCompletar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompletar.Location = new System.Drawing.Point(265, 350);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(166, 55);
            this.btnCompletar.TabIndex = 18;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.DarkGray;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(437, 350);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(161, 55);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnVer
            // 
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.DarkGray;
            this.btnVer.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnVer.IconColor = System.Drawing.Color.White;
            this.btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVer.Location = new System.Drawing.Point(150, 350);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(109, 55);
            this.btnVer.TabIndex = 20;
            this.btnVer.Text = "Ver";
            this.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAtrasar
            // 
            this.btnAtrasar.FlatAppearance.BorderSize = 0;
            this.btnAtrasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAtrasar.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown;
            this.btnAtrasar.IconColor = System.Drawing.Color.White;
            this.btnAtrasar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtrasar.Location = new System.Drawing.Point(12, 351);
            this.btnAtrasar.Name = "btnAtrasar";
            this.btnAtrasar.Size = new System.Drawing.Size(132, 55);
            this.btnAtrasar.TabIndex = 21;
            this.btnAtrasar.Text = "Atrasar";
            this.btnAtrasar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtrasar.UseVisualStyleBackColor = true;
            this.btnAtrasar.Click += new System.EventHandler(this.btnAtrasar_Click);
            // 
            // lblInfoCredito
            // 
            this.lblInfoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoCredito.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCredito.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInfoCredito.Location = new System.Drawing.Point(385, 247);
            this.lblInfoCredito.Name = "lblInfoCredito";
            this.lblInfoCredito.Size = new System.Drawing.Size(213, 27);
            this.lblInfoCredito.TabIndex = 22;
            this.lblInfoCredito.Text = "Credito";
            this.lblInfoCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirSeleccionado);
            // 
            // _7_FormularioConsultaRecibosCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(613, 410);
            this.Controls.Add(this.lblInfoCredito);
            this.Controls.Add(this.btnAtrasar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.ImgBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.pnlBarraBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_7_FormularioConsultaRecibosCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibos Credito";
            this.Load += new System.EventHandler(this._7_FormularioConsultaRecibosCredito_Load);
            this.pnlBarraBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        public FontAwesome.Sharp.IconButton IconTitulo;
        private System.Windows.Forms.Panel pnlBarraBotones;
        public System.Windows.Forms.DataGridView dgvGrilla;
        private FontAwesome.Sharp.IconPictureBox ImgBuscar;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private FontAwesome.Sharp.IconButton btnCompletar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        public System.Windows.Forms.Label lblCodigoCredito;
        private FontAwesome.Sharp.IconButton btnVer;
        private FontAwesome.Sharp.IconButton btnAtrasar;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lblCancelacion;
        private System.Windows.Forms.Label lblInfoCredito;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}