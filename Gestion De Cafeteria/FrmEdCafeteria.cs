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
    public partial class FrmEdCafeteria : Form
    {
        public Cafeteria cafeteria { get; set; }
        private GCEntities entities = new GCEntities();
        public FrmEdCafeteria()
        {
            InitializeComponent();
        }

        private void FrmEdCafeteria_Load(object sender, EventArgs e)
        {            

            if (cafeteria != null)
            {
                txtID.Text = cafeteria.ID.ToString();
                txtDescripcion.Text = cafeteria.Descripcion;
                CmbCampus.SelectedValue = cafeteria.ID_Campus;
                CmbEncargado.SelectedValue = cafeteria.Encargado;
                CmbEstado.SelectedValue = Int32.Parse(cafeteria.Estado);
            }            
        }
        public void llenarCombox()
        {
            var campus = entities.Campus.ToList();
            if (campus.Count > 0)
            {
                CmbCampus.DataSource = campus;
                CmbCampus.DisplayMember = "Descripcion";
                CmbCampus.ValueMember = "ID";
            }

            var encargado = entities.Empleado.ToList();
            if (encargado.Count > 0)
            {
                CmbEncargado.DataSource = encargado;
                CmbEncargado.DisplayMember = "Nombre";
                CmbEncargado.ValueMember = "IdEMpleado";
            }

        }
        private void CmdGuardar_Click(object sender, EventArgs e)
        {           
            if (txtID.Text != "")
            {
                Cafeteria cafeteria2 = entities.Cafeteria.Find(Int32.Parse(txtID.Text));
                cafeteria2.Descripcion = txtDescripcion.Text;
                cafeteria2.ID_Campus = Convert.ToInt32(CmbCampus.SelectedValue);
                cafeteria2.Encargado = Convert.ToInt32(CmbEncargado.SelectedValue);
                cafeteria2.Estado = Convert.ToString(CmbEstado.SelectedValue);
            }
            else
            {
                entities.Cafeteria.Add(new Cafeteria
                {                    
                    Descripcion = txtDescripcion.Text,
                    ID_Campus = Int32.Parse(CmbCampus.SelectedValue.ToString()),
                    Encargado = Int32.Parse(CmbEncargado.SelectedValue.ToString()),
                    Estado = CmbEstado.SelectedIndex.ToString()
                });
            }


            entities.SaveChanges();
            MessageBox.Show("Datos guardados con exito");
            this.Close();
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            Cafeteria cafeteria3 = entities.Cafeteria.Find(Int32.Parse(txtID.Text));
            if (cafeteria3 != null)
            {
                entities.Cafeteria.Remove(cafeteria3);
                entities.SaveChanges();
                MessageBox.Show("Empleado eliminado con exito");
            }
            else { 
                MessageBox.Show("Empleado no existe");
        }
            this.Close();
        }
    }
}
