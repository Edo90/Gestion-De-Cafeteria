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
    public partial class FrmMarcas : Form
    {
        public Marca marca { get; set; }
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmMarcasEd fme = new FrmMarcasEd();
            fme.ShowDialog();
        }

        private void FrmMarcas_Activated(object sender, EventArgs e)
        {
            ConsultarPorCriterio();
        }

        private void DgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgvMarcas.SelectedRows[0];
            Marca marca = new Marca();
            marca.IdMarca = Int32.Parse(row.Cells[0].Value.ToString());
            marca.Descripcion = row.Cells[1].Value.ToString();
            marca.Estado = row.Cells[2].Value.ToString();
            FrmMarcasEd fme = new FrmMarcasEd();
            fme.marca = marca;
            fme.ShowDialog();
        }

        private void ConsultarPorCriterio()
        {
            var marcas = from em in entities.Marcas
                         where (em.IdMarca.ToString().StartsWith(TxtDatoABuscar.Text) ||
                       em.Descripcion.StartsWith(TxtDatoABuscar.Text) ||
                       em.Estado.StartsWith(TxtDatoABuscar.Text)
                       )
                         select new 
                         { 
                            em.IdMarca,
                            em.Descripcion,
                            em.Estado
                         };
            DgvMarcas.DataSource = marcas.ToList();
            DgvMarcas.Columns[0].Visible = false;
            DgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
