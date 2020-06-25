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
    public partial class ArticulosFormEd : Form
    {
        Articulo articulo;
        GestionCafeteriaEntities entities = new GestionCafeteriaEntities();
        public ArticulosFormEd()
        {
            InitializeComponent();
        }

        public ArticulosFormEd(Articulo articulo)
        {
            this.articulo = articulo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var articulo = new Articulo
            {
                Id = String.IsNullOrEmpty(idTb.Text) ? 0 : int.Parse(idTb.Text),
                Descripcion = descriptionTb.Text,
                MarcaId = entities.Marcas.Where(x => x.Descripcion == marcaCb.Text)
                                        .Select(x => x.IdMarca)
                                        .FirstOrDefault(),
                Costo = costoN.Value,
                ProveedorId = entities.Proveedores.Where(x => x.NombreComercial == proveedorCb.Text)
                                        .Select(x => x.IdProveedor)
                                        .FirstOrDefault(),
                Existencia = "Existente" == (string)existenciaCb.SelectedItem,
                Estado = "Activo" == (string)estadoCb.SelectedItem
            };

            if (articulo != null)
                entities.Articulos.AddOrUpdate(articulo);

            entities.SaveChanges();
            this.Dispose();
        }

        private void ArticulosFormEd_Load(object sender, EventArgs e)
        {
            var marcas = entities.Marcas.Select(x => x.Descripcion).ToArray();
            var proveedores = entities.Proveedores.Select(x => x.NombreComercial).ToArray();
            marcaCb.Items.AddRange(marcas);
            proveedorCb.Items.AddRange(proveedores);
            if (articulo != null)
            {
                idTb.Text = articulo.Id.ToString();
                descriptionTb.Text = articulo.Descripcion;
                marcaCb.SelectedItem = articulo.Marca.Descripcion;
                costoN.Value = articulo.Costo == null ? 0 : articulo.Costo.Value;
                proveedorCb.SelectedItem = articulo.Proveedore == null ? "" : articulo.Proveedore.NombreComercial;
                existenciaCb.SelectedItem = articulo.Existencia ? "Existente" : "No Existente";
                estadoCb.SelectedItem = articulo.Estado ? "Activo" : "Inactivo";
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var articulo = entities.Articulos.Find(int.Parse(idTb.Text));
            if (articulo != null)
            {
                entities.Articulos.Remove(articulo);
                entities.SaveChanges();
                MessageBox.Show("Articulo eliminada con exito");
            }
            else
                MessageBox.Show("Articulo no existe");
            this.Close();
        }
    }
}
