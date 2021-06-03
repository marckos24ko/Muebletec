namespace Presentacion.Core.Credito
{
    partial class _6_FormularioCreditoTipoTransaccion
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
            this.btnCreditoEfectivo = new FontAwesome.Sharp.IconButton();
            this.btnCreditoMuebles = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnCreditoEfectivo
            // 
            this.btnCreditoEfectivo.FlatAppearance.BorderSize = 0;
            this.btnCreditoEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditoEfectivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreditoEfectivo.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCreditoEfectivo.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnCreditoEfectivo.IconColor = System.Drawing.Color.White;
            this.btnCreditoEfectivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreditoEfectivo.IconSize = 42;
            this.btnCreditoEfectivo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCreditoEfectivo.Location = new System.Drawing.Point(2, 12);
            this.btnCreditoEfectivo.Name = "btnCreditoEfectivo";
            this.btnCreditoEfectivo.Size = new System.Drawing.Size(196, 45);
            this.btnCreditoEfectivo.TabIndex = 0;
            this.btnCreditoEfectivo.Text = "CREDITO EFECTIVO";
            this.btnCreditoEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditoEfectivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreditoEfectivo.UseVisualStyleBackColor = true;
            this.btnCreditoEfectivo.Click += new System.EventHandler(this.btnCreditoEfectivo_Click);
            // 
            // btnCreditoMuebles
            // 
            this.btnCreditoMuebles.FlatAppearance.BorderSize = 0;
            this.btnCreditoMuebles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditoMuebles.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreditoMuebles.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCreditoMuebles.IconChar = FontAwesome.Sharp.IconChar.Couch;
            this.btnCreditoMuebles.IconColor = System.Drawing.Color.White;
            this.btnCreditoMuebles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreditoMuebles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditoMuebles.Location = new System.Drawing.Point(2, 63);
            this.btnCreditoMuebles.Name = "btnCreditoMuebles";
            this.btnCreditoMuebles.Size = new System.Drawing.Size(196, 46);
            this.btnCreditoMuebles.TabIndex = 1;
            this.btnCreditoMuebles.Text = "CREDITO BIEN MUEBLE";
            this.btnCreditoMuebles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreditoMuebles.UseVisualStyleBackColor = true;
            this.btnCreditoMuebles.Click += new System.EventHandler(this.btnCreditoMuebles_Click);
            // 
            // _6_FormularioCreditoTipoTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(202, 136);
            this.Controls.Add(this.btnCreditoMuebles);
            this.Controls.Add(this.btnCreditoEfectivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(218, 175);
            this.MinimumSize = new System.Drawing.Size(218, 175);
            this.Name = "_6_FormularioCreditoTipoTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Credito";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCreditoEfectivo;
        private FontAwesome.Sharp.IconButton btnCreditoMuebles;
    }
}