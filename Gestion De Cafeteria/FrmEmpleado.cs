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
    public partial class FrmEmpleado : Form
    {
        GestionCafeteriaEntities entity = new GestionCafeteriaEntities();
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCafeteriaDataSet.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.gestionCafeteriaDataSet.Empleado);

        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            var frmEmpleadoEd = new FrmEmpleadoEd();
            frmEmpleadoEd.Show();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados();
        }

        private void ConsultarEmpleados()
        {
            var empleados = from empleado in entity.Empleadoes
                            where (empleado.IdEMpleado.ToString().StartsWith(txtBuscarPor.Text) ||
                            empleado.Nombre.StartsWith(txtBuscarPor.Text) ||
                            empleado.Salario.ToString().StartsWith(txtBuscarPor.Text) ||
                            empleado.Direccion.StartsWith(txtBuscarPor.Text))
                            select empleado;

            empleadoGridView.DataSource = empleados.ToList();
        }

        private void empleadoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var frmEmpleadoEd = new FrmEmpleadoEd();
            frmEmpleadoEd.Show();
        }
    }
}
