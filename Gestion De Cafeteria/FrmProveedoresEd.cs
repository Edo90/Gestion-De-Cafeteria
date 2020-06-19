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
    public partial class FrmProveedoresEd : Form
    {
        public Proveedore proveedor { get; set; }
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmProveedoresEd()
        {
            InitializeComponent();
        }

        private void FrmProveedoresEd_Load(object sender, EventArgs e)
        {
            CbxEstado.SelectedIndex = 0;
            if (proveedor != null)
            {
                TxtIdProveedor.Text = proveedor.IdProveedor.ToString();
                TxtNombreComercial.Text = proveedor.NombreComercial;
                TxtRNC.Text = proveedor.RNC.ToString();
                DtpFechaRegistro.Value = proveedor.FechaRegistro;
                if (proveedor.Estado == "Inactivo")
                {
                    CbxEstado.SelectedIndex = 1;
                }
            }
        }

        private void CmdGuadar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtIdProveedor.Text != "")
                {
                    Proveedore proveedor = entities.Proveedores.Find(Int32.Parse(TxtIdProveedor.Text));
                    proveedor.NombreComercial = TxtNombreComercial.Text;
                    proveedor.RNC = TxtRNC.Text;
                    proveedor.FechaRegistro = DtpFechaRegistro.Value;
                    proveedor.Estado = CbxEstado.Text;
                    entities.Entry<Proveedore>(proveedor).State = EntityState.Modified;
                    entities.SaveChanges();
                    entities.Entry<Proveedore>(proveedor).Reload();
                }
                else
                {
                    entities.Proveedores.Add(new Proveedore
                    {
                        NombreComercial = TxtNombreComercial.Text,
                        RNC = TxtRNC.Text,
                        FechaRegistro = DtpFechaRegistro.Value,
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

            Proveedore proveedor = entities.Proveedores.Find(Int32.Parse(TxtIdProveedor.Text));
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
