using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteHospitalFirebase;
using Google.Cloud.Firestore;

namespace ClienteHospitalSWNet.gui
{
    public partial class GUIModificarPaciente : Form
    {
        private FirestoreDb db;
        public GUIModificarPaciente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void GUIModificarPaciente_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"protectosoa2020hospitalcr-firebase-adminsdk-xbk4c-b0f6c29c36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("protectosoa2020hospitalcr");
        }

       async public void buscar()
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtGenero.Text = "";

            String buscado = txtDocumentoBuscar.Text;
            Object valor;
           // DocumentReference reference = db.Collection("Paciente").Document(buscado);
            //DocumentSnapshot snap = await reference.GetSnapshotAsync();
            Query dato = db.Collection("Paciente").WhereEqualTo("documento", buscado);
            QuerySnapshot snap = await dato.GetSnapshotAsync();
            //  DocumentSnapshot pacientes;

            foreach (DocumentSnapshot pacientes in snap)
            {
                Paciente paciente = pacientes.ConvertTo<Paciente>();
                txtDocumento.Text = paciente.documento;
                txtNombre.Text = paciente.nombre;
                txtCorreo.Text = paciente.correo;
                txtTelefono.Text = paciente.telefono;
                txtGenero.Text = paciente.genero;

                MessageBox.Show("Paciente encontrado");
            }
        }
        public async Task modificarAsync()
        {
            String documentoBuscar = txtDocumentoBuscar.Text;



            //Query dato1 = db.Collection("Paciente").WhereEqualTo("documento", documentoBuscar);
            DocumentReference reference = db.Collection("Paciente").Document(documentoBuscar);
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                {"documento", txtDocumento.Text},
                {"nombre", txtNombre.Text},
                {"correo", txtCorreo.Text},
                {"telefono", txtTelefono.Text},
                {"genero", txtGenero.Text},

            };

            DocumentSnapshot snap = await reference.GetSnapshotAsync();

            MessageBox.Show("Paciente modificado");

            if (snap.Exists)
            {
                await reference.SetAsync(data1);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarAsync();
        }

        
    }
}
