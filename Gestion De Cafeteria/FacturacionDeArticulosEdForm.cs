using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Cafeteria
{
    public partial class FacturacionDeArticulosEdForm : Form
    {
        GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        private Facturacion_Articulos factura;

        public FacturacionDeArticulosEdForm()
        {
            InitializeComponent();
        }

        public FacturacionDeArticulosEdForm(Facturacion_Articulos factura)
        {
            InitializeComponent();
            this.factura = factura;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Facturacion_Articulos fact = new Facturacion_Articulos();

            fact.Id = string.IsNullOrEmpty(idTb.Text) ? 0 : int.Parse(idTb.Text);
            fact.ArticuloId = entities.Articulos.Where(x => x.Descripcion == articuloCb.SelectedItem.ToString())
                                                .Select(x => x.Id)
                                                .FirstOrDefault();
            fact.Comentario = comentarioTb.Text;
            fact.EmpleadoId = entities.Empleadoes.Where(x => x.Nombre == empleadoCb.SelectedItem.ToString())
                                                 .Select(x => x.IdEMpleado)
                                                 .FirstOrDefault();
            fact.Estado = estadoCheckBox.Checked;
            fact.Fecha_Venta = DateTime.Now;
            fact.Monto_De_Articulo = decimal.Parse(montoTb.Text);
            fact.Unidades_Vendidas = int.Parse(unidadesVendidasTb.Text);
            fact.UsuarioId = entities.Usuarios.Where(x => x.Nombre == usuarioCb.SelectedItem.ToString())
                                                 .Select(x => x.IdUsuario)
                                                 .FirstOrDefault();

            entities.Facturacion_Articulos.AddOrUpdate(fact);
            entities.SaveChanges();

            this.Close();
        }

        private void FacturacionDeArticulosEdForm_Load(object sender, EventArgs e)
        {
            var usuarios = entities.Usuarios.Select(x => x.Nombre).ToArray();
            var empleados = entities.Empleadoes.Select(x => x.Nombre).ToArray();
            var Articulos = entities.Articulos.Select(x => x.Descripcion).ToArray();
            usuarioCb.Items.AddRange(usuarios);
            empleadoCb.Items.AddRange(empleados);
            articuloCb.Items.AddRange(Articulos);

            if(factura != null)
            {
                idTb.Text = factura.Id.ToString();
                articuloCb.SelectedItem = factura.Articulo.Descripcion;
                comentarioTb.Text = factura.Comentario;
                empleadoCb.SelectedItem = factura.Empleado.Nombre;
                estadoCheckBox.Checked = factura.Estado;
                fechaDeVentaTb.Text = factura.Fecha_Venta.ToString();
                montoTb.Text = factura.Monto_De_Articulo.ToString();
                unidadesVendidasTb.Value = factura.Unidades_Vendidas;
                usuarioCb.SelectedItem = factura.Usuario.Nombre;
            }
            else
            {
                fechaDeVentaTb.Text = DateTime.Now.ToString();
            }
        }

        private void articuloCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            montoTb.Text = entities.Articulos.Where(x => x.Descripcion == articuloCb.Text).Select(x => x.Costo).FirstOrDefault().ToString();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var facturacion = entities.Facturacion_Articulos.Find(Int32.Parse(idTb.Text));
            if (facturacion != null)
            {
                entities.Facturacion_Articulos.Remove(facturacion);
                entities.SaveChanges();
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("La cafeteria no existe");
            }
            this.Close();
        }
    }
}
