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
            if (esUnRNCValido(TxtRNC.Text))
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
                        entities.Entry(proveedor).State = EntityState.Modified;
                        entities.SaveChanges();
                        entities.Entry(proveedor).Reload();
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
            else
            {
                MessageBox.Show("El RNC intoducido es invalido");
            }
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Proveedore proveedor = entities.Proveedores.Find(int.Parse(TxtIdProveedor.Text));
            if (proveedor != null)
            {
                entities.Proveedores.Remove(proveedor);
                entities.SaveChanges();
                MessageBox.Show("Proveedor eliminado con exito");
            }
            else
            {
                MessageBox.Show("Proveedor no existe");
            }
            this.Close();
        }
        private bool esUnRNCValido(string pRNC)
        {
            int vnTotal = 0;
            int[] digitoMult = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };
            string vcRNC = pRNC.Replace("-", "").Replace(" ", "");
            string vDigito = vcRNC.Substring(8, 1);
            if (vcRNC.Length.Equals(9))
                if (!"145".Contains(vcRNC.Substring(0, 1)))
                    return false;
            for (int vDig = 1; vDig <= 8; vDig++)
            {
                int vCalculo = Int32.Parse(vcRNC.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                vnTotal += vCalculo;
            }
            if (vnTotal % 11 == 0 && vDigito == "1" || vnTotal % 11 == 1 && vDigito == "1" ||
                (11 - (vnTotal % 11)).Equals(vDigito))
                return true;
            else
                return false;
        }
    }
}
