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
    public partial class GUIBuscarHistorialClinico : Form
    {
        private FirestoreDb db;
        public GUIBuscarHistorialClinico()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUIBuscarHistorialClinico_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"protectosoa2020hospitalcr-firebase-adminsdk-xbk4c-b0f6c29c36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("protectosoa2020hospitalcr");
        }

        async public void buscar()
        {
            txtNumeroHistorial.Text = "";
            txtNombreDoctor.Text = "";
            txtDocumentoPaciente.Text = "";
            txtCodigoEnfermedad.Text = "";

            int buscado = Convert.ToInt32(txtNumeroHistorialBuscar.Text);

            Object buscado2 = buscado;

            //Object valor;

            //DocumentReference reference = db.Collection("Paciente").Document(buscado);
            //DocumentSnapshot snap = await reference.GetSnapshotAsync();

            Query dato = db.Collection("Historial_Clinico").WhereEqualTo("numero_historia", buscado2);
            QuerySnapshot snap = await dato.GetSnapshotAsync();
            //  DocumentSnapshot pacientes;

            foreach (DocumentSnapshot historiales_clinicos in snap)
            {
                Historial historial = historiales_clinicos.ConvertTo<Historial>();

                txtNumeroHistorial.Text = Convert.ToString(historial.numero_historia);
                txtNombreDoctor.Text = historial.nombre_doctor;
                txtDocumentoPaciente.Text = historial.documento_paciente;
                txtCodigoEnfermedad.Text = Convert.ToString(historial.codigo_enfermedad);
 
                MessageBox.Show("Historial encontrado");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
