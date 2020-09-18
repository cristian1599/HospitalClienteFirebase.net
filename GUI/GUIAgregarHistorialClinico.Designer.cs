namespace ClienteHospitalFirebase.GUI
{
    partial class GUIAgregarHistorialClinico
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCodigoEnfermedad = new System.Windows.Forms.TextBox();
            this.txtDocumentoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroHistorial = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.butListarpacientes = new System.Windows.Forms.Button();
            this.butListarEnfermedades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(287, 161);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCodigoEnfermedad
            // 
            this.txtCodigoEnfermedad.Location = new System.Drawing.Point(163, 118);
            this.txtCodigoEnfermedad.Name = "txtCodigoEnfermedad";
            this.txtCodigoEnfermedad.Size = new System.Drawing.Size(199, 20);
            this.txtCodigoEnfermedad.TabIndex = 32;
            // 
            // txtDocumentoPaciente
            // 
            this.txtDocumentoPaciente.Location = new System.Drawing.Point(163, 82);
            this.txtDocumentoPaciente.Name = "txtDocumentoPaciente";
            this.txtDocumentoPaciente.Size = new System.Drawing.Size(199, 20);
            this.txtDocumentoPaciente.TabIndex = 31;
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Location = new System.Drawing.Point(163, 44);
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(199, 20);
            this.txtNombreDoctor.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Codigo de la Enfermedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Documento del Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre del Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Numero de Historial";
            // 
            // txtNumeroHistorial
            // 
            this.txtNumeroHistorial.Location = new System.Drawing.Point(163, 6);
            this.txtNumeroHistorial.Name = "txtNumeroHistorial";
            this.txtNumeroHistorial.Size = new System.Drawing.Size(199, 20);
            this.txtNumeroHistorial.TabIndex = 25;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(163, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // butListarpacientes
            // 
            this.butListarpacientes.Location = new System.Drawing.Point(367, 82);
            this.butListarpacientes.Margin = new System.Windows.Forms.Padding(2);
            this.butListarpacientes.Name = "butListarpacientes";
            this.butListarpacientes.Size = new System.Drawing.Size(36, 19);
            this.butListarpacientes.TabIndex = 34;
            this.butListarpacientes.Text = "...";
            this.butListarpacientes.UseVisualStyleBackColor = true;
            this.butListarpacientes.Click += new System.EventHandler(this.butListarpacientes_Click);
            // 
            // butListarEnfermedades
            // 
            this.butListarEnfermedades.Location = new System.Drawing.Point(367, 121);
            this.butListarEnfermedades.Margin = new System.Windows.Forms.Padding(2);
            this.butListarEnfermedades.Name = "butListarEnfermedades";
            this.butListarEnfermedades.Size = new System.Drawing.Size(36, 19);
            this.butListarEnfermedades.TabIndex = 35;
            this.butListarEnfermedades.Text = "...";
            this.butListarEnfermedades.UseVisualStyleBackColor = true;
            this.butListarEnfermedades.Click += new System.EventHandler(this.butListarEnfermedades_Click);
            // 
            // GUIAgregarHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 191);
            this.Controls.Add(this.butListarEnfermedades);
            this.Controls.Add(this.butListarpacientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCodigoEnfermedad);
            this.Controls.Add(this.txtDocumentoPaciente);
            this.Controls.Add(this.txtNombreDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroHistorial);
            this.Controls.Add(this.btnAgregar);
            this.Name = "GUIAgregarHistorialClinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Historial Clinico";
            this.Load += new System.EventHandler(this.GUIAgregarHistorialClinico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txtCodigoEnfermedad;
        public System.Windows.Forms.TextBox txtDocumentoPaciente;
        private System.Windows.Forms.TextBox txtNombreDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroHistorial;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button butListarpacientes;
        private System.Windows.Forms.Button butListarEnfermedades;
    }
}