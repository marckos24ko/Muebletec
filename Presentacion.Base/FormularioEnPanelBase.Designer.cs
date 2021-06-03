using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Base
{
    partial class FormularioEnPanelBase
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
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.ImgBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.btnEstadoCuenta = new FontAwesome.Sharp.IconButton();
            this.btnRefinanciar = new FontAwesome.Sharp.IconButton();
            this.lblTituloRefinanciacion = new System.Windows.Forms.Label();
            this.pnlRefinanciacion = new System.Windows.Forms.Panel();
            this.dgvGrillaRefinanciacion = new System.Windows.Forms.DataGridView();
            this.btnRecibosRefinanciar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).BeginInit();
            this.pnlRefinanciacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaRefinanciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 45;
            this.btnEliminar.Location = new System.Drawing.Point(958, 180);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 60);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 40;
            this.btnModificar.Location = new System.Drawing.Point(958, 114);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 60);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 40;
            this.btnNuevo.Location = new System.Drawing.Point(958, 48);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(117, 60);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(10, 48);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(939, 192);
            this.dgvGrilla.TabIndex = 1;
            this.dgvGrilla.DataSourceChanged += new System.EventHandler(this.dgvGrilla_DataSourceChanged);
            this.dgvGrilla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrilla_CellFormatting);
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(678, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TITULO";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(76, 283);
            this.txtBuscar.MaxLength = 500;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(873, 22);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBuscar.Location = new System.Drawing.Point(76, 246);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(873, 27);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Busqueda";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImgBuscar
            // 
            this.ImgBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImgBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ImgBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ImgBuscar.IconColor = System.Drawing.Color.White;
            this.ImgBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImgBuscar.IconSize = 59;
            this.ImgBuscar.Location = new System.Drawing.Point(10, 246);
            this.ImgBuscar.Name = "ImgBuscar";
            this.ImgBuscar.Size = new System.Drawing.Size(60, 59);
            this.ImgBuscar.TabIndex = 10;
            this.ImgBuscar.TabStop = false;
            // 
            // btnEstadoCuenta
            // 
            this.btnEstadoCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadoCuenta.FlatAppearance.BorderSize = 0;
            this.btnEstadoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoCuenta.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEstadoCuenta.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnEstadoCuenta.IconColor = System.Drawing.Color.White;
            this.btnEstadoCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstadoCuenta.IconSize = 45;
            this.btnEstadoCuenta.Location = new System.Drawing.Point(958, 246);
            this.btnEstadoCuenta.Name = "btnEstadoCuenta";
            this.btnEstadoCuenta.Size = new System.Drawing.Size(117, 65);
            this.btnEstadoCuenta.TabIndex = 11;
            this.btnEstadoCuenta.Text = "Estado de Cuenta";
            this.btnEstadoCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstadoCuenta.UseVisualStyleBackColor = true;
            this.btnEstadoCuenta.Visible = false;
            this.btnEstadoCuenta.Click += new System.EventHandler(this.btnEstadoCuenta_Click);
            // 
            // btnRefinanciar
            // 
            this.btnRefinanciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefinanciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnRefinanciar.FlatAppearance.BorderSize = 0;
            this.btnRefinanciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefinanciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefinanciar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRefinanciar.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnRefinanciar.IconColor = System.Drawing.Color.White;
            this.btnRefinanciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefinanciar.IconSize = 65;
            this.btnRefinanciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefinanciar.Location = new System.Drawing.Point(958, 317);
            this.btnRefinanciar.Name = "btnRefinanciar";
            this.btnRefinanciar.Size = new System.Drawing.Size(117, 65);
            this.btnRefinanciar.TabIndex = 12;
            this.btnRefinanciar.Text = "Refinanciar";
            this.btnRefinanciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefinanciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefinanciar.UseVisualStyleBackColor = false;
            this.btnRefinanciar.Visible = false;
            this.btnRefinanciar.Click += new System.EventHandler(this.btnRefinanciar_Click);
            // 
            // lblTituloRefinanciacion
            // 
            this.lblTituloRefinanciacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloRefinanciacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTituloRefinanciacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTituloRefinanciacion.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTituloRefinanciacion.Location = new System.Drawing.Point(12, 308);
            this.lblTituloRefinanciacion.Name = "lblTituloRefinanciacion";
            this.lblTituloRefinanciacion.Size = new System.Drawing.Size(937, 33);
            this.lblTituloRefinanciacion.TabIndex = 14;
            this.lblTituloRefinanciacion.Text = "Refinanciacion";
            this.lblTituloRefinanciacion.Visible = false;
            // 
            // pnlRefinanciacion
            // 
            this.pnlRefinanciacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRefinanciacion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlRefinanciacion.Controls.Add(this.dgvGrillaRefinanciacion);
            this.pnlRefinanciacion.Controls.Add(this.btnRecibosRefinanciar);
            this.pnlRefinanciacion.Location = new System.Drawing.Point(12, 346);
            this.pnlRefinanciacion.Name = "pnlRefinanciacion";
            this.pnlRefinanciacion.Size = new System.Drawing.Size(937, 68);
            this.pnlRefinanciacion.TabIndex = 13;
            this.pnlRefinanciacion.Visible = false;
            // 
            // dgvGrillaRefinanciacion
            // 
            this.dgvGrillaRefinanciacion.AllowUserToAddRows = false;
            this.dgvGrillaRefinanciacion.AllowUserToDeleteRows = false;
            this.dgvGrillaRefinanciacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrillaRefinanciacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrillaRefinanciacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrillaRefinanciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaRefinanciacion.Location = new System.Drawing.Point(3, 3);
            this.dgvGrillaRefinanciacion.Name = "dgvGrillaRefinanciacion";
            this.dgvGrillaRefinanciacion.ReadOnly = true;
            this.dgvGrillaRefinanciacion.Size = new System.Drawing.Size(841, 62);
            this.dgvGrillaRefinanciacion.TabIndex = 0;
            this.dgvGrillaRefinanciacion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrillaRefinanciacion_CellFormatting);
            this.dgvGrillaRefinanciacion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaRefinanciacion_RowEnter);
            // 
            // btnRecibosRefinanciar
            // 
            this.btnRecibosRefinanciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecibosRefinanciar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRecibosRefinanciar.FlatAppearance.BorderSize = 0;
            this.btnRecibosRefinanciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibosRefinanciar.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnRecibosRefinanciar.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnRecibosRefinanciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecibosRefinanciar.IconSize = 40;
            this.btnRecibosRefinanciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecibosRefinanciar.Location = new System.Drawing.Point(850, 12);
            this.btnRecibosRefinanciar.Name = "btnRecibosRefinanciar";
            this.btnRecibosRefinanciar.Size = new System.Drawing.Size(84, 42);
            this.btnRecibosRefinanciar.TabIndex = 1;
            this.btnRecibosRefinanciar.UseVisualStyleBackColor = false;
            this.btnRecibosRefinanciar.Click += new System.EventHandler(this.btnRecibosRefinanciar_Click);
            // 
            // FormularioEnPanelBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1087, 426);
            this.Controls.Add(this.btnEstadoCuenta);
            this.Controls.Add(this.btnRefinanciar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.ImgBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.pnlRefinanciacion);
            this.Controls.Add(this.lblTituloRefinanciacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioEnPanelBase";
            this.Text = "FormularioEnPanelBase";
            this.Load += new System.EventHandler(this.FormularioEnPanelBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).EndInit();
            this.pnlRefinanciacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaRefinanciacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public FontAwesome.Sharp.IconButton btnNuevo;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnModificar;
        public System.Windows.Forms.DataGridView dgvGrilla;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Label lblBuscar;
        public FontAwesome.Sharp.IconPictureBox ImgBuscar;
        public System.Windows.Forms.Label lblTitulo;
        public FontAwesome.Sharp.IconButton btnEstadoCuenta;
        public FontAwesome.Sharp.IconButton btnRefinanciar;
        //agregados
        public System.Windows.Forms.Label lblTituloRefinanciacion;
        public System.Windows.Forms.Panel pnlRefinanciacion;
        public System.Windows.Forms.DataGridView dgvGrillaRefinanciacion;
        public FontAwesome.Sharp.IconButton btnRecibosRefinanciar;
    }
}