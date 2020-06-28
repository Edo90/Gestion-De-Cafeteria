namespace Gestion_De_Cafeteria
{
    partial class FacturacionDeArticulosEdForm
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
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.articuloCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empleadoCb = new System.Windows.Forms.ComboBox();
            this.usuarioCb = new System.Windows.Forms.ComboBox();
            this.fechaDeVentaTb = new System.Windows.Forms.TextBox();
            this.montoTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unidadesVendidasTb = new System.Windows.Forms.NumericUpDown();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comentarioTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesVendidasTb)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(398, 635);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(100, 62);
            this.eliminarBtn.TabIndex = 33;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(238, 635);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(100, 62);
            this.guardarBtn.TabIndex = 32;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Unidades Vendidas";
            // 
            // articuloCb
            // 
            this.articuloCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articuloCb.FormattingEnabled = true;
            this.articuloCb.Location = new System.Drawing.Point(177, 146);
            this.articuloCb.Name = "articuloCb";
            this.articuloCb.Size = new System.Drawing.Size(172, 24);
            this.articuloCb.TabIndex = 21;
            this.articuloCb.SelectedIndexChanged += new System.EventHandler(this.articuloCb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id";
            // 
            // idTb
            // 
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTb.Location = new System.Drawing.Point(177, 45);
            this.idTb.Name = "idTb";
            this.idTb.ReadOnly = true;
            this.idTb.Size = new System.Drawing.Size(172, 22);
            this.idTb.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha de Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Articulo";
            // 
            // empleadoCb
            // 
            this.empleadoCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoCb.FormattingEnabled = true;
            this.empleadoCb.Location = new System.Drawing.Point(177, 102);
            this.empleadoCb.Name = "empleadoCb";
            this.empleadoCb.Size = new System.Drawing.Size(172, 24);
            this.empleadoCb.TabIndex = 0;
            // 
            // usuarioCb
            // 
            this.usuarioCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioCb.FormattingEnabled = true;
            this.usuarioCb.Location = new System.Drawing.Point(177, 205);
            this.usuarioCb.Name = "usuarioCb";
            this.usuarioCb.Size = new System.Drawing.Size(172, 24);
            this.usuarioCb.TabIndex = 34;
            // 
            // fechaDeVentaTb
            // 
            this.fechaDeVentaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDeVentaTb.Location = new System.Drawing.Point(177, 272);
            this.fechaDeVentaTb.Name = "fechaDeVentaTb";
            this.fechaDeVentaTb.ReadOnly = true;
            this.fechaDeVentaTb.Size = new System.Drawing.Size(172, 22);
            this.fechaDeVentaTb.TabIndex = 35;
            // 
            // montoTb
            // 
            this.montoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTb.Location = new System.Drawing.Point(177, 331);
            this.montoTb.Name = "montoTb";
            this.montoTb.Size = new System.Drawing.Size(172, 22);
            this.montoTb.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unidadesVendidasTb);
            this.groupBox1.Controls.Add(this.estadoCheckBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comentarioTb);
            this.groupBox1.Controls.Add(this.montoTb);
            this.groupBox1.Controls.Add(this.fechaDeVentaTb);
            this.groupBox1.Controls.Add(this.usuarioCb);
            this.groupBox1.Controls.Add(this.articuloCb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.empleadoCb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(172, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 557);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // unidadesVendidasTb
            // 
            this.unidadesVendidasTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadesVendidasTb.Location = new System.Drawing.Point(177, 382);
            this.unidadesVendidasTb.Name = "unidadesVendidasTb";
            this.unidadesVendidasTb.Size = new System.Drawing.Size(172, 22);
            this.unidadesVendidasTb.TabIndex = 42;
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.AutoSize = true;
            this.estadoCheckBox.Checked = true;
            this.estadoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCheckBox.Location = new System.Drawing.Point(177, 462);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(67, 21);
            this.estadoCheckBox.TabIndex = 41;
            this.estadoCheckBox.Text = "activo";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Comentario";
            // 
            // comentarioTb
            // 
            this.comentarioTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentarioTb.Location = new System.Drawing.Point(177, 428);
            this.comentarioTb.Name = "comentarioTb";
            this.comentarioTb.Size = new System.Drawing.Size(172, 22);
            this.comentarioTb.TabIndex = 38;
            // 
            // FacturacionDeArticulosEdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 760);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturacionDeArticulosEdForm";
            this.Text = "FacturacionDeArticulosEdForm";
            this.Load += new System.EventHandler(this.FacturacionDeArticulosEdForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesVendidasTb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox articuloCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox empleadoCb;
        private System.Windows.Forms.ComboBox usuarioCb;
        private System.Windows.Forms.TextBox fechaDeVentaTb;
        private System.Windows.Forms.TextBox montoTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox comentarioTb;
        private System.Windows.Forms.NumericUpDown unidadesVendidasTb;
    }
}