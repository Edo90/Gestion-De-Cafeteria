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
    public partial class FrmUsuariosEd : Form
    {
        public Usuarios usuario { get; set; }
        private Entities entities = new Entities();
        public FrmUsuariosEd()
        {
            InitializeComponent();
        }

        private void FrmUsuariosEd_Load(object sender, EventArgs e)
        {
            CbxTipoUsuario.SelectedIndex = 0;
            CbxEstado.SelectedIndex = 0;
            if (usuario != null)
            {
                TxtIdUsuario.Text = usuario.IdUsuario.ToString();
                TxtNombre.Text = usuario.Nombre;
                TxtCedula.Text = usuario.Cedula.ToString();
                if (usuario.TipoUsuario == "Miembro")
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
            try
            {
                if (TxtIdUsuario.Text != "")
                {
                    Usuarios usuario = entities.Usuarios.Find(Int32.Parse(TxtIdUsuario.Text));
                    usuario.Nombre = TxtNombre.Text;
                    usuario.Cedula = Int32.Parse(TxtCedula.Text);
                    usuario.TipoUsuario = CbxTipoUsuario.Text;
                    usuario.LimiteCredito = decimal.Parse(TxtLimiteCredito.Text);
                    usuario.FechaRegistro = DtpFechaRegistro.Value;
                    usuario.Estado = CbxEstado.Text;
                    entities.Entry<Usuarios>(usuario).State = EntityState.Modified;
                    entities.SaveChanges();
                    entities.Entry<Usuarios>(usuario).Reload();
                }
                else
                {
                    entities.Usuarios.Add(new Usuarios
                    {
                        Nombre = TxtNombre.Text,
                        Cedula = Int32.Parse(TxtCedula.Text),
                        TipoUsuario = CbxTipoUsuario.Text,
                        LimiteCredito = decimal.Parse(TxtLimiteCredito.Text),
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

            Usuarios usuario = entities.Usuarios.Find(Int32.Parse(TxtIdUsuario.Text));
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
    }
}
