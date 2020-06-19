using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Gestion_De_Cafeteria
{
    public partial class FrmMarcasEd : Form
    {
        public Marca marca { get; set; }
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmMarcasEd()
        {
            InitializeComponent();
        }

        private void FrmMarcasEd_Load(object sender, EventArgs e)
        {
            CbxEstado.SelectedIndex = 0;
            if (marca != null)
            {
                TxtIdMarca.Text = marca.IdMarca.ToString();
                TxtDescripcion.Text = marca.Descripcion;
                if (marca.Estado == "Inactivo")
                {
                    CbxEstado.SelectedIndex = 1;
                }
            }
        }

        private void CmdGuadar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtIdMarca.Text != "")
                {
                    Marca marca = entities.Marcas.Find(Int32.Parse(TxtIdMarca.Text));
                    marca.Descripcion = TxtDescripcion.Text;
                    marca.Estado = CbxEstado.Text;
                    entities.Entry<Marca>(marca).State = EntityState.Modified;
                    entities.SaveChanges();
                    entities.Entry<Marca>(marca).Reload();
                }
                else
                {
                    entities.Marcas.Add(new Marca
                    {
                        Descripcion = TxtDescripcion.Text,
                        Estado = CbxEstado.Text
                    });
                    entities.SaveChanges();
                }
                MessageBox.Show("Datos guardados con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un campo de los ingresados es invalido " + ex.Message);
            }
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Marca marca = entities.Marcas.Find(Int32.Parse(TxtIdMarca.Text));
            if (marca != null)
            {
                entities.Marcas.Remove(marca);
                entities.SaveChanges();
                MessageBox.Show("Marca eliminada con exito");
            }
            else
            {
                MessageBox.Show("Marca no existe");
            }
            this.Close();
        }
    }
}
