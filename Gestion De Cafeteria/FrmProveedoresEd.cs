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
    public partial class FrmProveedoresEd : Form
    {
        public Proveedores proveedor { get; set; }
        private Entities entities = new Entities();
        public FrmProveedoresEd()
        {
            InitializeComponent();
        }

        private void FrmProveedoresEd_Load(object sender, EventArgs e)
        {
            CbxEstado.SelectedIndex = 0;
            if (proveedor != null)
            {
                TxtIdProveedor.Text = proveedor.IdEmpleado.ToString();
                TxtNombreComercial.Text = proveedor.NombreComercial;
                TxtRNC.Text = proveedor.RNC.ToString();
                TxtFechaRegistro.Text = proveedor.FechaRegistro.ToString();
                if (proveedor.Estado == "Inactivo")
                {
                    CbxEstado.SelectedIndex = 1;
                }
            }
        }

        private void CmdGuadar_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = entities.Proveedores.Find(Int32.Parse(TxtIdProveedor.Text));

            if (proveedor != null)
            {
                proveedor.NombreComercial = TxtNombreComercial.Text;
                proveedor.RNC = TxtRNC.Text;
                proveedor.FechaRegistro = TxtFechaRegistro.Text;
                proveedor.Estado = CbxEstado.Text;
            }
            else
            {
                entities.Proveedores.Add(new Proveedores
                {
                    NombreComercial = TxtNombreComercial.Text,
                    RNC = TxtRNC.Text,
                    FechaRegistro = TxtFechaRegistro.Text,
                    Estado = CbxEstado.Text
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

            Proveedores proveedor = entities.Proveedores.Find(Int32.Parse(TxtIdProveedor.Text));
            if (proveedor != null)
            {
                entities.Proveedores.Remove(proveedor);
                entities.SaveChanges();
                MessageBox.Show("Empleado eliminado con exito");
            }
            else
            {
                MessageBox.Show("Empleado no existe");
            }
            this.Close();
        }
    }
}
