namespace ClienteHospitalFirebase.GUI
{
    partial class GUIBuscarHistorialClinico
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroHistorialBuscar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCodigoEnfermedad = new System.Windows.Forms.TextBox();
            this.txtDocumentoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroHistorial = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Numero de Historial";
            // 
            // txtNumeroHistorialBuscar
            // 
            this.txtNumeroHistorialBuscar.Location = new System.Drawing.Point(164, 12);
            this.txtNumeroHistorialBuscar.Name = "txtNumeroHistorialBuscar";
            this.txtNumeroHistorialBuscar.Size = new System.Drawing.Size(199, 20);
            this.txtNumeroHistorialBuscar.TabIndex = 48;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(290, 240);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCodigoEnfermedad
            // 
            this.txtCodigoEnfermedad.Enabled = false;
            this.txtCodigoEnfermedad.Location = new System.Drawing.Point(165, 200);
            this.txtCodigoEnfermedad.Name = "txtCodigoEnfermedad";
            this.txtCodigoEnfermedad.Size = new System.Drawing.Size(199, 20);
            this.txtCodigoEnfermedad.TabIndex = 46;
            // 
            // txtDocumentoPaciente
            // 
            this.txtDocumentoPaciente.Enabled = false;
            this.txtDocumentoPaciente.Location = new System.Drawing.Point(165, 163);
            this.txtDocumentoPaciente.Name = "txtDocumentoPaciente";
            this.txtDocumentoPaciente.Size = new System.Drawing.Size(199, 20);
            this.txtDocumentoPaciente.TabIndex = 45;
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Enabled = false;
            this.txtNombreDoctor.Location = new System.Drawing.Point(165, 125);
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(199, 20);
            this.txtNombreDoctor.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Codigo de la Enfermedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Documento del Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre del Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Numero de Historial";
            // 
            // txtNumeroHistorial
            // 
            this.txtNumeroHistorial.Enabled = false;
            this.txtNumeroHistorial.Location = new System.Drawing.Point(165, 88);
            this.txtNumeroHistorial.Name = "txtNumeroHistorial";
            this.txtNumeroHistorial.Size = new System.Drawing.Size(199, 20);
            this.txtNumeroHistorial.TabIndex = 39;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(288, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GUIBuscarHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 276);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroHistorialBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCodigoEnfermedad);
            this.Controls.Add(this.txtDocumentoPaciente);
            this.Controls.Add(this.txtNombreDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroHistorial);
            this.Controls.Add(this.btnBuscar);
            this.Name = "GUIBuscarHistorialClinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Historial Clinico";
            this.Load += new System.EventHandler(this.GUIBuscarHistorialClinico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroHistorialBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCodigoEnfermedad;
        private System.Windows.Forms.TextBox txtDocumentoPaciente;
        private System.Windows.Forms.TextBox txtNombreDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroHistorial;
        private System.Windows.Forms.Button btnBuscar;
    }
}