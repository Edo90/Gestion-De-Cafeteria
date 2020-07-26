using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Cafeteria
{
    public partial class FrmLogin : Form
    {
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CmdIniciar_Click(object sender, EventArgs e)
        {
            string clave = getMD5Hash(txtClave.Text);

            Usuario usuario = (from u in entities.Usuarios
                                where u.Nombre.Equals(txtUsuario.Text) &&
                                      u.Clave.Equals(clave)
                                select u).FirstOrDefault();

            if ((usuario == null) || (usuario.Estado != "Activo"))
            {
                MessageBox.Show("Credenciales incorrectas");
            }
            else
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
                Form1 menu = new Form1();
                menu.ShowDialog();
            }
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
    }
}
