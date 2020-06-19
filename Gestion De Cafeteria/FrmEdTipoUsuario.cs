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
    public partial class FrmEdTipoUsuario : Form
    {
        public Tipo_Usuario tipoUsuario { get; set; }
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmEdTipoUsuario()
        {
            InitializeComponent();
        }

        private void FrmEdTipoUsuario_Load(object sender, EventArgs e)
        {
            CmbEstado.SelectedIndex = 0;

            if (tipoUsuario != null)
            {
                txtID.Text = tipoUsuario.ID.ToString();
                txtDescripcion.Text = tipoUsuario.Descripcion;
                CmbEstado.SelectedIndex = Int32.Parse(tipoUsuario.Estado);
            }
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Tipo_Usuario tipoUsu = entities.Tipo_Usuario.Find(Int32.Parse(txtID.Text));
                tipoUsu.Descripcion = txtDescripcion.Text;
                tipoUsu.Estado = Convert.ToString(CmbEstado.SelectedIndex);
            }
            else
            {
                entities.Tipo_Usuario.Add(new Tipo_Usuario
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
            if (MessageBox.Show("Seguro de eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Tipo_Usuario tipoUsuar = entities.Tipo_Usuario.Find(Int32.Parse(txtID.Text));
            if (tipoUsuar != null)
            {
                entities.Tipo_Usuario.Remove(tipoUsuar);
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
