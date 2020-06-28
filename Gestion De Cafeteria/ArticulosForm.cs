using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            ConsultaArticulos();
        }

        private void ConsultaArticulos()
        {
            var search = txtBuscarPor.Text;

            var result = from articulo in entities.Articulos
                         where (
                         articulo.Id.ToString().StartsWith(search) ||
                         articulo.Costo.ToString().StartsWith(search) ||
                         articulo.Descripcion.StartsWith(search) ||
                         articulo.Marca.Descripcion.StartsWith(search) ||
                         articulo.Proveedore.NombreComercial.StartsWith(search)
                         )
                         select new
                         {
                             articulo.Id,
                             articulo.Descripcion,
                             articulo.Costo,
                             articulo.Estado,
                             articulo.Existencia,
                             Marca = articulo.Marca.Descripcion,
                             Proveedor = articulo.Proveedore.NombreComercial
                         };
            var test = result.ToList();
            DgvArticulos.DataSource = result.ToList();
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
            ConsultaArticulos();
        }

        private void ArticulosForm_Activated(object sender, EventArgs e)
        {
            ConsultaArticulos();
        }
    }
}
