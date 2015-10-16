namespace SistVotoElectronico
{
    partial class FrmInicio
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
            this.btnInicioVotante = new System.Windows.Forms.Button();
            this.btnInicioJuez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInicioVotante
            // 
            this.btnInicioVotante.Location = new System.Drawing.Point(306, 268);
            this.btnInicioVotante.Name = "btnInicioVotante";
            this.btnInicioVotante.Size = new System.Drawing.Size(433, 64);
            this.btnInicioVotante.TabIndex = 2;
            this.btnInicioVotante.Text = "Votante";
            this.btnInicioVotante.UseVisualStyleBackColor = true;
            this.btnInicioVotante.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInicioJuez
            // 
            this.btnInicioJuez.Location = new System.Drawing.Point(306, 372);
            this.btnInicioJuez.Name = "btnInicioJuez";
            this.btnInicioJuez.Size = new System.Drawing.Size(433, 64);
            this.btnInicioJuez.TabIndex = 3;
            this.btnInicioJuez.Text = "Juez de Mesa";
            this.btnInicioJuez.UseVisualStyleBackColor = true;
            this.btnInicioJuez.Click += new System.EventHandler(this.btnInicioJuez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Sistema de Voto Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por favor seleccione el tipo de sistema a usar";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistVotoElectronico.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1062, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicioJuez);
            this.Controls.Add(this.btnInicioVotante);
            this.Name = "FrmInicio";
            this.Text = "Inicio - Vot.Ar Sistema Electronico de Voto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicioVotante;
        private System.Windows.Forms.Button btnInicioJuez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}