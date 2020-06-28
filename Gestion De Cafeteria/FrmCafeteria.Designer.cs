namespace Gestion_De_Cafeteria
{
    partial class FrmCafeteria
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
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvCafeteria = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCafeteria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CmdAgregar);
            this.panel1.Controls.Add(this.CmdBuscar);
            this.panel1.Controls.Add(this.txtBuscarPor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 76);
            this.panel1.TabIndex = 0;
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.Location = new System.Drawing.Point(679, 4);
            this.CmdAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(100, 66);
            this.CmdAgregar.TabIndex = 3;
            this.CmdAgregar.Text = "Agregar";
            this.CmdAgregar.UseVisualStyleBackColor = true;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.Location = new System.Drawing.Point(536, 4);
            this.CmdBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(100, 66);
            this.CmdBuscar.TabIndex = 2;
            this.CmdBuscar.Text = "Buscar";
            this.CmdBuscar.UseVisualStyleBackColor = true;
            this.CmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click_1);
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(120, 31);
            this.txtBuscarPor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(261, 22);
            this.txtBuscarPor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvCafeteria);
            this.panel2.Location = new System.Drawing.Point(17, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 291);
            this.panel2.TabIndex = 1;
            // 
            // DgvCafeteria
            // 
            this.DgvCafeteria.AllowUserToAddRows = false;
            this.DgvCafeteria.AllowUserToDeleteRows = false;
            this.DgvCafeteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCafeteria.Location = new System.Drawing.Point(5, 5);
            this.DgvCafeteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvCafeteria.Name = "DgvCafeteria";
            this.DgvCafeteria.ReadOnly = true;
            this.DgvCafeteria.RowHeadersWidth = 51;
            this.DgvCafeteria.Size = new System.Drawing.Size(792, 281);
            this.DgvCafeteria.TabIndex = 0;
            this.DgvCafeteria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCafeteria_CellDoubleClick);
            // 
            // FrmCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCafeteria";
            this.Text = "Cafeteria";
            this.Activated += new System.EventHandler(this.FrmCafeteria_Activated);
            this.Load += new System.EventHandler(this.FrmCafeteria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCafeteria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvCafeteria;
    }
}