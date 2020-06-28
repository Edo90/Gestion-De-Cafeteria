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
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }
        private void ConsultarPorCriterio()
        {
            var campus = from tipoUsu in entities.Tipo_Usuario
                         where (tipoUsu.ID.ToString().StartsWith(txtBuscarPor.Text) ||
                         tipoUsu.Descripcion.StartsWith(txtBuscarPor.Text) ||
                         tipoUsu.Estado.StartsWith(txtBuscarPor.Text)
                         )
                         select new 
                         { 
                            tipoUsu.ID,
                            tipoUsu.Descripcion,
                            tipoUsu.Estado
                         };
            DgvTipoUsuario.DataSource = campus.ToList();
            DgvTipoUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdTipoUsuario fed = new FrmEdTipoUsuario();
            fed.ShowDialog();
        }

        private void FrmTipoUsuario_Activated(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void DgvTipoUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DgvTipoUsuario.SelectedRows[0];
            Tipo_Usuario tipoUsua = new Tipo_Usuario
            {
                ID = int.Parse(row.Cells[0].Value.ToString()),
                Descripcion = row.Cells[1].Value.ToString(),
                Estado = row.Cells[2].Value.ToString()
            };
            FrmEdTipoUsuario fed = new FrmEdTipoUsuario
            {
                tipoUsuario = tipoUsua
            };

            fed.ShowDialog();
        }
    }
}
