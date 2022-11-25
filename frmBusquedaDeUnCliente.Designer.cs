namespace prykaplanIEFI
{
    partial class frmBusquedaDeUnCliente
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
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.MaskedTextBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cdmBuscar = new System.Windows.Forms.Button();
            this.cdmEliminar = new System.Windows.Forms.Button();
            this.cdmModificar = new System.Windows.Forms.Button();
            this.cdmGuardar = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(194, 31);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Mask = "0000";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(52, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtSaldo);
            this.mrcDatos.Controls.Add(this.lstActividad);
            this.mrcDatos.Controls.Add(this.lstBarrio);
            this.mrcDatos.Controls.Add(this.txtDireccion);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblSaldo);
            this.mrcDatos.Controls.Add(this.lblActividad);
            this.mrcDatos.Controls.Add(this.lblBarrio);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Location = new System.Drawing.Point(64, 59);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mrcDatos.Size = new System.Drawing.Size(329, 228);
            this.mrcDatos.TabIndex = 11;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos del cliente";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldo.Location = new System.Drawing.Point(92, 191);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldo.Mask = "00000000000";
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(90, 20);
            this.txtSaldo.TabIndex = 9;
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(92, 151);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(143, 21);
            this.lstActividad.TabIndex = 12;
            // 
            // lstBarrio
            // 
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(92, 111);
            this.lstBarrio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(143, 21);
            this.lstBarrio.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(92, 72);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(215, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(92, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(21, 192);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(76, 13);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo            $";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(21, 153);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 3;
            this.lblActividad.Text = "Actividad";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(21, 113);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 2;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 73);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(85, 32);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(91, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo del cliente";
            // 
            // cdmBuscar
            // 
            this.cdmBuscar.Location = new System.Drawing.Point(375, 28);
            this.cdmBuscar.Name = "cdmBuscar";
            this.cdmBuscar.Size = new System.Drawing.Size(75, 23);
            this.cdmBuscar.TabIndex = 16;
            this.cdmBuscar.Text = "Buscar";
            this.cdmBuscar.UseVisualStyleBackColor = true;
            // 
            // cdmEliminar
            // 
            this.cdmEliminar.Location = new System.Drawing.Point(74, 305);
            this.cdmEliminar.Name = "cdmEliminar";
            this.cdmEliminar.Size = new System.Drawing.Size(75, 23);
            this.cdmEliminar.TabIndex = 17;
            this.cdmEliminar.Text = "Eliminar";
            this.cdmEliminar.UseVisualStyleBackColor = true;
            // 
            // cdmModificar
            // 
            this.cdmModificar.Location = new System.Drawing.Point(182, 308);
            this.cdmModificar.Name = "cdmModificar";
            this.cdmModificar.Size = new System.Drawing.Size(75, 23);
            this.cdmModificar.TabIndex = 18;
            this.cdmModificar.Text = "Modificar";
            this.cdmModificar.UseVisualStyleBackColor = true;
            // 
            // cdmGuardar
            // 
            this.cdmGuardar.Location = new System.Drawing.Point(355, 308);
            this.cdmGuardar.Name = "cdmGuardar";
            this.cdmGuardar.Size = new System.Drawing.Size(75, 23);
            this.cdmGuardar.TabIndex = 19;
            this.cdmGuardar.Text = "Guardar";
            this.cdmGuardar.UseVisualStyleBackColor = true;
            this.cdmGuardar.Click += new System.EventHandler(this.cdmGuardar_Click);
            // 
            // frmBusquedaDeUnCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 374);
            this.Controls.Add(this.cdmGuardar);
            this.Controls.Add(this.cdmModificar);
            this.Controls.Add(this.cdmEliminar);
            this.Controls.Add(this.cdmBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmBusquedaDeUnCliente";
            this.Text = "frmBusquedaDeUnCliente";
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.MaskedTextBox txtSaldo;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button cdmBuscar;
        private System.Windows.Forms.Button cdmEliminar;
        private System.Windows.Forms.Button cdmModificar;
        private System.Windows.Forms.Button cdmGuardar;
    }
}