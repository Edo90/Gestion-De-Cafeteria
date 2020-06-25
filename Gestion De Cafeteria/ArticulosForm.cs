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
    public partial class ArticulosForm : Form
    {
        GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public ArticulosForm()
        {
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            var articulos = entities.Articulos.ToList();

            var search = txtBuscarPor.Text;

            var result = articulos.Find(x => x.Costo.ToString() == search ||
            x.Descripcion.ToString() == search ||
            x.Estado.ToString() == search ||
            x.Existencia.ToString() == search ||
            x.Id.ToString() == search);

            DgvArticulos.DataSource = result;
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            ArticulosFormEd formEd = new ArticulosFormEd();
            formEd.Show();
        }

        private void DgvArticulos_DoubleClick(object sender, EventArgs e)
        {
            var selectedRow = DgvArticulos.SelectedRows[0];
            var selectedId = (int)selectedRow.Cells[0].Value;
            var articulo = entities.Articulos.Where(x => x.Id == selectedId).FirstOrDefault(); 

            ArticulosFormEd articulosFormEd = new ArticulosFormEd(articulo);
            articulosFormEd.Show();
        }

        private void ArticulosForm_Load(object sender, EventArgs e)
        {
            var articulos = entities.Articulos.ToList();
            DgvArticulos.DataSource = articulos;
        }
    }
}
