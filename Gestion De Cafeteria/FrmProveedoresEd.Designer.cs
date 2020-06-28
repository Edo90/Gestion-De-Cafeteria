namespace Gestion_De_Cafeteria
{
    partial class FrmProveedoresEd
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
            this.DtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRNC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreComercial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdGuadar = new System.Windows.Forms.Button();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DtpFechaRegistro);
            this.panel1.Controls.Add(this.CbxEstado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtRNC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtNombreComercial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtIdProveedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 315);
            this.panel1.TabIndex = 0;
            // 
            // DtpFechaRegistro
            // 
            this.DtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaRegistro.Location = new System.Drawing.Point(141, 181);
            this.DtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFechaRegistro.Name = "DtpFechaRegistro";
            this.DtpFechaRegistro.Size = new System.Drawing.Size(169, 22);
            this.DtpFechaRegistro.TabIndex = 11;
            // 
            // CbxEstado
            // 
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CbxEstado.Location = new System.Drawing.Point(141, 240);
            this.CbxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(169, 24);
            this.CbxEstado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Registro";
            // 
            // TxtRNC
            // 
            this.TxtRNC.Location = new System.Drawing.Point(141, 126);
            this.TxtRNC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRNC.Name = "TxtRNC";
            this.TxtRNC.Size = new System.Drawing.Size(240, 22);
            this.TxtRNC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "RNC";
            // 
            // TxtNombreComercial
            // 
            this.TxtNombreComercial.Location = new System.Drawing.Point(141, 71);
            this.TxtNombreComercial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombreComercial.Name = "TxtNombreComercial";
            this.TxtNombreComercial.Size = new System.Drawing.Size(337, 22);
            this.TxtNombreComercial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Comercial";
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Enabled = false;
            this.TxtIdProveedor.Location = new System.Drawing.Point(141, 20);
            this.TxtIdProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(151, 22);
            this.TxtIdProveedor.TabIndex = 1;
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
            // CmdGuadar
            // 
            this.CmdGuadar.Location = new System.Drawing.Point(17, 351);
            this.CmdGuadar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdGuadar.Name = "CmdGuadar";
            this.CmdGuadar.Size = new System.Drawing.Size(121, 81);
            this.CmdGuadar.TabIndex = 1;
            this.CmdGuadar.Text = "Guardar";
            this.CmdGuadar.UseVisualStyleBackColor = true;
            this.CmdGuadar.Click += new System.EventHandler(this.CmdGuadar_Click);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(373, 351);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(121, 81);
            this.CmdEliminar.TabIndex = 2;
            this.CmdEliminar.Text = "Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // FrmProveedoresEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 447);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdGuadar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProveedoresEd";
            this.Text = "Edicion de Proveedor";
            this.Load += new System.EventHandler(this.FrmProveedoresEd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombreComercial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdGuadar;
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.DateTimePicker DtpFechaRegistro;
    }
}