namespace Gestion_De_Cafeteria
{
    partial class FrmMarcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvMarcas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.TxtDatoABuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarcas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvMarcas);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 253);
            this.panel2.TabIndex = 3;
            // 
            // DgvMarcas
            // 
            this.DgvMarcas.AllowUserToAddRows = false;
            this.DgvMarcas.AllowUserToDeleteRows = false;
            this.DgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMarcas.Location = new System.Drawing.Point(13, 3);
            this.DgvMarcas.Name = "DgvMarcas";
            this.DgvMarcas.ReadOnly = true;
            this.DgvMarcas.Size = new System.Drawing.Size(594, 245);
            this.DgvMarcas.TabIndex = 0;
            this.DgvMarcas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMarcas_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CmdAgregar);
            this.panel1.Controls.Add(this.CmdBuscar);
            this.panel1.Controls.Add(this.TxtDatoABuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 66);
            this.panel1.TabIndex = 2;
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.Location = new System.Drawing.Point(538, 3);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(69, 59);
            this.CmdAgregar.TabIndex = 3;
            this.CmdAgregar.Text = "Agregar";
            this.CmdAgregar.UseVisualStyleBackColor = true;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.Location = new System.Drawing.Point(423, 3);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(69, 59);
            this.CmdBuscar.TabIndex = 2;
            this.CmdBuscar.Text = "Buscar";
            this.CmdBuscar.UseVisualStyleBackColor = true;
            this.CmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // TxtDatoABuscar
            // 
            this.TxtDatoABuscar.Location = new System.Drawing.Point(98, 23);
            this.TxtDatoABuscar.Name = "TxtDatoABuscar";
            this.TxtDatoABuscar.Size = new System.Drawing.Size(290, 20);
            this.TxtDatoABuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato a Buscar";
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMarcas";
            this.Text = "Marcas";
            this.Activated += new System.EventHandler(this.FrmMarcas_Activated);
            this.Load += new System.EventHandler(this.FrmMarcas_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarcas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvMarcas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.TextBox TxtDatoABuscar;
        private System.Windows.Forms.Label label1;
    }
}