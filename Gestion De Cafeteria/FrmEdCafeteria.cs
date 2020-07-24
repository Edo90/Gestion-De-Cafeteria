using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Cafeteria
{
    public partial class FrmEdCafeteria : Form
    {
        public Cafeteria cafeteria;
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmEdCafeteria()
        {
            InitializeComponent();
        }

        private void FrmEdCafeteria_Load(object sender, EventArgs e)
        {
            CmbEstado.SelectedIndex = 0;

            if (cafeteria != null)
            {
                txtID.Text = cafeteria.ID.ToString();
                txtDescripcion.Text = cafeteria.Descripcion;
                CmbCampus.SelectedValue = cafeteria.ID_Campus;
                CmbEncargado.SelectedValue = cafeteria.Encargado;
                CmbEstado.SelectedIndex = Int32.Parse(cafeteria.Estado);
            }

        }
        public void llenarCombox()
        {
            var campus = entities.Campus.Where(x =>x.Estado == "1").ToList();
            if (campus.Count > 0)
            {
                CmbCampus.DataSource = campus;
                CmbCampus.DisplayMember = "Descripcion";
                CmbCampus.ValueMember = "ID";
            }

            var encargado = entities.Empleadoes.Where(x => x.Estado == true).ToList();
            if (encargado.Count > 0)
            {
                CmbEncargado.DataSource = encargado;
                CmbEncargado.DisplayMember = "Nombre";
                CmbEncargado.ValueMember = "IdEMpleado";
            }

        }
        private void CmdGuardar_Click(object sender, EventArgs e)
        {

            cafeteria = new Cafeteria()
            {
                ID = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text),
                Descripcion = txtDescripcion.Text,
                ID_Campus = int.Parse(CmbCampus.SelectedValue.ToString()),
                Encargado = int.Parse(CmbEncargado.SelectedValue.ToString()),
                Estado = CmbEstado.SelectedText.ToString() == "Activo" ? "1" : "0"
            };

            entities.Cafeterias.AddOrUpdate(cafeteria);
            entities.SaveChanges();

            MessageBox.Show("Datos guardados con exito");
            this.Close();
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Cafeteria cafeteria3 = entities.Cafeterias.Find(Int32.Parse(txtID.Text));
            if (cafeteria3 != null)
            {
                entities.Cafeterias.Remove(cafeteria3);
                entities.SaveChanges();
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("La cafeteria no existe");
            }
            this.Close();
        }
    }
}
