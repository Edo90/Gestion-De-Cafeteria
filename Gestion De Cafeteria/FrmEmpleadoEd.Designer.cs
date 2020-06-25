namespace Gestion_De_Cafeteria
{
    partial class FrmEmpleadoEd
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
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salaryNumericTB = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cedulaTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comisionTB = new System.Windows.Forms.NumericUpDown();
            this.fechaIngresoTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.tandaComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionTB)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(423, 658);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(100, 66);
            this.CmdEliminar.TabIndex = 8;
            this.CmdEliminar.Text = "Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.Location = new System.Drawing.Point(271, 658);
            this.CmdGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(100, 66);
            this.CmdGuardar.TabIndex = 7;
            this.CmdGuardar.Text = "Guardar";
            this.CmdGuardar.UseVisualStyleBackColor = true;
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tandaComboBox);
            this.panel1.Controls.Add(this.estadoComboBox);
            this.panel1.Controls.Add(this.fechaIngresoTB);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comisionTB);
            this.panel1.Controls.Add(this.cedulaTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.salaryNumericTB);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(182, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 581);
            this.panel1.TabIndex = 6;
            // 
            // salaryNumericTB
            // 
            this.salaryNumericTB.DecimalPlaces = 2;
            this.salaryNumericTB.Location = new System.Drawing.Point(128, 228);
            this.salaryNumericTB.Name = "salaryNumericTB";
            this.salaryNumericTB.Size = new System.Drawing.Size(160, 22);
            this.salaryNumericTB.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(128, 182);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(160, 22);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(128, 129);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 22);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(128, 33);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(160, 22);
            this.txtID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // cedulaTB
            // 
            this.cedulaTB.Location = new System.Drawing.Point(128, 289);
            this.cedulaTB.Margin = new System.Windows.Forms.Padding(4);
            this.cedulaTB.Name = "cedulaTB";
            this.cedulaTB.Size = new System.Drawing.Size(160, 22);
            this.cedulaTB.TabIndex = 16;
            this.cedulaTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "% Comision";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 345);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tanda";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cedula";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comisionTB
            // 
            this.comisionTB.Location = new System.Drawing.Point(128, 396);
            this.comisionTB.Name = "comisionTB";
            this.comisionTB.Size = new System.Drawing.Size(160, 22);
            this.comisionTB.TabIndex = 18;
            // 
            // fechaIngresoTB
            // 
            this.fechaIngresoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fechaIngresoTB.Location = new System.Drawing.Point(128, 440);
            this.fechaIngresoTB.Margin = new System.Windows.Forms.Padding(4);
            this.fechaIngresoTB.Name = "fechaIngresoTB";
            this.fechaIngresoTB.ReadOnly = true;
            this.fechaIngresoTB.Size = new System.Drawing.Size(160, 22);
            this.fechaIngresoTB.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(33, 496);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(33, 440);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ingreso";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.estadoComboBox.Location = new System.Drawing.Point(128, 489);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(160, 24);
            this.estadoComboBox.TabIndex = 22;
            // 
            // tandaComboBox
            // 
            this.tandaComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.tandaComboBox.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.tandaComboBox.Location = new System.Drawing.Point(128, 338);
            this.tandaComboBox.Name = "tandaComboBox";
            this.tandaComboBox.Size = new System.Drawing.Size(160, 24);
            this.tandaComboBox.TabIndex = 23;
            // 
            // FrmEmpleadoEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 773);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdGuardar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmpleadoEd";
            this.Text = "FrmEmpleadoEd";
            this.Load += new System.EventHandler(this.FrmEmpleadoEd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown salaryNumericTB;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox cedulaTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox fechaIngresoTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown comisionTB;
        private System.Windows.Forms.ComboBox tandaComboBox;
    }
}