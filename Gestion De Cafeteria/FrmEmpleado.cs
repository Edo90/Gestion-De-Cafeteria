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
            var empleados = from empleado in entity.Empleadoes
                            where()
        }
    }
}
