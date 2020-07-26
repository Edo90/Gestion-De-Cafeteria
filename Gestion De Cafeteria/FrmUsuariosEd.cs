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
using System.Security.Cryptography;

namespace Gestion_De_Cafeteria
{
    public partial class FrmUsuariosEd : Form
    {
        public Usuario usuario { get; set; }
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmUsuariosEd()
        {
            InitializeComponent();
        }

        private void FrmUsuariosEd_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCafeteriaDataSet1.Tipo_Usuario' Puede moverla o quitarla según sea necesario.
            this.tipo_UsuarioTableAdapter.Fill(this.gestionCafeteriaDataSet1.Tipo_Usuario);
            //CbxTipoUsuario.Items.Clear();
            //var usu = from usus in entities.Tipo_Usuario select new { usus.Descripcion };
            //CbxTipoUsuario.Items.Add(usu);
            CbxTipoUsuario.SelectedIndex = 0;
            CbxEstado.SelectedIndex = 0;
            if (usuario != null)
            {
                TxtIdUsuario.Text = usuario.IdUsuario.ToString();
                TxtNombre.Text = usuario.Nombre;
                txtClave.Text = usuario.Clave;
                txtClave.PasswordChar = '*';
                txtClave.Enabled = false;
                TxtCedula.Text = usuario.Cedula.ToString();
                if (usuario.TipoUsuario == "Usuario")
                {
                    CbxTipoUsuario.SelectedIndex = 1;
                }
                TxtLimiteCredito.Text = usuario.LimiteCredito.ToString();
                DtpFechaRegistro.Value = usuario.FechaRegistro;
                if (usuario.Estado == "Inactivo")
                {
                    CbxEstado.SelectedIndex = 1;
                }
            }
        }

        private void CmdGuadar_Click(object sender, EventArgs e)
        {
            if (validaCedula(TxtCedula.Text))
            {
                try
                {
                    if (TxtIdUsuario.Text != "")
                    {
                        Usuario usuario = entities.Usuarios.Find(Int32.Parse(TxtIdUsuario.Text));
                        usuario.Nombre = TxtNombre.Text;
                        usuario.Cedula = TxtCedula.Text;
                        usuario.TipoUsuario = CbxTipoUsuario.Text;
                        usuario.LimiteCredito = decimal.Parse(TxtLimiteCredito.Text);
                        usuario.FechaRegistro = DtpFechaRegistro.Value;
                        usuario.Estado = CbxEstado.Text;
                        usuario.Clave = getMD5Hash(txtClave.Text);
                        entities.Entry(usuario).State = EntityState.Modified;
                        entities.SaveChanges();
                        entities.Entry(usuario).Reload();
                    }
                    else
                    {
                        entities.Usuarios.Add(new Usuario
                        {
                            Nombre = TxtNombre.Text,
                            Cedula = TxtCedula.Text,
                            TipoUsuario = CbxTipoUsuario.Text,
                            LimiteCredito = decimal.Parse(TxtLimiteCredito.Text),
                            FechaRegistro = DtpFechaRegistro.Value,
                            Estado = CbxEstado.Text,
                            Clave = getMD5Hash(txtClave.Text)
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
                MessageBox.Show("La cedula intoducida es invalida");
            }
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Usuario usuario = entities.Usuarios.Find(Int32.Parse(TxtIdUsuario.Text));
            if (usuario != null)
            {
                entities.Usuarios.Remove(usuario);
                entities.SaveChanges();
                MessageBox.Show("Usuario eliminado con exito");
            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
            this.Close();
        }

        public string getMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
    }
}
