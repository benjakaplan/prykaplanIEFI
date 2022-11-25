namespace prykaplanIEFI
{
    partial class FrmClientesDeudores
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
            this.dgvClientesDeudores = new System.Windows.Forms.DataGridView();
            this.cdmListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesDeudores
            // 
            this.dgvClientesDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesDeudores.Location = new System.Drawing.Point(36, 12);
            this.dgvClientesDeudores.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvClientesDeudores.Name = "dgvClientesDeudores";
            this.dgvClientesDeudores.RowHeadersWidth = 51;
            this.dgvClientesDeudores.RowTemplate.Height = 24;
            this.dgvClientesDeudores.Size = new System.Drawing.Size(355, 199);
            this.dgvClientesDeudores.TabIndex = 9;
            // 
            // cdmListar
            // 
            this.cdmListar.Location = new System.Drawing.Point(344, 217);
            this.cdmListar.Name = "cdmListar";
            this.cdmListar.Size = new System.Drawing.Size(71, 23);
            this.cdmListar.TabIndex = 10;
            this.cdmListar.Text = "Listar";
            this.cdmListar.UseVisualStyleBackColor = true;
            this.cdmListar.Click += new System.EventHandler(this.cdmListar_Click);
            // 
            // FrmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 242);
            this.Controls.Add(this.cdmListar);
            this.Controls.Add(this.dgvClientesDeudores);
            this.Name = "FrmClientesDeudores";
            this.Text = "FrmClientesDeudores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesDeudores;
        private System.Windows.Forms.Button cdmListar;
    }
}