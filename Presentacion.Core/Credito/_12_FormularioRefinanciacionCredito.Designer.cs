namespace Presentacion.Core.Credito
{
    partial class _12_FormularioRefinanciacionCredito
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
            this.lblCobro = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.dtpCancelacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCuotas = new System.Windows.Forms.NumericUpDown();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblRefinanciacion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCobro
            // 
            this.lblCobro.AutoSize = true;
            this.lblCobro.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobro.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCobro.Location = new System.Drawing.Point(12, 403);
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.Size = new System.Drawing.Size(165, 15);
            this.lblCobro.TabIndex = 145;
            this.lblCobro.Text = "SE COBRA PRIMERA CUOTA EL";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInteres.Location = new System.Drawing.Point(241, 228);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(113, 15);
            this.lblInteres.TabIndex = 144;
            this.lblInteres.Text = "INTERES 30 % SOBRE";
            // 
            // dtpCancelacion
            // 
            this.dtpCancelacion.Enabled = false;
            this.dtpCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCancelacion.Location = new System.Drawing.Point(155, 342);
            this.dtpCancelacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCancelacion.Name = "dtpCancelacion";
            this.dtpCancelacion.Size = new System.Drawing.Size(174, 20);
            this.dtpCancelacion.TabIndex = 142;
            this.dtpCancelacion.Value = new System.DateTime(2021, 2, 11, 1, 29, 48, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(338, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 141;
            this.label4.Text = "*";
            // 
            // nudCuotas
            // 
            this.nudCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCuotas.Location = new System.Drawing.Point(154, 297);
            this.nudCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCuotas.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCuotas.Name = "nudCuotas";
            this.nudCuotas.ReadOnly = true;
            this.nudCuotas.Size = new System.Drawing.Size(36, 20);
            this.nudCuotas.TabIndex = 140;
            this.nudCuotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCuotas.ValueChanged += new System.EventHandler(this.nudCuotas_ValueChanged);
            // 
            // dtpEmision
            // 
            this.dtpEmision.Enabled = false;
            this.dtpEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmision.Location = new System.Drawing.Point(154, 262);
            this.dtpEmision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(197, 20);
            this.dtpEmision.TabIndex = 139;
            this.dtpEmision.Value = new System.DateTime(2021, 2, 11, 1, 29, 48, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(66, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 138;
            this.label10.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(154, 155);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(55, 20);
            this.txtCodigo.TabIndex = 137;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(357, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 136;
            this.label7.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(11, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 135;
            this.label9.Text = "Cancelacion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(215, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 134;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(234, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 133;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(295, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 132;
            this.label13.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(196, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 131;
            this.label11.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(55, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 130;
            this.label6.Text = "Celiente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(210, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 129;
            this.label5.Text = "Precio ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(68, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 128;
            this.label3.Text = "Cuotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(66, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 127;
            this.label2.Text = "Emision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(76, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 126;
            this.label1.Text = "Monto";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(154, 189);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.MaxLength = 10;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(135, 20);
            this.txtCliente.TabIndex = 125;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(282, 299);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(72, 18);
            this.txtPrecio.TabIndex = 124;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(154, 226);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.MaxLength = 6;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(73, 20);
            this.txtMonto.TabIndex = 123;
            this.txtMonto.Text = "1000";
            // 
            // lblRefinanciacion
            // 
            this.lblRefinanciacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRefinanciacion.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefinanciacion.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRefinanciacion.Location = new System.Drawing.Point(0, 71);
            this.lblRefinanciacion.Name = "lblRefinanciacion";
            this.lblRefinanciacion.Size = new System.Drawing.Size(436, 33);
            this.lblRefinanciacion.TabIndex = 146;
            this.lblRefinanciacion.Text = "Refinanciacion Credito N°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(357, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 147;
            this.label8.Text = "*";
            // 
            // _12_FormularioRefinanciacionCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 427);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRefinanciacion);
            this.Controls.Add(this.lblCobro);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.dtpCancelacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCuotas);
            this.Controls.Add(this.dtpEmision);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtMonto);
            this.Name = "_12_FormularioRefinanciacionCredito";
            this.Text = "Refinanciar Credito";
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dtpEmision, 0);
            this.Controls.SetChildIndex(this.nudCuotas, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtpCancelacion, 0);
            this.Controls.SetChildIndex(this.lblInteres, 0);
            this.Controls.SetChildIndex(this.lblCobro, 0);
            this.Controls.SetChildIndex(this.lblRefinanciacion, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCobro;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.DateTimePicker dtpCancelacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCuotas;
        private System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblRefinanciacion;
        private System.Windows.Forms.Label label8;
    }
}