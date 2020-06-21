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
    public partial class FrmEmpleadoEd : Form
    {
        public FrmEmpleadoEd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleadoEd_Load(object sender, EventArgs e)
        {
            SalaryNumericTB.Maximum = int.MaxValue;

        }
    }
}
