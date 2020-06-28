namespace Gestion_De_Cafeteria
{
    partial class FrmMarcasEd
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
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.CmdGuadar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(381, 289);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(121, 81);
            this.CmdEliminar.TabIndex = 5;
            this.CmdEliminar.Text = "Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdGuadar
            // 
            this.CmdGuadar.Location = new System.Drawing.Point(25, 289);
            this.CmdGuadar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdGuadar.Name = "CmdGuadar";
            this.CmdGuadar.Size = new System.Drawing.Size(121, 81);
            this.CmdGuadar.TabIndex = 4;
            this.CmdGuadar.Text = "Guardar";
            this.CmdGuadar.UseVisualStyleBackColor = true;
            this.CmdGuadar.Click += new System.EventHandler(this.CmdGuadar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbxEstado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtIdMarca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 247);
            this.panel1.TabIndex = 3;
            // 
            // CbxEstado
            // 
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CbxEstado.Location = new System.Drawing.Point(141, 134);
            this.CbxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(169, 24);
            this.CbxEstado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(141, 71);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(337, 22);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // TxtIdMarca
            // 
            this.TxtIdMarca.Enabled = false;
            this.TxtIdMarca.Location = new System.Drawing.Point(141, 20);
            this.TxtIdMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdMarca.Name = "TxtIdMarca";
            this.TxtIdMarca.Size = new System.Drawing.Size(151, 22);
            this.TxtIdMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // FrmMarcasEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 388);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdGuadar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMarcasEd";
            this.Text = "Edicion de Marca";
            this.Load += new System.EventHandler(this.FrmMarcasEd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdGuadar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdMarca;
        private System.Windows.Forms.Label label1;
    }
}