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
    public partial class FrmEmpleadoEd : Form
    {
        private Empleado empleado;
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmEmpleadoEd()
        {
            InitializeComponent();
        }

        public FrmEmpleadoEd(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        

        private void FrmEmpleadoEd_Load(object sender, EventArgs e)
        {
            salaryNumericTB.Maximum = int.MaxValue;
            if(empleado != null)
            {
                txtID.Text = empleado.IdEMpleado.ToString();
                txtNombre.Text = empleado.Nombre.Split()[0];
                txtApellido.Text = empleado.Nombre.Split()[1] ?? "";
                txtDireccion.Text = empleado.Direccion;
                salaryNumericTB.Value = empleado.Salario;
            }

        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (!FieldsAreValid())
                return;
            empleado = new Empleado()
            {
                IdEMpleado = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text),
                Nombre = $"{txtNombre.Text.ToUpperInvariant()} {txtApellido.Text.ToUpperInvariant()}",
                Direccion = txtDireccion.Text,
                Salario = salaryNumericTB.Value
            };

            if (empleado != null)
                entities.Empleadoes.AddOrUpdate(empleado);

            entities.SaveChanges();
            this.Dispose();
        }

        private bool FieldsAreValid()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show($"Los campos Nombre y Apellido son requeridos", "Campos requeridos");
                return false;
            }
            if (salaryNumericTB.Value == 0)
            {
                MessageBox.Show($"Salario debe ser mayor que 0", "Requerido");
                return false;
            }
            return true;
        }
    }
}
