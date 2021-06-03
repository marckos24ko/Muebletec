namespace Presentacion.Base
{
    partial class FormularioABM
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
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnEjecutar = new FontAwesome.Sharp.IconButton();
            this.lblCampoObligatorio = new System.Windows.Forms.Label();
            this.pnlBarraBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraBotones
            // 
            this.pnlBarraBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBarraBotones.Controls.Add(this.btnCancelar);
            this.pnlBarraBotones.Controls.Add(this.btnLimpiar);
            this.pnlBarraBotones.Controls.Add(this.btnEjecutar);
            this.pnlBarraBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraBotones.Name = "pnlBarraBotones";
            this.pnlBarraBotones.Size = new System.Drawing.Size(330, 52);
            this.pnlBarraBotones.TabIndex = 1;
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
            this.btnCancelar.Location = new System.Drawing.Point(249, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 52);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 30;
            this.btnLimpiar.Location = new System.Drawing.Point(70, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 52);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnEjecutar.IconColor = System.Drawing.Color.White;
            this.btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEjecutar.IconSize = 30;
            this.btnEjecutar.Location = new System.Drawing.Point(0, 0);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(70, 52);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lblCampoObligatorio
            // 
            this.lblCampoObligatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCampoObligatorio.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCampoObligatorio.Location = new System.Drawing.Point(0, 52);
            this.lblCampoObligatorio.Name = "lblCampoObligatorio";
            this.lblCampoObligatorio.Size = new System.Drawing.Size(330, 19);
            this.lblCampoObligatorio.TabIndex = 4;
            this.lblCampoObligatorio.Text = "(*) Campo Obligatorio";
            this.lblCampoObligatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormularioABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(330, 369);
            this.ControlBox = false;
            this.Controls.Add(this.lblCampoObligatorio);
            this.Controls.Add(this.pnlBarraBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(346, 408);
            this.Name = "FormularioABM";
            this.Text = "FormularioABM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioABM_FormClosing);
            this.pnlBarraBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraBotones;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private System.Windows.Forms.Label lblCampoObligatorio;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}