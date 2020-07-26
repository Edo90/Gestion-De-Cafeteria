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
    public partial class FrmUsuarios : Form
    {
        public Usuario Usuario { get; set; }
        private readonly GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuariosEd fue = new FrmUsuariosEd();
            fue.ShowDialog();
        }

        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgvUsuarios.SelectedRows[0];
            Usuario usuario = new Usuario();
            usuario.IdUsuario = Int32.Parse(row.Cells[0].Value.ToString());
            usuario.Nombre = row.Cells[1].Value.ToString();
            usuario.Cedula = row.Cells[2].Value.ToString();
            usuario.TipoUsuario = row.Cells[3].Value == null ? String.Empty : row.Cells[3].Value.ToString();
            usuario.LimiteCredito = decimal.Parse(row.Cells[4].Value.ToString());
            usuario.FechaRegistro = DateTime.Parse(row.Cells[5].Value.ToString());
            usuario.Estado = (bool)row.Cells[6].Value;
            FrmUsuariosEd fue = new FrmUsuariosEd
            {
                Usuario = usuario
            };
            fue.ShowDialog();
        }

        private void ConsultarPorCriterio()
        {
            var usuarios = from em in entities.Usuarios
                              where (em.IdUsuario.ToString().StartsWith(TxtDatoABuscar.Text) ||
                            em.Nombre.StartsWith(TxtDatoABuscar.Text) ||
                            em.Cedula.ToString().StartsWith(TxtDatoABuscar.Text) ||
                            em.LimiteCredito.ToString().StartsWith(TxtDatoABuscar.Text) ||
                            em.FechaRegistro.ToString().StartsWith(TxtDatoABuscar.Text)
                            )
                              select new 
                              { 
                                em.IdUsuario,
                                em.Nombre,
                                em.Cedula,
                                em.TipoUsuario,
                                em.LimiteCredito,
                                em.FechaRegistro,
                                em.Estado
                              };
            DgvUsuarios.DataSource = usuarios.ToList();
            DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
