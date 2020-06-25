namespace Gestion_De_Cafeteria
{
    partial class ArticulosFormEd
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
            this.idTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTb = new System.Windows.Forms.TextBox();
            this.marcaCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costoN = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.proveedorCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.estadoCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.existenciaCb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.costoN)).BeginInit();
            this.SuspendLayout();
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(205, 112);
            this.idTb.Name = "idTb";
            this.idTb.ReadOnly = true;
            this.idTb.Size = new System.Drawing.Size(172, 22);
            this.idTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // descriptionTb
            // 
            this.descriptionTb.Location = new System.Drawing.Point(205, 169);
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.Size = new System.Drawing.Size(172, 22);
            this.descriptionTb.TabIndex = 2;
            // 
            // marcaCb
            // 
            this.marcaCb.FormattingEnabled = true;
            this.marcaCb.Location = new System.Drawing.Point(205, 217);
            this.marcaCb.Name = "marcaCb";
            this.marcaCb.Size = new System.Drawing.Size(172, 24);
            this.marcaCb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca";
            // 
            // costoN
            // 
            this.costoN.Location = new System.Drawing.Point(205, 282);
            this.costoN.Name = "costoN";
            this.costoN.Size = new System.Drawing.Size(172, 22);
            this.costoN.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Proveedor";
            // 
            // proveedorCb
            // 
            this.proveedorCb.FormattingEnabled = true;
            this.proveedorCb.Location = new System.Drawing.Point(205, 337);
            this.proveedorCb.Name = "proveedorCb";
            this.proveedorCb.Size = new System.Drawing.Size(172, 24);
            this.proveedorCb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado";
            // 
            // estadoCb
            // 
            this.estadoCb.FormattingEnabled = true;
            this.estadoCb.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.estadoCb.Location = new System.Drawing.Point(205, 451);
            this.estadoCb.Name = "estadoCb";
            this.estadoCb.Size = new System.Drawing.Size(172, 24);
            this.estadoCb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Existencia";
            // 
            // existenciaCb
            // 
            this.existenciaCb.FormattingEnabled = true;
            this.existenciaCb.Items.AddRange(new object[] {
            "Existente",
            "No Existente"});
            this.existenciaCb.Location = new System.Drawing.Point(205, 396);
            this.existenciaCb.Name = "existenciaCb";
            this.existenciaCb.Size = new System.Drawing.Size(172, 24);
            this.existenciaCb.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 481);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulo";
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(125, 554);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(100, 62);
            this.guardarBtn.TabIndex = 15;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(277, 554);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(100, 62);
            this.eliminarBtn.TabIndex = 16;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // ArticulosFormEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 637);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.existenciaCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estadoCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.proveedorCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costoN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.marcaCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArticulosFormEd";
            this.Text = "ArticulosFormEd";
            this.Load += new System.EventHandler(this.ArticulosFormEd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costoN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTb;
        private System.Windows.Forms.ComboBox marcaCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown costoN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox proveedorCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox estadoCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox existenciaCb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button eliminarBtn;
    }
}