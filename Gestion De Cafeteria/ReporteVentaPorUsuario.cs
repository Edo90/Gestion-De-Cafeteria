using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Cafeteria
{
    public partial class ReporteVentaPorUsuario : Form
    {
        DataTable oDt = new DataTable();
        SqlConnection oCon = null;
        public ReporteVentaPorUsuario()
        {
            InitializeComponent();
        }

        private void ReporteVentaPorUsuario_Load(object sender, EventArgs e)
        {
            OpenConnection();
            FillComboBoxes();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            string where = $" where MONTH(fa.Fecha_Venta) = {GetMonthNumberFromMonthName((string)cbMeses.SelectedItem)} and YEAR(fa.Fecha_Venta) = {cbAnios.SelectedItem}";
            string sSql = 
                "select e.Nombre,a.Descripcion,u.Nombre,fa.Fecha_Venta,Monto_De_Articulo,Unidades_Vendidas,Monto_De_Articulo*Unidades_Vendidas as MontoTotal"
                +" from Facturacion_Articulos as fa"
                +" inner join Empleado as e"
                +" on fa.EmpleadoId = e.IdEMpleado"
                +" inner join Articulos as a"
                +" on fa.ArticuloId = a.Id"
                +" inner join Usuarios as u"
                +" on fa.UsuarioId = u.IdUsuario"
                +where
                +" order by MontoTotal desc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sSql, oCon);
            oDt = new DataTable();
            sqlDataAdapter.Fill(oDt);
            dataGridView1.DataSource = oDt;
            dataGridView1.Refresh();
        }

        private void FillComboBoxes()
        {
            Fill_CmbMonth();
            Fill_CmbYear();
        }

        private void OpenConnection()
        {
            oCon = new SqlConnection("Data Source=localhost;Initial Catalog=GestionCafeteria;Integrated Security=True");
            oCon.Open();
        }

        private void Fill_CmbMonth()
        {
            try
            {

                //clear all data from combobox
                cbMeses.Items.Clear();
                //add default item
                cbMeses.Items.Add("Select");
                //fill array from System.Globalization.DateTimeFormatInfo.InvariantInfo
                var Months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
                //loop array for add items
                foreach (string sm in Months)
                {
                    if (sm != "")
                        cbMeses.Items.Add(sm);
                }
                //set selected item for display on startup
                cbMeses.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //For year combo box

        private void Fill_CmbYear()
        {
            try
            {
                //clear all data from combobox
                cbAnios.Items.Clear();
                //add default item
                cbAnios.Items.Add("Select");
                //loop array for add items
                for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 15; i++)
                {
                    cbAnios.Items.Add(i);
                }
                //set selected item for display on startup
                cbAnios.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private int GetMonthNumberFromMonthName(string monthName)
        {

            var monthNumber = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month;
            return monthNumber;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            WriteFileHeader("Empleado, Articulo, Usuario, Venta, Monto, Unidades, Total");

            foreach (DataRow row in oDt.Rows)
            {
                string linea = "";
                foreach (DataColumn dc in oDt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                WriteFileLine(linea);
            }

            Process.Start($"C:\\Users\\Oriontek\\Documents\\ReportesPropietaria\\ReporteDeVenta {cbMeses.SelectedItem}.csv");
        }

        private void WriteFileLine(string pLine)
        {
            using (StreamWriter w = File.AppendText($"C:\\Users\\Oriontek\\Documents\\ReportesPropietaria\\ReporteDeVenta { cbMeses.SelectedItem}.csv"))
            {
                w.WriteLine(pLine);
            }
        }
        private void WriteFileHeader(string pLine)
        {
            using (StreamWriter w = File.CreateText($"C:\\Users\\Oriontek\\Documents\\ReportesPropietaria\\ReporteDeVenta {cbMeses.SelectedItem}.csv"))
            {
                w.WriteLine(pLine);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}

