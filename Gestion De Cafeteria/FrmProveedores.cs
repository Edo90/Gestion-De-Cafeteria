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
    public partial class FrmProveedores : Form
    {
        public Proveedore proveedor { get; set; }
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            ConsultarProveedores();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmProveedoresEd fpe = new FrmProveedoresEd();
            fpe.ShowDialog();
        }

        private void FrmProveedores_Activated(object sender, EventArgs e)
        {
            ConsultarProveedores();
        }

        private void DgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgvProveedores.SelectedRows[0];
            Proveedore proveedor = new Proveedore();
            proveedor.IdProveedor = Int32.Parse(row.Cells[0].Value.ToString());
            proveedor.NombreComercial = row.Cells[1].Value.ToString();
            proveedor.RNC = row.Cells[2].Value.ToString();
            proveedor.FechaRegistro = DateTime.Parse(row.Cells[3].Value.ToString());
            proveedor.Estado = row.Cells[4].Value.ToString();
            FrmProveedoresEd fpe = new FrmProveedoresEd();
            fpe.proveedor = proveedor;
            fpe.ShowDialog();
        }

        private void ConsultarProveedores()
        {
            DgvProveedores.DataSource = entities.Proveedores.ToList();
        }

        private void ConsultarPorCriterio()
        {
            var proveedores = from em in entities.Proveedores
                              where (em.IdProveedor.ToString().StartsWith(TxtDatoABuscar.Text) ||
                            em.NombreComercial.StartsWith(TxtDatoABuscar.Text) ||
                            em.RNC.StartsWith(TxtDatoABuscar.Text) ||
                            em.FechaRegistro.ToString().StartsWith(TxtDatoABuscar.Text) ||
                            em.Estado.ToString().StartsWith(TxtDatoABuscar.Text)
                            )
                              select em;
            DgvProveedores.DataSource = proveedores.ToList();
        }
    }
}
