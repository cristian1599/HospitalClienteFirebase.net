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
    public partial class GUIModificarHistorialesClinicos : Form
    {
        private FirestoreDb db;
        public GUIModificarHistorialesClinicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificarAsync();
        }
        public async Task modificarAsync()
        {
            int buscado = Convert.ToInt32(txtNumeroHistorialBuscar.Text);
            String strnumeroH = txtNumeroHistorial.Text;
            int numeroH = Convert.ToInt32(strnumeroH.Trim());
            int codigoEnfermedad = Convert.ToInt32(txtCodigoEnfermedad.Text);

            //Query dato1 = db.Collection("Paciente").WhereEqualTo("documento", documentoBuscar);
            DocumentReference reference = db.Collection("Historial_Clinico").Document(Convert.ToString(buscado));
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                {"numero_historia", numeroH},
                {"nombre_doctor", txtNombreDoctor.Text},
                {"documento_paciente", txtDocumentoPaciente.Text},
                {"codigo_enfermedad", codigoEnfermedad},
            };

            DocumentSnapshot snap = await reference.GetSnapshotAsync();

            MessageBox.Show("Historial modificado");

            if (snap.Exists)
            {
                await reference.SetAsync(data1);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void GUIModificarHistorialesClinicos_Load(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
