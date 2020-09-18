namespace ClienteHospitalFirebase.GUI
{
    partial class GUIListarPacientePorParametro
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
            this.butListar = new System.Windows.Forms.Button();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.Label();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // butListar
            // 
            this.butListar.Location = new System.Drawing.Point(256, 5);
            this.butListar.Margin = new System.Windows.Forms.Padding(2);
            this.butListar.Name = "butListar";
            this.butListar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butListar.Size = new System.Drawing.Size(60, 30);
            this.butListar.TabIndex = 11;
            this.butListar.Text = "Listar";
            this.butListar.UseVisualStyleBackColor = true;
            this.butListar.Click += new System.EventHandler(this.butListar_Click);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(104, 11);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(111, 20);
            this.txtNombrePaciente.TabIndex = 10;
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Location = new System.Drawing.Point(11, 14);
            this.Genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(48, 13);
            this.Genero.TabIndex = 9;
            this.Genero.Text = "Genero :";
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(2, 52);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 51;
            this.grilla.Size = new System.Drawing.Size(504, 241);
            this.grilla.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(63, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUIListarPacientePorParametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butListar);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.grilla);
            this.Name = "GUIListarPacientePorParametro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Pacientes por Parametro";
            this.Load += new System.EventHandler(this.GUIListarPacientePorParametro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butListar;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button button1;
    }
}