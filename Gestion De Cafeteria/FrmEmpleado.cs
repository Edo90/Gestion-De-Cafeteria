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

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'gestionCafeteriaDataSet.Empleado' table. You can move, or remove it, as needed.
            //this.empleadoTableAdapter.Fill(this.gestionCafeteriaDataSet.Empleado);
            ConsultarEmpleados();

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
                            empleado.Direccion.StartsWith(txtBuscarPor.Text) ||
                            empleado.Tanda_labor.StartsWith(txtBuscarPor.Text) ||
                            empleado.Porciento_Comision.Value.ToString().StartsWith(txtBuscarPor.Text)
                            )
                            select empleado;

            empleadoGridView.DataSource = empleados.ToList();
        }

        private void empleadoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = empleadoGridView.SelectedRows[0];
            var empleado = new Empleado()
            {
                IdEMpleado = (int)selectedRow.Cells[0].Value,
                Nombre = selectedRow.Cells[1].Value.ToString(),
                Direccion = selectedRow.Cells[2].Value.ToString(),
                Salario = (decimal)selectedRow.Cells[3].Value,
                Cedula = selectedRow.Cells[4].Value.ToString(),
                Tanda_labor = selectedRow.Cells[5].Value.ToString(),
                Porciento_Comision = int.Parse(selectedRow.Cells[6].Value.ToString()),
                Fecha_Ingreso = DateTime.Parse(selectedRow.Cells[7].Value.ToString()),
                Estado = (bool)selectedRow.Cells[8].Value
            };


            var frmEmpleadoEd = new FrmEmpleadoEd(empleado);
            frmEmpleadoEd.Show();

        }

    }
}
