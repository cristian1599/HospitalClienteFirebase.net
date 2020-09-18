using ClienteHospitalFirebase;
using ClienteHospitalFirebase.GUI;
using ClienteHospitalSWNet.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteHospitalFirebase
{
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private void agregarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarPaciente gui = new GUIAgregarPaciente();
            gui.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void modificarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIModificarPaciente gui = new GUIModificarPaciente();
            gui.Show();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           GUIBuscarPaciente  gui = new GUIBuscarPaciente();
           gui.Show();
        }

        private void eliminarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIEliminarPaciente gui = new GUIEliminarPaciente();
            gui.Show();
        }

        private void historialClinicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarHistorialClinicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarHistorialClinico gui = new GUIAgregarHistorialClinico();
            gui.Show();
        }

        private void buscarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscarHistorialClinico gui = new GUIBuscarHistorialClinico();
            gui.Show();
        }

        private void listarHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListarHistorialesClinicos gui = new GUIListarHistorialesClinicos();
            gui.Show();
        }

        private void listarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListarPacientes gui = new GUIListarPacientes();
            gui.Show();
        }

        private void modificarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIModificarHistorialesClinicos gui = new GUIModificarHistorialesClinicos();
            gui.Show();
        }

        private void eliminarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar_Historial gui = new Eliminar_Historial();
            gui.Show();
         }

        private void listarPorParametroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListarHistorialesPorParametro gui = new GUIListarHistorialesPorParametro();
            gui.Show();
        }

        private void listarPacientesPorParametroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListarPacientePorParametro gui = new GUIListarPacientePorParametro();
            gui.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-------Proyecto realizado por Cristian Silva y Steven Rodriguez------- Estudiantes de Ingenieria de Sistemas en la Universidad de Ibague");

        }
    }
}
