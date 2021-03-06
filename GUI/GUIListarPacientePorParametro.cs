﻿using Google.Cloud.Firestore;
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
    public partial class GUIListarPacientePorParametro : Form
    {
        private FirestoreDb db;
        public GUIListarPacientePorParametro()
        {
            InitializeComponent();
        }

        private void butListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void GUIListarPacientePorParametro_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"protectosoa2020hospitalcr-firebase-adminsdk-xbk4c-b0f6c29c36.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("protectosoa2020hospitalcr");
        }
        async public void listar()
        {

            String nombreParametro;

            DataTable dt = new DataTable();
            DataRow dr;

            nombreParametro = txtNombrePaciente.Text;

            Object valor;
            String documento = "";
            String nombre = "";
            String correo = "";
            String telefono = "";
            String genero = "";
 
            

            dt.Columns.Add(new DataColumn("Documento"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Correo"));
            dt.Columns.Add(new DataColumn("Telefono"));
            dt.Columns.Add(new DataColumn("Genero"));


            // DocumentReference docRef = db.Collection("Paciente")
            Query dato = db.Collection("Paciente").WhereEqualTo("genero", nombreParametro);
            QuerySnapshot snap = await dato.GetSnapshotAsync();


            // pacientes =(paciente[])servicio.listar();
            if (snap.ToArray().Length == 0)
            {
                MessageBox.Show("No hay pacientes para mostrar");
                return;
            }
            foreach (DocumentSnapshot pacientes in snap)
            {
                Paciente paciente = pacientes.ConvertTo<Paciente>();

                if (pacientes.Exists)
                {
                    documento = paciente.documento;
                    nombre = paciente.nombre;
                    correo = paciente.correo;
                    telefono = paciente.telefono;
                    genero = paciente.genero;
                    dr = dt.NewRow();
                    dr["Documento"] = documento;
                    dr["Nombre"] = nombre;
                    dr["Correo"] = correo;
                    dr["Telefono"] = telefono;
                    dr["Genero"] = genero;

                    dt.Rows.Add(dr);
                }
            }

            grilla.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
