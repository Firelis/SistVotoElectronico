namespace SistVotoElectronico
{
    partial class FrmVotante
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVotante));
            this.rdbVotanteRosas = new System.Windows.Forms.RadioButton();
            this.rdbVotanteSarmiento = new System.Windows.Forms.RadioButton();
            this.rdbVotanteUrquiza = new System.Windows.Forms.RadioButton();
            this.rdbVotanteBlanco = new System.Windows.Forms.RadioButton();
            this.btnVotanteEmitirVoto = new System.Windows.Forms.Button();
            this.pcbVotanteUrquiza = new System.Windows.Forms.PictureBox();
            this.pcbVotanteEnBlanco = new System.Windows.Forms.PictureBox();
            this.pcbVotanteRosas = new System.Windows.Forms.PictureBox();
            this.pcbVotanteSarmiento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVotanteUrquiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVotanteEnBlanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVotanteRosas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVotanteSarmiento)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbVotanteRosas
            // 
            resources.ApplyResources(this.rdbVotanteRosas, "rdbVotanteRosas");
            this.rdbVotanteRosas.BackColor = System.Drawing.Color.Transparent;
            this.rdbVotanteRosas.Name = "rdbVotanteRosas";
            this.rdbVotanteRosas.TabStop = true;
            this.rdbVotanteRosas.UseVisualStyleBackColor = false;
            // 
            // rdbVotanteSarmiento
            // 
            resources.ApplyResources(this.rdbVotanteSarmiento, "rdbVotanteSarmiento");
            this.rdbVotanteSarmiento.BackColor = System.Drawing.Color.Transparent;
            this.rdbVotanteSarmiento.Name = "rdbVotanteSarmiento";
            this.rdbVotanteSarmiento.TabStop = true;
            this.rdbVotanteSarmiento.UseVisualStyleBackColor = false;
            // 
            // rdbVotanteUrquiza
            // 
            resources.ApplyResources(this.rdbVotanteUrquiza, "rdbVotanteUrquiza");
            this.rdbVotanteUrquiza.BackColor = System.Drawing.Color.Transparent;
            this.rdbVotanteUrquiza.Name = "rdbVotanteUrquiza";
            this.rdbVotanteUrquiza.TabStop = true;
            this.rdbVotanteUrquiza.UseVisualStyleBackColor = false;
            // 
            // rdbVotanteBlanco
            // 
            resources.ApplyResources(this.rdbVotanteBlanco, "rdbVotanteBlanco");
            this.rdbVotanteBlanco.BackColor = System.Drawing.Color.Transparent;
            this.rdbVotanteBlanco.Name = "rdbVotanteBlanco";
            this.rdbVotanteBlanco.TabStop = true;
            this.rdbVotanteBlanco.UseVisualStyleBackColor = false;
            // 
            // btnVotanteEmitirVoto
            // 
            resources.ApplyResources(this.btnVotanteEmitirVoto, "btnVotanteEmitirVoto");
            this.btnVotanteEmitirVoto.Name = "btnVotanteEmitirVoto";
            this.btnVotanteEmitirVoto.UseVisualStyleBackColor = true;
            // 
            // pcbVotanteUrquiza
            // 
            this.pcbVotanteUrquiza.Image = global::SistVotoElectronico.Properties.Resources.Urquiza;
            resources.ApplyResources(this.pcbVotanteUrquiza, "pcbVotanteUrquiza");
            this.pcbVotanteUrquiza.Name = "pcbVotanteUrquiza";
            this.pcbVotanteUrquiza.TabStop = false;
            // 
            // pcbVotanteEnBlanco
            // 
            this.pcbVotanteEnBlanco.Image = global::SistVotoElectronico.Properties.Resources.Silueta;
            resources.ApplyResources(this.pcbVotanteEnBlanco, "pcbVotanteEnBlanco");
            this.pcbVotanteEnBlanco.Name = "pcbVotanteEnBlanco";
            this.pcbVotanteEnBlanco.TabStop = false;
            // 
            // pcbVotanteRosas
            // 
            this.pcbVotanteRosas.Image = global::SistVotoElectronico.Properties.Resources.Juan_Manuel_de_Rosas;
            resources.ApplyResources(this.pcbVotanteRosas, "pcbVotanteRosas");
            this.pcbVotanteRosas.Name = "pcbVotanteRosas";
            this.pcbVotanteRosas.TabStop = false;
            // 
            // pcbVotanteSarmiento
            // 
            this.pcbVotanteSarmiento.Image = global::SistVotoElectronico.Properties.Resources.sarmiento;
            resources.ApplyResources(this.pcbVotanteSarmiento, "pcbVotanteSarmiento");
            this.pcbVotanteSarmiento.Name = "pcbVotanteSarmiento";
            this.pcbVotanteSarmiento.TabStop = false;
            // 
            // FrmVotante
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistVotoElectronico.Properties.Resources.fondo;
            this.Controls.Add(this.btnVotanteEmitirVoto);
            this.Controls.Add(this.rdbVotanteBlanco);
            this.Controls.Add(this.rdbVotanteUrquiza);
            this.Controls.Add(this.rdbVotanteSarmiento);
            this.Controls.Add(this.rdbVotanteRosas);
            this.Controls.Add(this.pcbVotanteUrquiza);
            this.Controls.Add(this.pcbVotanteEnBlanco);
            this.Controls.Add(this.pcbVotanteRosas);
            this.Controls.Add(this.pcbVotanteSarmiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVotante";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVotanteUrquiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVotanteEnBlanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVotanteRosas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVotanteSarmiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbVotanteSarmiento;
        private System.Windows.Forms.PictureBox pcbVotanteRosas;
        private System.Windows.Forms.PictureBox pcbVotanteEnBlanco;
        private System.Windows.Forms.PictureBox pcbVotanteUrquiza;
        private System.Windows.Forms.RadioButton rdbVotanteRosas;
        private System.Windows.Forms.RadioButton rdbVotanteSarmiento;
        private System.Windows.Forms.RadioButton rdbVotanteUrquiza;
        private System.Windows.Forms.RadioButton rdbVotanteBlanco;
        private System.Windows.Forms.Button btnVotanteEmitirVoto;
    }
}

