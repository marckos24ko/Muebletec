namespace Presentacion.Core.Recibos
{
    partial class _11_FormularioConsultaRecibos
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
            this.lblSemana = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnVer = new FontAwesome.Sharp.IconButton();
            this.btnImprimirTodos = new FontAwesome.Sharp.IconButton();
            this.btnImprimirSeleccionado = new FontAwesome.Sharp.IconButton();
            this.ImgBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(547, 33);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "RECIBOS";
            // 
            // lblSemana
            // 
            this.lblSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSemana.Location = new System.Drawing.Point(12, 84);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(605, 27);
            this.lblSemana.TabIndex = 12;
            this.lblSemana.Text = "Para Imprimir Esta Semana";
            this.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgvGrilla.Location = new System.Drawing.Point(17, 114);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(583, 235);
            this.dgvGrilla.TabIndex = 13;
            this.dgvGrilla.DataSourceChanged += new System.EventHandler(this.dgvGrilla_DataSourceChanged);
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.DarkGray;
            this.btnVer.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnVer.IconColor = System.Drawing.Color.White;
            this.btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(607, 164);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(212, 55);
            this.btnVer.TabIndex = 22;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnImprimirTodos
            // 
            this.btnImprimirTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirTodos.FlatAppearance.BorderSize = 0;
            this.btnImprimirTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTodos.ForeColor = System.Drawing.Color.DarkGray;
            this.btnImprimirTodos.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirTodos.IconColor = System.Drawing.Color.White;
            this.btnImprimirTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirTodos.Location = new System.Drawing.Point(607, 216);
            this.btnImprimirTodos.Name = "btnImprimirTodos";
            this.btnImprimirTodos.Size = new System.Drawing.Size(212, 55);
            this.btnImprimirTodos.TabIndex = 21;
            this.btnImprimirTodos.Text = "Imprimir Todos";
            this.btnImprimirTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirTodos.UseVisualStyleBackColor = true;
            this.btnImprimirTodos.Click += new System.EventHandler(this.btnImprimirTodos_Click);
            // 
            // btnImprimirSeleccionado
            // 
            this.btnImprimirSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirSeleccionado.FlatAppearance.BorderSize = 0;
            this.btnImprimirSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirSeleccionado.ForeColor = System.Drawing.Color.DarkGray;
            this.btnImprimirSeleccionado.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirSeleccionado.IconColor = System.Drawing.Color.White;
            this.btnImprimirSeleccionado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirSeleccionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirSeleccionado.Location = new System.Drawing.Point(607, 114);
            this.btnImprimirSeleccionado.Name = "btnImprimirSeleccionado";
            this.btnImprimirSeleccionado.Size = new System.Drawing.Size(212, 55);
            this.btnImprimirSeleccionado.TabIndex = 23;
            this.btnImprimirSeleccionado.Text = "Imprimir Seleccionado";
            this.btnImprimirSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirSeleccionado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirSeleccionado.UseVisualStyleBackColor = true;
            this.btnImprimirSeleccionado.Click += new System.EventHandler(this.btnImprimirSeleccionado_Click);
            // 
            // ImgBuscar
            // 
            this.ImgBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImgBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ImgBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ImgBuscar.IconColor = System.Drawing.Color.White;
            this.ImgBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImgBuscar.IconSize = 59;
            this.ImgBuscar.Location = new System.Drawing.Point(15, 355);
            this.ImgBuscar.Name = "ImgBuscar";
            this.ImgBuscar.Size = new System.Drawing.Size(60, 59);
            this.ImgBuscar.TabIndex = 26;
            this.ImgBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(82, 386);
            this.txtBuscar.MaxLength = 500;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(517, 22);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBuscar.Location = new System.Drawing.Point(82, 356);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(387, 27);
            this.lblBuscar.TabIndex = 24;
            this.lblBuscar.Text = "Busqueda";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(475, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(530, 357);
            this.txtTotal.MaxLength = 500;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(68, 22);
            this.txtTotal.TabIndex = 28;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirSeleccionado);
            // 
            // _11_FormularioConsultaRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(828, 426);
            this.ControlBox = false;
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImgBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnImprimirSeleccionado);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnImprimirTodos);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_11_FormularioConsultaRecibos";
            this.Text = "Consulta Recibos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSemana;
        private FontAwesome.Sharp.IconButton btnVer;
        private FontAwesome.Sharp.IconButton btnImprimirTodos;
        private FontAwesome.Sharp.IconButton btnImprimirSeleccionado;
        private FontAwesome.Sharp.IconPictureBox ImgBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}