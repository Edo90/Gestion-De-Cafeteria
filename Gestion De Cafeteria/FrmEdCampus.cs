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
    public partial class FrmEdCampus : Form
    {
        private const int INACTIVE = 1;
        private const int ACTIVE = 0;
        public Campu campus;
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();

        public FrmEdCampus()
        {
            InitializeComponent();
        }

        private void FrmEdCampus_Load(object sender, EventArgs e)
        {
            if (campus != null)
            {
                txtID.Text = campus.ID.ToString();
                txtDescripcion.Text = campus.Descripcion;
                CmbEstado.SelectedIndex = campus.Estado == "0" ? INACTIVE : ACTIVE;
            }
            
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {

            campus = new Campu()
            {
                ID = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text),
                Descripcion = txtDescripcion.Text,
                Estado = CmbEstado.SelectedItem.ToString() == "Activo" ? "1" : "0"
            };


            entities.Campus.AddOrUpdate(campus);
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

            Campu campus3 = entities.Campus.Find(Int32.Parse(txtID.Text));
            if (campus3 != null)
            {
                campus3.Estado = "0";
                entities.SaveChanges();
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("El campus seleccionado no existe");
            }
            this.Close();
        }
    }
}
