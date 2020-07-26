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
        public Usuario Usuario { get; set; }
        private readonly GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        readonly ValidacionCedula vc = new ValidacionCedula();
        public FrmUsuariosEd()
        {
            InitializeComponent();
        }

        private void FrmUsuariosEd_Load(object sender, EventArgs e)
        {
            CbxTipoUsuario.Items.AddRange(entities.Tipo_Usuario.Select(x => x.Descripcion).ToArray());
            CbxEstado.SelectedIndex = 0;
            if (Usuario != null)
            {
                TxtIdUsuario.Text = Usuario.IdUsuario.ToString();
                TxtNombre.Text = Usuario.Nombre;
                TxtCedula.Text = Usuario.Cedula.ToString();
                CbxTipoUsuario.SelectedItem = Usuario.TipoUsuario;
                TxtLimiteCredito.Text = Usuario.LimiteCredito.ToString();
                DtpFechaRegistro.Value = Usuario.FechaRegistro;
                if (!Usuario.Estado)
                {
                    CbxEstado.SelectedIndex = 1;
                }
            }
        }

        private void CmdGuadar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vc.validaCedula(TxtCedula.Text))
                {
                    MessageBox.Show("Cedula incorrecta");
                    return;
                }
                if (TxtIdUsuario.Text != "")
                {
                    Usuario usuario = entities.Usuarios.Find(Int32.Parse(TxtIdUsuario.Text));
                    usuario.Nombre = TxtNombre.Text;
                    usuario.Cedula = TxtCedula.Text;
                    usuario.TipoUsuario = CbxTipoUsuario.Text;
                    usuario.LimiteCredito = decimal.Parse(TxtLimiteCredito.Text);
                    usuario.FechaRegistro = DtpFechaRegistro.Value;
                    usuario.Estado = CbxEstado.Text == "";
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
                        Estado = CbxEstado.SelectedItem == "Activo"
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

            bool success = int.TryParse(TxtIdUsuario.Text, out int usuarioId);
            if (!success) 
            {
                MessageBox.Show("Coloque un Id correcto.","Error");
                return;
            }

            var usuario = entities.Usuarios.Find(usuarioId);
            if (usuario != null)
            {
                entities.Usuarios.Remove(usuario);
                entities.SaveChanges();
                MessageBox.Show("Usuario eliminado con exito","Info");
            }
            else
            {
                MessageBox.Show("Usuario no existe","Infoe");
            }
            this.Close();
        }
    }
}
