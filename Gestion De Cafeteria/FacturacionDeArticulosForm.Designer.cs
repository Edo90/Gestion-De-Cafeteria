namespace Gestion_De_Cafeteria
{
    partial class FacturacionDeArticulosForm
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
            this.agregarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.TxtDatoABuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvFacturacion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(847, 100);
            this.agregarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(83, 84);
            this.agregarBtn.TabIndex = 7;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(708, 100);
            this.buscarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(83, 84);
            this.buscarBtn.TabIndex = 6;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // TxtDatoABuscar
            // 
            this.TxtDatoABuscar.Location = new System.Drawing.Point(274, 135);
            this.TxtDatoABuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDatoABuscar.Name = "TxtDatoABuscar";
            this.TxtDatoABuscar.Size = new System.Drawing.Size(376, 22);
            this.TxtDatoABuscar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dato a Buscar";
            // 
            // DgvFacturacion
            // 
            this.DgvFacturacion.AllowUserToAddRows = false;
            this.DgvFacturacion.AllowUserToDeleteRows = false;
            this.DgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturacion.Location = new System.Drawing.Point(147, 233);
            this.DgvFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.DgvFacturacion.Name = "DgvFacturacion";
            this.DgvFacturacion.ReadOnly = true;
            this.DgvFacturacion.RowHeadersWidth = 51;
            this.DgvFacturacion.Size = new System.Drawing.Size(783, 313);
            this.DgvFacturacion.TabIndex = 8;
            this.DgvFacturacion.DoubleClick += new System.EventHandler(this.DgvFacturacion_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(104, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 500);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturacion";
            // 
            // FacturacionDeArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 651);
            this.Controls.Add(this.DgvFacturacion);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.TxtDatoABuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturacionDeArticulosForm";
            this.Text = "FacturacionDeArticulosForm";
            this.Activated += new System.EventHandler(this.FacturacionDeArticulosForm_Activated);
            this.Load += new System.EventHandler(this.FacturacionDeArticulosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox TxtDatoABuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvFacturacion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}