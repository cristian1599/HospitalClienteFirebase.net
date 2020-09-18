using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteHospitalFirebase.GUI
{
    public partial class GUIAgregarHistorialClinico : Form
    {
        private FirestoreDb db;
        public GUIAgregarHistorialClinico()
        {
            InitializeComponent();
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            String strnumeroH = txtNumeroHistorial.Text;
            int numeroH = Convert.ToInt32(strnumeroH.Trim());
            int codigoEnfermedad = Convert.ToInt32(txtCodigoEnfermedad.Text);
            DocumentReference doc = db.Collection("Historial_Clinico").Document(strnumeroH);
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {

                {"numero_historia", numeroH},
                {"nombre_doctor", txtNombreDoctor.Text},
                {"documento_paciente", txtDocumentoPaciente.Text},
                {"codigo_enfermedad", codigoEnfermedad},


            };
            doc.SetAsync(data1);
            MessageBox.Show("Historial clinico adicionado");

            /*int numeroHistorial, codigoEnfermedad;
            String nombreDoctor, documentoPaciente, strNumeroHistorial, strCodigoEnfermedad;

            strNumeroHistorial = txtNumeroHistorial.Text;
            numeroHistorial = Convert.ToInt32(strNumeroHistorial.Trim());
            nombreDoctor = txtNombreDoctor.Text;
            documentoPaciente = txtDocumentoPaciente.Text;
            strCodigoEnfermedad = txtCodigoEnfermedad.Text;
            codigoEnfermedad = Convert.ToInt32(strCodigoEnfermedad.Trim());
 
            DocumentReference docRef = db.Collection("Historial_Clinico").Document(strNumeroHistorial);
            Dictionary<string, object> city = new Dictionary<string, object>()
            {

                {"numero historia", numeroHistorial},
                {"nombre doctor", nombreDoctor},
                {"documento paciente", documentoPaciente},
                {"codigo enfermedad", codigoEnfermedad},
            };

            docRef.SetAsync(city);
            MessageBox.Show("Historial adicionado");
            */
        }

        private void GUIAgregarHistorialClinico_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"protectosoa2020hospitalcr-firebase-adminsdk-xbk4c-b0f6c29c36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("protectosoa2020hospitalcr");
        }

        private void butListarpacientes_Click(object sender, EventArgs e)
        {
             GUIListarPacientesParaHistorial guiListarP = new GUIListarPacientesParaHistorial(this);
            // guiListarP.listar();
             guiListarP.ShowDialog();
           
            
        }

        private void butListarEnfermedades_Click(object sender, EventArgs e)
        {
            GUIListarEnfermedades guiListarE = new GUIListarEnfermedades(this);
           // guiListarE.listar();
            guiListarE.ShowDialog();
        }
    }
}
