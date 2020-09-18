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

namespace ClienteHospitalFirebase.GUI
{
    public partial class GUIListarEnfermedades : Form
    {
        private FirestoreDb db;
        GUIAgregarHistorialClinico padre;
        public GUIListarEnfermedades(GUIAgregarHistorialClinico pPadre)
        {
            padre = pPadre;
            InitializeComponent();
        }

        private void ListarEnfermedades_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"protectosoa2020hospitalcr-firebase-adminsdk-xbk4c-b0f6c29c36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("protectosoa2020hospitalcr");
        }

        async public void listar()
        {

            DataTable dt = new DataTable();
            DataRow dr;


            int Codigo = 0;
          
            String Nombre = "";
            String Tipo = "";


            dt.Columns.Add(new DataColumn("Codigo Enfermedad"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Tipo"));
           



            // DocumentReference docRef = db.Collection("Paciente")
            Query dato = db.Collection("Enfermedad");
            QuerySnapshot snap = await dato.GetSnapshotAsync();


            // pacientes =(paciente[])servicio.listar();
            if (snap.ToArray().Length == 0)
            {
                MessageBox.Show("No hay enfermedades por mostrar");
                return;
            }
            foreach (DocumentSnapshot enfermedades in snap)
            {
                
                Enfermedad enfermedad = enfermedades.ConvertTo<Enfermedad>();
                if (enfermedades.Exists)
                {

                    Codigo = enfermedad.Codigo;
                    Nombre = enfermedad.Nombre;
                    Tipo = enfermedad.Tipo;
                   
                    dr = dt.NewRow();
                    dr["Codigo Enfermedad"] = Codigo;
                    dr["Nombre"] = Nombre;
                    dr["Tipo"] = Tipo;
                    

                    dt.Rows.Add(dr);
                }
            }

            grilla.DataSource = dt;
        }

        private void butListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void ListarEnfermedades_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void grilla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String dato = grilla.CurrentRow.Cells[0].Value.ToString();
            padre.txtCodigoEnfermedad.Text = dato;
            this.Dispose();
        }
    }
}
