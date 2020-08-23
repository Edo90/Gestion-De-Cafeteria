using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Cafeteria
{
    public partial class FrmReporteVentas : Form
    {
        GestionCafeteriaEntities entities = new GestionCafeteriaEntities();

        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            var lCadConexion = System.Configuration.ConfigurationManager.ConnectionStrings["ArchivosConnectionString"].ConnectionString;
            SqlConnection ocon = new SqlConnection(lCadConexion);
            ocon.Open();

            var fechaInicio = TxtDesde.Value;
            var fechaFin = TxtHasta.Value;

            string sSQl = "SELECT f.Id,e.Nombre,a.Descripcion,u.Nombre,Fecha_Venta,Monto_De_Articulo,Unidades_Vendidas,Comentario,f.Estado " +
                "FROM Facturacion_Articulos f " +
                "inner join Empleadoes e on f.EmpleadoId = e.IdEMpleado " +
                "inner join Articulos a on f.ArticuloId = a.Id " +
                "inner join Usuarios u on f.UsuarioId = u.IdUsuario " +
                "where Fecha_Venta between"+ fechaInicio +" and"+ fechaFin;

            SqlCommand ocmd = new SqlCommand(sSQl, ocon);
            SqlDataReader odr;

            odr = ocmd.ExecuteReader();
            while (odr.Read())
            {
                writeFileLine(
                              odr.GetValue(0) + "," + odr.GetValue(1) + "," + odr.GetValue(2) + "," + odr.GetValue(3)
                              + "," + odr.GetValue(4) + "," + odr.GetValue(5) + "," + odr.GetValue(6) + "," + odr.GetValue(7)
                              + "," + odr.GetValue(8)
                            );
            }

            odr.Close();
            ocmd.Dispose();
            ocon.Close();
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText("C:/Documents/Reporte.csv"))
            {
                w.WriteLine(pLine);
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
