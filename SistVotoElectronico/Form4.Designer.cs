namespace SistVotoElectronico
{
    partial class FrmControl
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
            this.btnControlAcceso = new System.Windows.Forms.Button();
            this.txtControlContraseña = new System.Windows.Forms.TextBox();
            this.txtControlUsuario = new System.Windows.Forms.TextBox();
            this.lblControlUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnControlAcceso
            // 
            this.btnControlAcceso.Location = new System.Drawing.Point(124, 138);
            this.btnControlAcceso.Name = "btnControlAcceso";
            this.btnControlAcceso.Size = new System.Drawing.Size(75, 23);
            this.btnControlAcceso.TabIndex = 4;
            this.btnControlAcceso.Text = "Acceso";
            this.btnControlAcceso.UseVisualStyleBackColor = true;
            this.btnControlAcceso.Click += new System.EventHandler(this.btnControlAcceso_Click);
            // 
            // txtControlContraseña
            // 
            this.txtControlContraseña.Location = new System.Drawing.Point(124, 94);
            this.txtControlContraseña.Name = "txtControlContraseña";
            this.txtControlContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtControlContraseña.TabIndex = 3;
            this.txtControlContraseña.UseSystemPasswordChar = true;
            // 
            // txtControlUsuario
            // 
            this.txtControlUsuario.Location = new System.Drawing.Point(124, 54);
            this.txtControlUsuario.Name = "txtControlUsuario";
            this.txtControlUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtControlUsuario.TabIndex = 1;
            // 
            // lblControlUsuario
            // 
            this.lblControlUsuario.AutoSize = true;
            this.lblControlUsuario.Location = new System.Drawing.Point(58, 58);
            this.lblControlUsuario.Name = "lblControlUsuario";
            this.lblControlUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblControlUsuario.TabIndex = 0;
            this.lblControlUsuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // FrmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblControlUsuario);
            this.Controls.Add(this.txtControlUsuario);
            this.Controls.Add(this.txtControlContraseña);
            this.Controls.Add(this.btnControlAcceso);
            this.Name = "FrmControl";
            this.Text = "Control de Acceso";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnControlAcceso;
        private System.Windows.Forms.TextBox txtControlContraseña;
        private System.Windows.Forms.TextBox txtControlUsuario;
        private System.Windows.Forms.Label lblControlUsuario;
        private System.Windows.Forms.Label label2;
    }
}