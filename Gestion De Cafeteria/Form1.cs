using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Cafeteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cafeteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Cafeteria = new FrmCafeteria();
            Cafeteria.Show();
            teamGroupBox.Visible = false;
        }

        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TipoDeUsuarios = new FrmTipoUsuario();
            TipoDeUsuarios.Show();
            teamGroupBox.Visible = false;
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmUsuario = new FrmUsuarios();
            FrmUsuario.Show();
            teamGroupBox.Visible = false;
        }

        private void campusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCampus = new FrmCampus();
            frmCampus.Show();
            teamGroupBox.Visible = false;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEmpleado = new FrmEmpleado();
            frmEmpleado.Show();
            teamGroupBox.Visible = false;
        }

        private void acercaDelEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teamGroupBox.Visible = true;
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmArticulos = new ArticulosForm();
            frmArticulos.Show();
            teamGroupBox.Visible = false;
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMarcas = new FrmMarcas();
            frmMarcas.Show();
            teamGroupBox.Visible = false;
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProveedores = new FrmProveedores();
            frmProveedores.Show();
            teamGroupBox.Visible = false;
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmFacturacion = new FacturacionDeArticulosForm();
            frmFacturacion.Show();
            teamGroupBox.Visible = false;
        }
    }
}
