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
            this.components = new System.ComponentModel.Container();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.CmdGuadar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtLimiteCredito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCafeteriaDataSet1 = new Gestion_De_Cafeteria.GestionCafeteriaDataSet1();
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
            this.tipo_UsuarioTableAdapter = new Gestion_De_Cafeteria.GestionCafeteriaDataSet1TableAdapters.Tipo_UsuarioTableAdapter();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCafeteriaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(286, 418);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(91, 66);
            this.CmdEliminar.TabIndex = 5;
            this.CmdEliminar.Text = "Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdGuadar
            // 
            this.CmdGuadar.Location = new System.Drawing.Point(19, 418);
            this.CmdGuadar.Name = "CmdGuadar";
            this.CmdGuadar.Size = new System.Drawing.Size(91, 66);
            this.CmdGuadar.TabIndex = 4;
            this.CmdGuadar.Text = "Guardar";
            this.CmdGuadar.UseVisualStyleBackColor = true;
            this.CmdGuadar.Click += new System.EventHandler(this.CmdGuadar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtClave);
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
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 389);
            this.panel1.TabIndex = 3;
            // 
            // TxtLimiteCredito
            // 
            this.TxtLimiteCredito.Location = new System.Drawing.Point(106, 249);
            this.TxtLimiteCredito.Name = "TxtLimiteCredito";
            this.TxtLimiteCredito.Size = new System.Drawing.Size(181, 20);
            this.TxtLimiteCredito.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Limite de Credito";
            // 
            // CbxTipoUsuario
            // 
            this.CbxTipoUsuario.DataSource = this.tipoUsuarioBindingSource;
            this.CbxTipoUsuario.DisplayMember = "Descripcion";
            this.CbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoUsuario.FormattingEnabled = true;
            this.CbxTipoUsuario.Location = new System.Drawing.Point(106, 195);
            this.CbxTipoUsuario.Name = "CbxTipoUsuario";
            this.CbxTipoUsuario.Size = new System.Drawing.Size(128, 21);
            this.CbxTipoUsuario.TabIndex = 13;
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataMember = "Tipo_Usuario";
            this.tipoUsuarioBindingSource.DataSource = this.gestionCafeteriaDataSet1;
            // 
            // gestionCafeteriaDataSet1
            // 
            this.gestionCafeteriaDataSet1.DataSetName = "GestionCafeteriaDataSet1";
            this.gestionCafeteriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Usuario";
            // 
            // DtpFechaRegistro
            // 
            this.DtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaRegistro.Location = new System.Drawing.Point(106, 299);
            this.DtpFechaRegistro.Name = "DtpFechaRegistro";
            this.DtpFechaRegistro.Size = new System.Drawing.Size(128, 20);
            this.DtpFechaRegistro.TabIndex = 11;
            // 
            // CbxEstado
            // 
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CbxEstado.Location = new System.Drawing.Point(106, 353);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(128, 21);
            this.CbxEstado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Registro";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(106, 145);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(181, 20);
            this.TxtCedula.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cedula";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(106, 58);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(254, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Enabled = false;
            this.TxtIdUsuario.Location = new System.Drawing.Point(106, 16);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(114, 20);
            this.TxtIdUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // tipo_UsuarioTableAdapter
            // 
            this.tipo_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(106, 101);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(181, 20);
            this.txtClave.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Contraseña";
            // 
            // FrmUsuariosEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 495);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdGuadar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUsuariosEd";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuariosEd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCafeteriaDataSet1)).EndInit();
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
        private GestionCafeteriaDataSet1 gestionCafeteriaDataSet1;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private GestionCafeteriaDataSet1TableAdapters.Tipo_UsuarioTableAdapter tipo_UsuarioTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClave;
    }
}