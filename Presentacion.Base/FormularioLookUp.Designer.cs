namespace Presentacion.Base
{
    partial class FormularioLookUp
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.IconTitulo = new FontAwesome.Sharp.IconButton();
            this.ImgBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.pnlBarraBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraBotones
            // 
            this.pnlBarraBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBarraBotones.Controls.Add(this.lblTitulo);
            this.pnlBarraBotones.Controls.Add(this.btnCancelar);
            this.pnlBarraBotones.Controls.Add(this.IconTitulo);
            this.pnlBarraBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraBotones.MaximumSize = new System.Drawing.Size(369, 52);
            this.pnlBarraBotones.MinimumSize = new System.Drawing.Size(369, 52);
            this.pnlBarraBotones.Name = "pnlBarraBotones";
            this.pnlBarraBotones.Size = new System.Drawing.Size(369, 52);
            this.pnlBarraBotones.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(76, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 38);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.Location = new System.Drawing.Point(299, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 52);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IconTitulo
            // 
            this.IconTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconTitulo.FlatAppearance.BorderSize = 0;
            this.IconTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.IconTitulo.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.IconTitulo.IconColor = System.Drawing.Color.White;
            this.IconTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconTitulo.IconSize = 30;
            this.IconTitulo.Location = new System.Drawing.Point(0, 0);
            this.IconTitulo.Name = "IconTitulo";
            this.IconTitulo.Size = new System.Drawing.Size(70, 52);
            this.IconTitulo.TabIndex = 4;
            this.IconTitulo.UseVisualStyleBackColor = true;
            // 
            // ImgBuscar
            // 
            this.ImgBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImgBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ImgBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ImgBuscar.IconColor = System.Drawing.Color.White;
            this.ImgBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImgBuscar.IconSize = 59;
            this.ImgBuscar.Location = new System.Drawing.Point(12, 371);
            this.ImgBuscar.Name = "ImgBuscar";
            this.ImgBuscar.Size = new System.Drawing.Size(60, 59);
            this.ImgBuscar.TabIndex = 14;
            this.ImgBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(78, 408);
            this.txtBuscar.MaxLength = 500;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(279, 22);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBuscar.Location = new System.Drawing.Point(78, 371);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(279, 27);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Busqueda";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 58);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(345, 310);
            this.dgvGrilla.TabIndex = 11;
            this.dgvGrilla.DataSourceChanged += new System.EventHandler(this.dgvGrilla_DataSourceChanged);
            this.dgvGrilla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrilla_CellFormatting);
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            this.dgvGrilla.DoubleClick += new System.EventHandler(this.dgvGrilla_DoubleClick);
            // 
            // FormularioLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ImgBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.pnlBarraBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioLookUp";
            this.Text = "FormularioLookUp";
            this.Load += new System.EventHandler(this.FormularioLookUp_Load);
            this.pnlBarraBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraBotones;
        private FontAwesome.Sharp.IconButton btnCancelar;
        public FontAwesome.Sharp.IconButton IconTitulo;
        public System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox ImgBuscar;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        public System.Windows.Forms.DataGridView dgvGrilla;
    }
}