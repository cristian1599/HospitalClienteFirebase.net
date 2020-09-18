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
    public partial class GUIBuscarPaciente : Form
    {
        private FirestoreDb db;
        public GUIBuscarPaciente()
        {
            InitializeComponent();
        }

       
        async public void buscar()
        {
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
            }



        }

        public async Task buscarAsync()
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void GUIBuscarPaciente_Load_1(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"protectosoa2020hospitalcr-firebase-adminsdk-xbk4c-b0f6c29c36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("protectosoa2020hospitalcr");
        }
    }
}
