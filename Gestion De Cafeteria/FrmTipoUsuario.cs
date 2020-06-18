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
    public partial class FrmTipoUsuario : Form
    {
        public Tipo_Usuario tipoUsuario { get; set; }
        private GCEntities entities = new GCEntities();
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {
            ConsultarTipoUsuarios();
        }

        private void ConsultarTipoUsuarios()
        {           
            DgvTipoUsuario.DataSource = entities.Tipo_Usuario.ToList();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }
        private void consultarPorCriterio()
        {
            var campus = from tipoUsu in entities.Tipo_Usuario
                         where (tipoUsu.ID.ToString().StartsWith(txtBuscarPor.Text) ||
                         tipoUsu.Descripcion.StartsWith(txtBuscarPor.Text) ||
                         tipoUsu.Estado.StartsWith(txtBuscarPor.Text)
                         )
                         select tipoUsu;
            DgvTipoUsuario.DataSource = campus.ToList();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdTipoUsuario fed = new FrmEdTipoUsuario();
            fed.ShowDialog();
        }

        private void FrmTipoUsuario_Activated(object sender, EventArgs e)
        {
            ConsultarTipoUsuarios();
        }

        private void DgvTipoUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgvTipoUsuario.SelectedRows[0];
            Tipo_Usuario tipoUsua = new Tipo_Usuario();
            tipoUsua.ID = Int32.Parse(row.Cells[0].Value.ToString());
            tipoUsua.Descripcion = row.Cells[1].Value.ToString();
            tipoUsua.Estado = row.Cells[2].Value.ToString();
            FrmEdTipoUsuario fed = new FrmEdTipoUsuario();
            fed.tipoUsuario = tipoUsua;

            fed.ShowDialog();
        }
    }
}
