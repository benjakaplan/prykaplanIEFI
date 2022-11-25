namespace prykaplanIEFI
{
    partial class ListadoClientePorActividad
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
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblTotalSaldo = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMayorSaldo = new System.Windows.Forms.Label();
            this.lblPromedioSaldo = new System.Windows.Forms.Label();
            this.lblMenorSaldo = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cdmListar = new System.Windows.Forms.Button();
            this.cdmImprimir = new System.Windows.Forms.Button();
            this.cdmExplorar = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblTotal);
            this.mrcDatos.Controls.Add(this.lblPromedio);
            this.mrcDatos.Controls.Add(this.lblMenor);
            this.mrcDatos.Controls.Add(this.lblTotalSaldo);
            this.mrcDatos.Controls.Add(this.lblMayor);
            this.mrcDatos.Controls.Add(this.lblMayorSaldo);
            this.mrcDatos.Controls.Add(this.lblPromedioSaldo);
            this.mrcDatos.Controls.Add(this.lblMenorSaldo);
            this.mrcDatos.Location = new System.Drawing.Point(54, 226);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mrcDatos.Size = new System.Drawing.Size(439, 142);
            this.mrcDatos.TabIndex = 19;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(311, 84);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 26);
            this.lblTotal.TabIndex = 13;
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(88, 84);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 26);
            this.lblPromedio.TabIndex = 12;
            // 
            // lblMenor
            // 
            this.lblMenor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenor.Location = new System.Drawing.Point(311, 26);
            this.lblMenor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 26);
            this.lblMenor.TabIndex = 11;
            // 
            // lblTotalSaldo
            // 
            this.lblTotalSaldo.AutoSize = true;
            this.lblTotalSaldo.Location = new System.Drawing.Point(242, 91);
            this.lblTotalSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Size = new System.Drawing.Size(61, 13);
            this.lblTotalSaldo.TabIndex = 10;
            this.lblTotalSaldo.Text = "Total Saldo";
            // 
            // lblMayor
            // 
            this.lblMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor.Location = new System.Drawing.Point(88, 26);
            this.lblMayor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 26);
            this.lblMayor.TabIndex = 6;
            // 
            // lblMayorSaldo
            // 
            this.lblMayorSaldo.AutoSize = true;
            this.lblMayorSaldo.Location = new System.Drawing.Point(20, 33);
            this.lblMayorSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayorSaldo.Name = "lblMayorSaldo";
            this.lblMayorSaldo.Size = new System.Drawing.Size(36, 13);
            this.lblMayorSaldo.TabIndex = 4;
            this.lblMayorSaldo.Text = "Mayor";
            // 
            // lblPromedioSaldo
            // 
            this.lblPromedioSaldo.AutoSize = true;
            this.lblPromedioSaldo.Location = new System.Drawing.Point(20, 91);
            this.lblPromedioSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedioSaldo.Name = "lblPromedioSaldo";
            this.lblPromedioSaldo.Size = new System.Drawing.Size(51, 13);
            this.lblPromedioSaldo.TabIndex = 5;
            this.lblPromedioSaldo.Text = "Promedio";
            // 
            // lblMenorSaldo
            // 
            this.lblMenorSaldo.AutoSize = true;
            this.lblMenorSaldo.Location = new System.Drawing.Point(242, 33);
            this.lblMenorSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenorSaldo.Name = "lblMenorSaldo";
            this.lblMenorSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblMenorSaldo.TabIndex = 9;
            this.lblMenorSaldo.Text = "Menor";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(54, 55);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(439, 152);
            this.dgvClientes.TabIndex = 16;
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(111, 16);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(166, 21);
            this.lstActividad.TabIndex = 15;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(52, 18);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 13;
            this.lblActividad.Text = "Actividad";
            // 
            // cdmListar
            // 
            this.cdmListar.Location = new System.Drawing.Point(401, 16);
            this.cdmListar.Name = "cdmListar";
            this.cdmListar.Size = new System.Drawing.Size(71, 23);
            this.cdmListar.TabIndex = 14;
            this.cdmListar.Text = "Listar";
            this.cdmListar.UseVisualStyleBackColor = true;
            this.cdmListar.Click += new System.EventHandler(this.cdmListar_Click);
            // 
            // cdmImprimir
            // 
            this.cdmImprimir.Location = new System.Drawing.Point(142, 382);
            this.cdmImprimir.Name = "cdmImprimir";
            this.cdmImprimir.Size = new System.Drawing.Size(71, 23);
            this.cdmImprimir.TabIndex = 20;
            this.cdmImprimir.Text = "Imprimir";
            this.cdmImprimir.UseVisualStyleBackColor = true;
            // 
            // cdmExplorar
            // 
            this.cdmExplorar.Location = new System.Drawing.Point(401, 382);
            this.cdmExplorar.Name = "cdmExplorar";
            this.cdmExplorar.Size = new System.Drawing.Size(71, 23);
            this.cdmExplorar.TabIndex = 21;
            this.cdmExplorar.Text = "Explorar";
            this.cdmExplorar.UseVisualStyleBackColor = true;
            this.cdmExplorar.Click += new System.EventHandler(this.cdmExplorar_Click);
            // 
            // ListadoClientePorActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cdmExplorar);
            this.Controls.Add(this.cdmImprimir);
            this.Controls.Add(this.cdmListar);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.lblActividad);
            this.Name = "ListadoClientePorActividad";
            this.Text = "ListadoClientePorActividad";
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblTotalSaldo;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMayorSaldo;
        private System.Windows.Forms.Label lblPromedioSaldo;
        private System.Windows.Forms.Label lblMenorSaldo;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Button cdmListar;
        private System.Windows.Forms.Button cdmImprimir;
        private System.Windows.Forms.Button cdmExplorar;
    }
}