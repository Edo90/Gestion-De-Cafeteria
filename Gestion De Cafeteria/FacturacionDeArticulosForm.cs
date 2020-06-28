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
    public partial class FacturacionDeArticulosForm : Form
    {
        GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public FacturacionDeArticulosForm()
        {
            InitializeComponent();
        }

        private void FacturacionDeArticulosForm_Load(object sender, EventArgs e)
        {
            ConsultarFacturacion();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            ConsultarFacturacion();
        }

        private void ConsultarFacturacion()
        {
            var searchItem = TxtDatoABuscar.Text;

            var result = from facturas in entities.Facturacion_Articulos
                         where
                            (facturas.Id.ToString().StartsWith(searchItem) ||
                            facturas.Articulo.Descripcion.StartsWith(searchItem) ||
                            facturas.Comentario.StartsWith(searchItem) ||
                            facturas.Empleado.Nombre.ToString().StartsWith(searchItem) ||
                            facturas.Estado.ToString().StartsWith(searchItem) ||
                            facturas.Fecha_Venta.ToString().StartsWith(searchItem) ||
                            facturas.Monto_De_Articulo.ToString().StartsWith(searchItem) ||
                            facturas.Unidades_Vendidas.ToString().StartsWith(searchItem) ||
                            facturas.Usuario.Nombre.StartsWith(searchItem))
                         select new
                         {
                             facturas.Id,
                             facturas.Articulo.Descripcion,
                             facturas.Comentario,
                             facturas.Estado,
                             facturas.Fecha_Venta,
                             facturas.Monto_De_Articulo,
                             facturas.Unidades_Vendidas,
                             facturas.Usuario.Nombre
                         };

            DgvFacturacion.DataSource = result.ToList();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            FacturacionDeArticulosEdForm facturacionDeArticulosEdForm = new FacturacionDeArticulosEdForm();
            facturacionDeArticulosEdForm.Show();
        }

        private void DgvFacturacion_DoubleClick(object sender, EventArgs e)
        {
            var selectedID = int.Parse(DgvFacturacion.SelectedRows[0].Cells[0].Value.ToString());

            var factura = entities.Facturacion_Articulos
                                  .Where(x => x.Id == selectedID)
                                  .FirstOrDefault();
            FacturacionDeArticulosEdForm factEd = new FacturacionDeArticulosEdForm(factura);
            factEd.Show();

        }

        private void FacturacionDeArticulosForm_Activated(object sender, EventArgs e)
        {
            ConsultarFacturacion();
        }
    }
}
