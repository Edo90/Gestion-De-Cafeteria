﻿using System;
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
    public partial class FrmCampus : Form
    {
        public Campus campus { get; set; }
        private GCEntities entities = new GCEntities();

        public FrmCampus()
        {
            InitializeComponent();
        }

        private void FrmCampus_Load(object sender, EventArgs e)
        {
            ConsultarCampus();
        }

        private void ConsultarCampus()
        {
            var listadoCampus = from cam in entities.Campus
                                select new
                                {
                                    ID = cam.ID,
                                    Descripcion = cam.Descripcion,
                                    Estado = cam.Estado
                                };
                DgvCampus.DataSource = listadoCampus.ToList();            
        }
        
        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }
        private void consultarPorCriterio()
        {
            var campus = from cam in entities.Campus
                         where (cam.ID.ToString().StartsWith(txtBuscarPor.Text) ||
                         cam.Descripcion.StartsWith(txtBuscarPor.Text) ||
                         cam.Estado.StartsWith(txtBuscarPor.Text)
                         )
                         select new
                         {
                             ID = cam.ID,
                             Descripcion = cam.Descripcion,
                             Estado = cam.Estado
                         };
            DgvCampus.DataSource = campus.ToList();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdCampus frm = new FrmEdCampus();
            frm.ShowDialog();
        }

        private void FrmCampus_Activated(object sender, EventArgs e)
        {
            ConsultarCampus();
        }

        private void DgvCampus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgvCampus.SelectedRows[0];
            Campus campus = new Campus();
            campus.ID = Int32.Parse(row.Cells[0].Value.ToString());
            campus.Descripcion = row.Cells[1].Value.ToString();
            campus.Estado = row.Cells[2].Value.ToString();
            FrmEdCampus fed = new FrmEdCampus();
            fed.campus = campus;
            
            fed.ShowDialog();
        }
    }
}