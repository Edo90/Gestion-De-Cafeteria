namespace Gestion_De_Cafeteria
{
    partial class FrmCampus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.DgvCampus = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCampus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CmdAgregar);
            this.panel1.Controls.Add(this.CmdBuscar);
            this.panel1.Controls.Add(this.txtBuscarPor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 60);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvCampus);
            this.panel2.Location = new System.Drawing.Point(12, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 255);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por:";
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(82, 22);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(150, 20);
            this.txtBuscarPor.TabIndex = 1;
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.Location = new System.Drawing.Point(433, 7);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(75, 48);
            this.CmdBuscar.TabIndex = 2;
            this.CmdBuscar.Text = "Buscar";
            this.CmdBuscar.UseVisualStyleBackColor = true;
            this.CmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.Location = new System.Drawing.Point(541, 7);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(75, 48);
            this.CmdAgregar.TabIndex = 3;
            this.CmdAgregar.Text = "Agregar";
            this.CmdAgregar.UseVisualStyleBackColor = true;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // DgvCampus
            // 
            this.DgvCampus.AllowUserToAddRows = false;
            this.DgvCampus.AllowUserToDeleteRows = false;
            this.DgvCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCampus.Location = new System.Drawing.Point(-1, -1);
            this.DgvCampus.Name = "DgvCampus";
            this.DgvCampus.ReadOnly = true;
            this.DgvCampus.Size = new System.Drawing.Size(672, 255);
            this.DgvCampus.TabIndex = 0;
            this.DgvCampus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCampus_CellDoubleClick);
            // 
            // FrmCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCampus";
            this.Text = "FrmCampus";
            this.Activated += new System.EventHandler(this.FrmCampus_Activated);
            this.Load += new System.EventHandler(this.FrmCampus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCampus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCampus;
    }
}