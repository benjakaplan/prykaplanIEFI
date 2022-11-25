namespace prykaplanIEFI
{
    partial class frmprincipal
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
            this.msInicio = new System.Windows.Forms.MenuStrip();
            this.tsmSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListadoClientesActividad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListadoClientesDeudores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.tsiConsultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListadoClientesBarrio = new System.Windows.Forms.ToolStripMenuItem();
            this.msInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // msInicio
            // 
            this.msInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSocios,
            this.tsmConsultas});
            this.msInicio.Location = new System.Drawing.Point(0, 0);
            this.msInicio.Name = "msInicio";
            this.msInicio.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.msInicio.Size = new System.Drawing.Size(355, 24);
            this.msInicio.TabIndex = 15;
            this.msInicio.Text = "menuStrip1";
            // 
            // tsmSocios
            // 
            this.tsmSocios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAgregar});
            this.tsmSocios.Name = "tsmSocios";
            this.tsmSocios.Size = new System.Drawing.Size(53, 22);
            this.tsmSocios.Text = "Socios";
            // 
            // tsiAgregar
            // 
            this.tsiAgregar.Name = "tsiAgregar";
            this.tsiAgregar.Size = new System.Drawing.Size(180, 22);
            this.tsiAgregar.Text = "Agregar";
            // 
            // tsmConsultas
            // 
            this.tsmConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiListadoClientesBarrio,
            this.tsiListadoClientesActividad,
            this.tsiListadoClientesDeudores,
            this.tsSeparador,
            this.tsiConsultaCliente});
            this.tsmConsultas.Name = "tsmConsultas";
            this.tsmConsultas.Size = new System.Drawing.Size(71, 22);
            this.tsmConsultas.Text = "Consultas";
            // 
            // tsiListadoClientesActividad
            // 
            this.tsiListadoClientesActividad.Name = "tsiListadoClientesActividad";
            this.tsiListadoClientesActividad.Size = new System.Drawing.Size(252, 22);
            this.tsiListadoClientesActividad.Text = "Listado de clientes por actividad...";
            // 
            // tsiListadoClientesDeudores
            // 
            this.tsiListadoClientesDeudores.Name = "tsiListadoClientesDeudores";
            this.tsiListadoClientesDeudores.Size = new System.Drawing.Size(252, 22);
            this.tsiListadoClientesDeudores.Text = "Listado de clientes deudores...";
            // 
            // tsSeparador
            // 
            this.tsSeparador.Name = "tsSeparador";
            this.tsSeparador.Size = new System.Drawing.Size(249, 6);
            // 
            // tsiConsultaCliente
            // 
            this.tsiConsultaCliente.Name = "tsiConsultaCliente";
            this.tsiConsultaCliente.Size = new System.Drawing.Size(252, 22);
            this.tsiConsultaCliente.Text = "Consulta de un cliente...";
            // 
            // tsiListadoClientesBarrio
            // 
            this.tsiListadoClientesBarrio.Name = "tsiListadoClientesBarrio";
            this.tsiListadoClientesBarrio.Size = new System.Drawing.Size(252, 22);
            this.tsiListadoClientesBarrio.Text = "Listado de clientes por barrio...";
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 142);
            this.Controls.Add(this.msInicio);
            this.Name = "frmprincipal";
            this.Text = "frmprincipal";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.msInicio.ResumeLayout(false);
            this.msInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmSocios;
        private System.Windows.Forms.ToolStripMenuItem tsiAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultas;
        private System.Windows.Forms.ToolStripMenuItem tsiListadoClientesActividad;
        private System.Windows.Forms.ToolStripMenuItem tsiListadoClientesDeudores;
        private System.Windows.Forms.ToolStripSeparator tsSeparador;
        private System.Windows.Forms.ToolStripMenuItem tsiConsultaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsiListadoClientesBarrio;
    }
}