namespace ClienteHospitalFirebase.GUI
{
    partial class GUIListarEnfermedades
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
            this.grilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // butListar
            // 
            this.butListar.Location = new System.Drawing.Point(235, 300);
            this.butListar.Name = "butListar";
            this.butListar.Size = new System.Drawing.Size(75, 23);
            this.butListar.TabIndex = 8;
            this.butListar.Text = "Listar";
            this.butListar.UseVisualStyleBackColor = true;
            this.butListar.Click += new System.EventHandler(this.butListar_Click);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(9, -17);
            this.grilla.Margin = new System.Windows.Forms.Padding(4);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 51;
            this.grilla.Size = new System.Drawing.Size(518, 310);
            this.grilla.TabIndex = 7;
            this.grilla.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grilla_CellMouseClick);
            // 
            // ListarEnfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 326);
            this.Controls.Add(this.butListar);
            this.Controls.Add(this.grilla);
            this.Name = "ListarEnfermedades";
            this.Text = "ListarEnfermedades";
            this.Load += new System.EventHandler(this.ListarEnfermedades_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListarEnfermedades_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butListar;
        private System.Windows.Forms.DataGridView grilla;
    }
}