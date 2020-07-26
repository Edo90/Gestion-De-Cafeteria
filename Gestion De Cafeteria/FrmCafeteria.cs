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
        public Cafeteria Cafeteria { get; set; }
        private readonly GestionCafeteriaEntities entities = new GestionCafeteriaEntities();

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
                                         Campus = cam.Descripcion,
                                         idEncargado = caf.Encargado,
                                         Encargado = emp.Nombre,
                                         caf.Estado
                                     }).ToList();

            DgvCafeteria.DataSource = listadoCafeterias.ToList();

            DgvCafeteria.Columns[2].Visible = false;
            DgvCafeteria.Columns[4].Visible = false;
            DgvCafeteria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CmdBuscar_Click_1(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }       

        private void consultarPorCriterio()
        {
            var cafeteria = from em in entities.Cafeterias
                        join cam in entities.Campus on em.ID_Campus equals cam.ID
                        join emp in entities.Empleadoes on em.Encargado equals emp.IdEMpleado
                        where (em.ID.ToString().StartsWith(txtBuscarPor.Text) ||
                        em.Descripcion.StartsWith(txtBuscarPor.Text) ||
                        em.Encargado.ToString().StartsWith(txtBuscarPor.Text)
                        )
                        select new
                        {
                            ID = em.ID,
                            Descripcion = em.Descripcion,
                            idCampus = em.ID_Campus,
                            Campus = cam.Descripcion,
                            Encargado = em.Encargado,
                            nombreEncargado = emp.Nombre,
                            Estado = em.Estado
                        };
            DgvCafeteria.DataSource = cafeteria.ToList();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdCafeteria frm = new FrmEdCafeteria();
            frm.LlenarCombox();
            frm.ShowDialog();
        }
        private void FrmCafeteria_Activated(object sender, EventArgs e)
        {
            ConsultarCafeteria();
        }

        private void DgvCafeteria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DgvCafeteria.SelectedRows[0];
            Cafeteria cafeteria = new Cafeteria
            {
                ID = int.Parse(row.Cells[0].Value.ToString()),
                Descripcion = row.Cells[1].Value.ToString(),
                ID_Campus = int.Parse(row.Cells[2].Value.ToString()),
                Encargado = int.Parse(row.Cells[4].Value.ToString()),
                Estado = (bool)row.Cells[6].Value
            };
            var estado = row.Cells[6].Value;
            FrmEdCafeteria fed = new FrmEdCafeteria
            {
                cafeteria = cafeteria
            };
            fed.LlenarCombox();

            fed.ShowDialog();
        }

        
    }
}
