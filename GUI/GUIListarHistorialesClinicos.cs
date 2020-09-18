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
    public partial class GUIListarHistorialesClinicos : Form
    {
        private FirestoreDb db;
        public GUIListarHistorialesClinicos()
        {
            InitializeComponent();
        }

        private void GUIListarHistorialesClinicos_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"protectosoa2020hospitalcr-firebase-adminsdk-xbk4c-b0f6c29c36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("protectosoa2020hospitalcr");
        }

        async public void listar()
        {

            DataTable dt = new DataTable();
            DataRow dr;


            int numero_historia = 0;
            int codigo_enfermedad = 0;
            String nombre_doctor = "";
            String documento_paciente = "";
 

            dt.Columns.Add(new DataColumn("Numero Historia"));
            dt.Columns.Add(new DataColumn("Nombre Doctor"));
            dt.Columns.Add(new DataColumn("Documento Paciente"));
            dt.Columns.Add(new DataColumn("Codigo Enfermedad"));



            // DocumentReference docRef = db.Collection("Paciente")
            Query dato = db.Collection("Historial_Clinico");
            QuerySnapshot snap = await dato.GetSnapshotAsync();


            // pacientes =(paciente[])servicio.listar();
            if (snap.ToArray().Length == 0)
            {
                MessageBox.Show("No hay historiales por mostrar");
                return;
            }
            foreach (DocumentSnapshot historiales in snap)
            {
                Historial historial = historiales.ConvertTo<Historial>();

                if (historiales.Exists)
                {
 
                    numero_historia = historial.numero_historia;
                    nombre_doctor = historial.nombre_doctor;
                    documento_paciente = historial.documento_paciente;
                    codigo_enfermedad = historial.codigo_enfermedad;
                    dr = dt.NewRow();
                    dr["Numero Historia"] = numero_historia;
                    dr["Nombre Doctor"] = nombre_doctor;
                    dr["Documento Paciente"] = documento_paciente;
                    dr["Codigo Enfermedad"] = codigo_enfermedad;

                    dt.Rows.Add(dr);
                }
            }

            grilla.DataSource = dt;
        }

            public void limpiar()
        {
            DataTable dt = (DataTable)grilla.DataSource;
            dt.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
