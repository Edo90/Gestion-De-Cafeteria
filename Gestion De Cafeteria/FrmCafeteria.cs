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
    public partial class FrmCafeteria : Form
    {
        public Cafeteria cafeteria { get; set; }
        private GestionCafeteriaEntities entities = new GestionCafeteriaEntities();

        public FrmCafeteria()
        {
            InitializeComponent();
        }

        private void FrmCafeteria_Load(object sender, EventArgs e)
        {            
            ConsultarCafeteria();
        }

        private void ConsultarCafeteria()
        {
           
                var listadoCafeterias = (from caf in entities.Cafeterias
                                        join cam in entities.Campus on caf.ID_Campus equals cam.ID
                                        join emp in entities.Empleadoes on caf.Encargado equals emp.IdEMpleado
                                        select new 
                                        {
                                            caf.ID,
                                            caf.Descripcion,
                                            idCampus = caf.ID_Campus,
                                            nombreCampus = cam.Descripcion,
                                            idEncargado = caf.Encargado,
                                            nombreEncargado = emp.Nombre,
                                            caf.Estado
                                        }).ToList();

            DgvCafeteria.DataSource = listadoCafeterias.ToList();              
                       
        }

        private void CmdBuscar_Click_1(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }       

        private void consultarPorCriterio()
        {
            var cafet = from em in entities.Cafeterias
                        join cam in entities.Campus on em.ID_Campus equals cam.ID
                        join emp in entities.Empleadoes on em.Encargado equals emp.IdEMpleado
                        where (em.ID.ToString().StartsWith(txtBuscarPor.Text) ||
                        em.Descripcion.StartsWith(txtBuscarPor.Text) ||
                        em.Estado.StartsWith(txtBuscarPor.Text) ||
                        em.Encargado.ToString().StartsWith(txtBuscarPor.Text) ||
                        em.Estado.StartsWith(txtBuscarPor.Text)
                        )
                        select new
                        {
                            ID = em.ID,
                            Descripcion = em.Descripcion,
                            idCampus = em.ID_Campus,
                            nombreCampus = cam.Descripcion,
                            idEncargado = em.Encargado,
                            nombreEncargado = emp.Nombre,
                            Estado = em.Estado
                        };
            DgvCafeteria.DataSource = cafet.ToList();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdCafeteria frm = new FrmEdCafeteria();
            frm.llenarCombox();
            frm.ShowDialog();
        }
        private void FrmCafeteria_Activated(object sender, EventArgs e)
        {
            ConsultarCafeteria();
        }

        private void DgvCafeteria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgvCafeteria.SelectedRows[0];
            Cafeteria cafeteria = new Cafeteria();
            cafeteria.ID = Int32.Parse(row.Cells[0].Value.ToString());
            cafeteria.Descripcion = row.Cells[1].Value.ToString();
            cafeteria.ID_Campus = Int32.Parse(row.Cells[2].Value.ToString());
            cafeteria.Encargado = Int32.Parse(row.Cells[4].Value.ToString());
            cafeteria.Estado = row.Cells[6].Value.ToString();
            FrmEdCafeteria fed = new FrmEdCafeteria();
            fed.cafeteria = cafeteria;
            fed.llenarCombox();

            fed.ShowDialog();
        }

        
    }
}
