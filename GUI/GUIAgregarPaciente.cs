using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace ClienteHospitalSWNet.gui
{
    public partial class GUIAgregarPaciente : Form
    {
        private FirestoreDb db; 
        public GUIAgregarPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void GUIAgregarPaciente_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"protectosoa2020hospitalcr-firebase-adminsdk-xbk4c-b0f6c29c36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("protectosoa2020hospitalcr");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String genero;
            if (radioButMasculino.Checked)
            {
                genero = radioButMasculino.Text;
            }
            else
            {
                genero = radioButFemenino.Text;
            }
            //String path = AppDomain.CurrentDomain.BaseDirectory + @"cloudfire.json";
            // Environment.SetEnvironmentVariable("GOOGLE_APLICATION_CREDENTIALS", path);
            //database = FirestoreDb.

            String documento = txtDocumento.Text;
            DocumentReference doc = db.Collection("Paciente").Document(documento);
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {

                {"documento", txtDocumento.Text},
                {"nombre", txtNombre.Text},
                {"correo", txtCorreo.Text},
                {"telefono", txtTelefono.Text},
                {"genero", genero},

            };
            doc.SetAsync(data1);
            MessageBox.Show("Paciente adicionado");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
