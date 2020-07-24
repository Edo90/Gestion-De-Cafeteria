namespace Gestion_De_Cafeteria
{
    partial class FrmUsuariosEd
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
            this.TxtLimiteCredito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(381, 459);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(121, 81);
            this.CmdEliminar.TabIndex = 5;
            this.CmdEliminar.Text = "Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdGuadar
            // 
            this.CmdGuadar.Location = new System.Drawing.Point(25, 459);
            this.CmdGuadar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdGuadar.Name = "CmdGuadar";
            this.CmdGuadar.Size = new System.Drawing.Size(121, 81);
            this.CmdGuadar.TabIndex = 4;
            this.CmdGuadar.Text = "Guardar";
            this.CmdGuadar.UseVisualStyleBackColor = true;
            this.CmdGuadar.Click += new System.EventHandler(this.CmdGuadar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtLimiteCredito);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CbxTipoUsuario);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DtpFechaRegistro);
            this.panel1.Controls.Add(this.CbxEstado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtCedula);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtIdUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 426);
            this.panel1.TabIndex = 3;
            // 
            // TxtLimiteCredito
            // 
            this.TxtLimiteCredito.Location = new System.Drawing.Point(141, 254);
            this.TxtLimiteCredito.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLimiteCredito.Name = "TxtLimiteCredito";
            this.TxtLimiteCredito.Size = new System.Drawing.Size(240, 22);
            this.TxtLimiteCredito.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Limite de Credito";
            // 
            // CbxTipoUsuario
            // 
            this.CbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoUsuario.FormattingEnabled = true;
            this.CbxTipoUsuario.Location = new System.Drawing.Point(141, 187);
            this.CbxTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.CbxTipoUsuario.Name = "CbxTipoUsuario";
            this.CbxTipoUsuario.Size = new System.Drawing.Size(240, 24);
            this.CbxTipoUsuario.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Usuario";
            // 
            // DtpFechaRegistro
            // 
            this.DtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaRegistro.Location = new System.Drawing.Point(141, 315);
            this.DtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaRegistro.Name = "DtpFechaRegistro";
            this.DtpFechaRegistro.Size = new System.Drawing.Size(240, 22);
            this.DtpFechaRegistro.TabIndex = 11;
            // 
            // CbxEstado
            // 
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CbxEstado.Location = new System.Drawing.Point(141, 382);
            this.CbxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(240, 24);
            this.CbxEstado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Registro";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(141, 126);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(240, 22);
            this.TxtCedula.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cedula";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(141, 71);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(240, 22);
            this.TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Enabled = false;
            this.TxtIdUsuario.Location = new System.Drawing.Point(141, 20);
            this.TxtIdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(240, 22);
            this.TxtIdUsuario.TabIndex = 1;
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
            // FrmUsuariosEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 555);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdGuadar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuariosEd";
            this.Text = "Edicion de Usuario";
            this.Load += new System.EventHandler(this.FrmUsuariosEd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdGuadar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DtpFechaRegistro;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLimiteCredito;
        private System.Windows.Forms.Label label7;
    }
}