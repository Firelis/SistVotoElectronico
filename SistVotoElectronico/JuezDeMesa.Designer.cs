namespace SistVotoElectronico
{
    partial class FrmJuezMesa
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
            this.txtJuezNom = new System.Windows.Forms.TextBox();
            this.txtJuezApe = new System.Windows.Forms.TextBox();
            this.txtJuezTipDoc = new System.Windows.Forms.TextBox();
            this.txtJuezDocumento = new System.Windows.Forms.TextBox();
            this.txtJuezCalle = new System.Windows.Forms.TextBox();
            this.txtJuezLocalidad = new System.Windows.Forms.TextBox();
            this.txtJuezDepartamento = new System.Windows.Forms.TextBox();
            this.lblJuezNomPersona = new System.Windows.Forms.Label();
            this.lblJuezApePersona = new System.Windows.Forms.Label();
            this.lblJuezTipDoc = new System.Windows.Forms.Label();
            this.lblJuezDocumento = new System.Windows.Forms.Label();
            this.lblJuezCalle = new System.Windows.Forms.Label();
            this.lblJuezLocalidad = new System.Windows.Forms.Label();
            this.lblJuezDepartamento = new System.Windows.Forms.Label();
            this.txtJuezAltura = new System.Windows.Forms.TextBox();
            this.lblJuezAltura = new System.Windows.Forms.Label();
            this.grbJuezDatosPersona = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbJuezPresentismo = new System.Windows.Forms.GroupBox();
            this.lblJuezVotoRecienteResult = new System.Windows.Forms.Label();
            this.lvlJuezInformacion1 = new System.Windows.Forms.Label();
            this.cbmJuezIdAsistencia = new System.Windows.Forms.ComboBox();
            this.lblJuezInformacion2 = new System.Windows.Forms.Label();
            this.btnJuezConfirmarVoto = new System.Windows.Forms.Button();
            this.lblJuezSalir = new System.Windows.Forms.Label();
            this.lblJuezMensajeSist = new System.Windows.Forms.Label();
            this.btnJuezHabilitarVoto = new System.Windows.Forms.Button();
            this.grbJuezMensajeSist = new System.Windows.Forms.GroupBox();
            this.grbJuezDatosPersona.SuspendLayout();
            this.grbJuezPresentismo.SuspendLayout();
            this.grbJuezMensajeSist.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJuezNom
            // 
            this.txtJuezNom.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtJuezNom.Location = new System.Drawing.Point(157, 61);
            this.txtJuezNom.Name = "txtJuezNom";
            this.txtJuezNom.ReadOnly = true;
            this.txtJuezNom.Size = new System.Drawing.Size(788, 22);
            this.txtJuezNom.TabIndex = 2;
            // 
            // txtJuezApe
            // 
            this.txtJuezApe.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtJuezApe.Location = new System.Drawing.Point(157, 89);
            this.txtJuezApe.Name = "txtJuezApe";
            this.txtJuezApe.ReadOnly = true;
            this.txtJuezApe.Size = new System.Drawing.Size(788, 22);
            this.txtJuezApe.TabIndex = 5;
            // 
            // txtJuezTipDoc
            // 
            this.txtJuezTipDoc.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtJuezTipDoc.Location = new System.Drawing.Point(834, 33);
            this.txtJuezTipDoc.Name = "txtJuezTipDoc";
            this.txtJuezTipDoc.ReadOnly = true;
            this.txtJuezTipDoc.Size = new System.Drawing.Size(111, 22);
            this.txtJuezTipDoc.TabIndex = 1;
            this.txtJuezTipDoc.TextChanged += new System.EventHandler(this.txtJuezTipDoc_TextChanged);
            // 
            // txtJuezDocumento
            // 
            this.txtJuezDocumento.Location = new System.Drawing.Point(157, 33);
            this.txtJuezDocumento.Name = "txtJuezDocumento";
            this.txtJuezDocumento.Size = new System.Drawing.Size(412, 22);
            this.txtJuezDocumento.TabIndex = 0;
            this.txtJuezDocumento.TextChanged += new System.EventHandler(this.txtJuezDocumento_TextChanged);
            this.txtJuezDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuezDocumento_KeyPress);
            // 
            // txtJuezCalle
            // 
            this.txtJuezCalle.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtJuezCalle.Location = new System.Drawing.Point(157, 117);
            this.txtJuezCalle.Name = "txtJuezCalle";
            this.txtJuezCalle.ReadOnly = true;
            this.txtJuezCalle.Size = new System.Drawing.Size(522, 22);
            this.txtJuezCalle.TabIndex = 11;
            // 
            // txtJuezLocalidad
            // 
            this.txtJuezLocalidad.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtJuezLocalidad.Location = new System.Drawing.Point(157, 145);
            this.txtJuezLocalidad.Name = "txtJuezLocalidad";
            this.txtJuezLocalidad.ReadOnly = true;
            this.txtJuezLocalidad.Size = new System.Drawing.Size(302, 22);
            this.txtJuezLocalidad.TabIndex = 15;
            // 
            // txtJuezDepartamento
            // 
            this.txtJuezDepartamento.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtJuezDepartamento.Location = new System.Drawing.Point(588, 145);
            this.txtJuezDepartamento.Name = "txtJuezDepartamento";
            this.txtJuezDepartamento.ReadOnly = true;
            this.txtJuezDepartamento.Size = new System.Drawing.Size(357, 22);
            this.txtJuezDepartamento.TabIndex = 17;
            // 
            // lblJuezNomPersona
            // 
            this.lblJuezNomPersona.AutoSize = true;
            this.lblJuezNomPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezNomPersona.Location = new System.Drawing.Point(27, 64);
            this.lblJuezNomPersona.Name = "lblJuezNomPersona";
            this.lblJuezNomPersona.Size = new System.Drawing.Size(64, 17);
            this.lblJuezNomPersona.TabIndex = 2;
            this.lblJuezNomPersona.Text = "Nombre";
            // 
            // lblJuezApePersona
            // 
            this.lblJuezApePersona.AutoSize = true;
            this.lblJuezApePersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezApePersona.Location = new System.Drawing.Point(27, 92);
            this.lblJuezApePersona.Name = "lblJuezApePersona";
            this.lblJuezApePersona.Size = new System.Drawing.Size(66, 17);
            this.lblJuezApePersona.TabIndex = 4;
            this.lblJuezApePersona.Text = "Apellido";
            // 
            // lblJuezTipDoc
            // 
            this.lblJuezTipDoc.AutoSize = true;
            this.lblJuezTipDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezTipDoc.Location = new System.Drawing.Point(685, 36);
            this.lblJuezTipDoc.Name = "lblJuezTipDoc";
            this.lblJuezTipDoc.Size = new System.Drawing.Size(149, 17);
            this.lblJuezTipDoc.TabIndex = 6;
            this.lblJuezTipDoc.Text = "Tipo de Documento";
            // 
            // lblJuezDocumento
            // 
            this.lblJuezDocumento.AutoSize = true;
            this.lblJuezDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezDocumento.Location = new System.Drawing.Point(27, 36);
            this.lblJuezDocumento.Name = "lblJuezDocumento";
            this.lblJuezDocumento.Size = new System.Drawing.Size(89, 17);
            this.lblJuezDocumento.TabIndex = 8;
            this.lblJuezDocumento.Text = "Documento";
            // 
            // lblJuezCalle
            // 
            this.lblJuezCalle.AutoSize = true;
            this.lblJuezCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezCalle.Location = new System.Drawing.Point(27, 120);
            this.lblJuezCalle.Name = "lblJuezCalle";
            this.lblJuezCalle.Size = new System.Drawing.Size(44, 17);
            this.lblJuezCalle.TabIndex = 10;
            this.lblJuezCalle.Text = "Calle";
            // 
            // lblJuezLocalidad
            // 
            this.lblJuezLocalidad.AutoSize = true;
            this.lblJuezLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezLocalidad.Location = new System.Drawing.Point(27, 150);
            this.lblJuezLocalidad.Name = "lblJuezLocalidad";
            this.lblJuezLocalidad.Size = new System.Drawing.Size(78, 17);
            this.lblJuezLocalidad.TabIndex = 14;
            this.lblJuezLocalidad.Text = "Localidad";
            // 
            // lblJuezDepartamento
            // 
            this.lblJuezDepartamento.AutoSize = true;
            this.lblJuezDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezDepartamento.Location = new System.Drawing.Point(465, 150);
            this.lblJuezDepartamento.Name = "lblJuezDepartamento";
            this.lblJuezDepartamento.Size = new System.Drawing.Size(110, 17);
            this.lblJuezDepartamento.TabIndex = 16;
            this.lblJuezDepartamento.Text = "Departamento";
            // 
            // txtJuezAltura
            // 
            this.txtJuezAltura.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtJuezAltura.Location = new System.Drawing.Point(736, 117);
            this.txtJuezAltura.Name = "txtJuezAltura";
            this.txtJuezAltura.ReadOnly = true;
            this.txtJuezAltura.Size = new System.Drawing.Size(209, 22);
            this.txtJuezAltura.TabIndex = 13;
            // 
            // lblJuezAltura
            // 
            this.lblJuezAltura.AutoSize = true;
            this.lblJuezAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezAltura.Location = new System.Drawing.Point(685, 120);
            this.lblJuezAltura.Name = "lblJuezAltura";
            this.lblJuezAltura.Size = new System.Drawing.Size(51, 17);
            this.lblJuezAltura.TabIndex = 12;
            this.lblJuezAltura.Text = "Altura";
            // 
            // grbJuezDatosPersona
            // 
            this.grbJuezDatosPersona.BackColor = System.Drawing.Color.Transparent;
            this.grbJuezDatosPersona.Controls.Add(this.btnBuscar);
            this.grbJuezDatosPersona.Controls.Add(this.lblJuezAltura);
            this.grbJuezDatosPersona.Controls.Add(this.txtJuezAltura);
            this.grbJuezDatosPersona.Controls.Add(this.lblJuezDepartamento);
            this.grbJuezDatosPersona.Controls.Add(this.lblJuezLocalidad);
            this.grbJuezDatosPersona.Controls.Add(this.lblJuezCalle);
            this.grbJuezDatosPersona.Controls.Add(this.lblJuezDocumento);
            this.grbJuezDatosPersona.Controls.Add(this.lblJuezTipDoc);
            this.grbJuezDatosPersona.Controls.Add(this.lblJuezApePersona);
            this.grbJuezDatosPersona.Controls.Add(this.lblJuezNomPersona);
            this.grbJuezDatosPersona.Controls.Add(this.txtJuezDepartamento);
            this.grbJuezDatosPersona.Controls.Add(this.txtJuezLocalidad);
            this.grbJuezDatosPersona.Controls.Add(this.txtJuezCalle);
            this.grbJuezDatosPersona.Controls.Add(this.txtJuezDocumento);
            this.grbJuezDatosPersona.Controls.Add(this.txtJuezTipDoc);
            this.grbJuezDatosPersona.Controls.Add(this.txtJuezApe);
            this.grbJuezDatosPersona.Controls.Add(this.txtJuezNom);
            this.grbJuezDatosPersona.Location = new System.Drawing.Point(35, 26);
            this.grbJuezDatosPersona.Name = "grbJuezDatosPersona";
            this.grbJuezDatosPersona.Size = new System.Drawing.Size(979, 206);
            this.grbJuezDatosPersona.TabIndex = 0;
            this.grbJuezDatosPersona.TabStop = false;
            this.grbJuezDatosPersona.Text = "Datos De La Persona";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(575, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 22);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grbJuezPresentismo
            // 
            this.grbJuezPresentismo.BackColor = System.Drawing.Color.Transparent;
            this.grbJuezPresentismo.Controls.Add(this.lblJuezVotoRecienteResult);
            this.grbJuezPresentismo.Controls.Add(this.lvlJuezInformacion1);
            this.grbJuezPresentismo.Controls.Add(this.cbmJuezIdAsistencia);
            this.grbJuezPresentismo.Controls.Add(this.lblJuezInformacion2);
            this.grbJuezPresentismo.Location = new System.Drawing.Point(36, 242);
            this.grbJuezPresentismo.Name = "grbJuezPresentismo";
            this.grbJuezPresentismo.Size = new System.Drawing.Size(978, 97);
            this.grbJuezPresentismo.TabIndex = 1;
            this.grbJuezPresentismo.TabStop = false;
            this.grbJuezPresentismo.Text = "Presentismo";
            // 
            // lblJuezVotoRecienteResult
            // 
            this.lblJuezVotoRecienteResult.AutoSize = true;
            this.lblJuezVotoRecienteResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezVotoRecienteResult.Location = new System.Drawing.Point(308, 47);
            this.lblJuezVotoRecienteResult.Name = "lblJuezVotoRecienteResult";
            this.lblJuezVotoRecienteResult.Size = new System.Drawing.Size(31, 17);
            this.lblJuezVotoRecienteResult.TabIndex = 3;
            this.lblJuezVotoRecienteResult.Text = "NO";
            // 
            // lvlJuezInformacion1
            // 
            this.lvlJuezInformacion1.AutoSize = true;
            this.lvlJuezInformacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlJuezInformacion1.Location = new System.Drawing.Point(26, 47);
            this.lvlJuezInformacion1.Name = "lvlJuezInformacion1";
            this.lvlJuezInformacion1.Size = new System.Drawing.Size(265, 17);
            this.lvlJuezInformacion1.TabIndex = 2;
            this.lvlJuezInformacion1.Text = "Esta Persona Voto Recientemente?";
            // 
            // cbmJuezIdAsistencia
            // 
            this.cbmJuezIdAsistencia.FormattingEnabled = true;
            this.cbmJuezIdAsistencia.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbmJuezIdAsistencia.Location = new System.Drawing.Point(728, 40);
            this.cbmJuezIdAsistencia.Name = "cbmJuezIdAsistencia";
            this.cbmJuezIdAsistencia.Size = new System.Drawing.Size(216, 24);
            this.cbmJuezIdAsistencia.TabIndex = 0;
            // 
            // lblJuezInformacion2
            // 
            this.lblJuezInformacion2.AutoSize = true;
            this.lblJuezInformacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezInformacion2.Location = new System.Drawing.Point(504, 47);
            this.lblJuezInformacion2.Name = "lblJuezInformacion2";
            this.lblJuezInformacion2.Size = new System.Drawing.Size(174, 17);
            this.lblJuezInformacion2.TabIndex = 0;
            this.lblJuezInformacion2.Text = "¿Se Anuncio en Mesa?";
            // 
            // btnJuezConfirmarVoto
            // 
            this.btnJuezConfirmarVoto.Enabled = false;
            this.btnJuezConfirmarVoto.Location = new System.Drawing.Point(623, 493);
            this.btnJuezConfirmarVoto.Name = "btnJuezConfirmarVoto";
            this.btnJuezConfirmarVoto.Size = new System.Drawing.Size(257, 49);
            this.btnJuezConfirmarVoto.TabIndex = 1;
            this.btnJuezConfirmarVoto.Text = "Confirmar Voto";
            this.btnJuezConfirmarVoto.UseVisualStyleBackColor = true;
            this.btnJuezConfirmarVoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblJuezSalir
            // 
            this.lblJuezSalir.AutoSize = true;
            this.lblJuezSalir.BackColor = System.Drawing.Color.Transparent;
            this.lblJuezSalir.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblJuezSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblJuezSalir.Location = new System.Drawing.Point(12, 609);
            this.lblJuezSalir.Name = "lblJuezSalir";
            this.lblJuezSalir.Size = new System.Drawing.Size(36, 17);
            this.lblJuezSalir.TabIndex = 3;
            this.lblJuezSalir.Text = "Salir";
            this.lblJuezSalir.Click += new System.EventHandler(this.lblJuezSalir_Click_1);
            // 
            // lblJuezMensajeSist
            // 
            this.lblJuezMensajeSist.AutoSize = true;
            this.lblJuezMensajeSist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezMensajeSist.ForeColor = System.Drawing.Color.Red;
            this.lblJuezMensajeSist.Location = new System.Drawing.Point(26, 41);
            this.lblJuezMensajeSist.Name = "lblJuezMensajeSist";
            this.lblJuezMensajeSist.Size = new System.Drawing.Size(17, 17);
            this.lblJuezMensajeSist.TabIndex = 4;
            this.lblJuezMensajeSist.Text = "0";
            // 
            // btnJuezHabilitarVoto
            // 
            this.btnJuezHabilitarVoto.Enabled = false;
            this.btnJuezHabilitarVoto.Location = new System.Drawing.Point(347, 493);
            this.btnJuezHabilitarVoto.Name = "btnJuezHabilitarVoto";
            this.btnJuezHabilitarVoto.Size = new System.Drawing.Size(257, 49);
            this.btnJuezHabilitarVoto.TabIndex = 0;
            this.btnJuezHabilitarVoto.Text = "Habilitar Voto";
            this.btnJuezHabilitarVoto.UseVisualStyleBackColor = true;
            this.btnJuezHabilitarVoto.Click += new System.EventHandler(this.btnJuezHabilitarVoto_Click);
            // 
            // grbJuezMensajeSist
            // 
            this.grbJuezMensajeSist.BackColor = System.Drawing.Color.Transparent;
            this.grbJuezMensajeSist.Controls.Add(this.lblJuezMensajeSist);
            this.grbJuezMensajeSist.Location = new System.Drawing.Point(36, 350);
            this.grbJuezMensajeSist.Name = "grbJuezMensajeSist";
            this.grbJuezMensajeSist.Size = new System.Drawing.Size(978, 81);
            this.grbJuezMensajeSist.TabIndex = 4;
            this.grbJuezMensajeSist.TabStop = false;
            this.grbJuezMensajeSist.Text = "Mensaje Del Sistema";
            // 
            // FrmJuezMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistVotoElectronico.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1062, 635);
            this.Controls.Add(this.grbJuezMensajeSist);
            this.Controls.Add(this.btnJuezHabilitarVoto);
            this.Controls.Add(this.lblJuezSalir);
            this.Controls.Add(this.btnJuezConfirmarVoto);
            this.Controls.Add(this.grbJuezPresentismo);
            this.Controls.Add(this.grbJuezDatosPersona);
            this.Name = "FrmJuezMesa";
            this.Text = "Juez de Mesa - Vot.Ar Sistema Electronico de Voto";
            this.Load += new System.EventHandler(this.FrmJuezMesa_Load);
            this.grbJuezDatosPersona.ResumeLayout(false);
            this.grbJuezDatosPersona.PerformLayout();
            this.grbJuezPresentismo.ResumeLayout(false);
            this.grbJuezPresentismo.PerformLayout();
            this.grbJuezMensajeSist.ResumeLayout(false);
            this.grbJuezMensajeSist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJuezNomPersona;
        private System.Windows.Forms.Label lblJuezApePersona;
        private System.Windows.Forms.Label lblJuezTipDoc;
        private System.Windows.Forms.Label lblJuezDocumento;
        private System.Windows.Forms.Label lblJuezCalle;
        private System.Windows.Forms.Label lblJuezLocalidad;
        private System.Windows.Forms.Label lblJuezDepartamento;
        private System.Windows.Forms.Label lblJuezAltura;
        private System.Windows.Forms.GroupBox grbJuezDatosPersona;
        private System.Windows.Forms.GroupBox grbJuezPresentismo;
        private System.Windows.Forms.ComboBox cbmJuezIdAsistencia;
        private System.Windows.Forms.Label lblJuezInformacion2;
        private System.Windows.Forms.Button btnJuezConfirmarVoto;
        public System.Windows.Forms.TextBox txtJuezNom;
        public System.Windows.Forms.TextBox txtJuezApe;
        public System.Windows.Forms.TextBox txtJuezTipDoc;
        public System.Windows.Forms.TextBox txtJuezDocumento;
        public System.Windows.Forms.TextBox txtJuezCalle;
        public System.Windows.Forms.TextBox txtJuezLocalidad;
        public System.Windows.Forms.TextBox txtJuezDepartamento;
        public System.Windows.Forms.TextBox txtJuezAltura;
        private System.Windows.Forms.Label lblJuezSalir;
        private System.Windows.Forms.Label lblJuezVotoRecienteResult;
        private System.Windows.Forms.Label lvlJuezInformacion1;
        private System.Windows.Forms.Label lblJuezMensajeSist;
        private System.Windows.Forms.Button btnJuezHabilitarVoto;
        private System.Windows.Forms.GroupBox grbJuezMensajeSist;
        private System.Windows.Forms.Button btnBuscar;
    }
}