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
    public partial class FrmEdCampus : Form
    {
        public Campus campus { get; set; }
        private GCEntities entities = new GCEntities();

        public FrmEdCampus()
        {
            InitializeComponent();
        }

        private void FrmEdCampus_Load(object sender, EventArgs e)
        {
           CmbEstado.SelectedIndex = 0;

            if (campus != null)
            {
                txtID.Text = campus.ID.ToString();
                txtDescripcion.Text = campus.Descripcion;
                CmbEstado.SelectedIndex = Int32.Parse(campus.Estado);
            }
            
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Campus campus2 = entities.Campus.Find(Int32.Parse(txtID.Text));
                campus2.Descripcion = txtDescripcion.Text;
                campus2.Estado = Convert.ToString(CmbEstado.SelectedIndex);
            }
            else
            {
                entities.Campus.Add(new Campus
                {
                    Descripcion = txtDescripcion.Text,                    
                    Estado = CmbEstado.SelectedIndex.ToString()
                });
            }

            entities.SaveChanges();
            MessageBox.Show("Datos guardados con exito");
            this.Close();
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            Campus campus3 = entities.Campus.Find(Int32.Parse(txtID.Text));
            if (campus3 != null)
            {
                entities.Campus.Remove(campus3);
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
