using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prykaplanIEFI
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }
        private void tsiAgregar_Click(object sender, EventArgs e)
        {
            new frmAgregarClientes().ShowDialog();
        }

        private void tsiModificar_Click(object sender, EventArgs e)
        {
            new frmBusquedaDeUnCliente().ShowDialog();
        }

        

        private void tsiListadoClientesBarrio_Click(object sender, EventArgs e)
        {
            new frmClientesDeUnBarrio().ShowDialog();
        }

        private void tsiListadoClientesActividad_Click(object sender, EventArgs e)
        {
            new ListadoClientePorActividad().ShowDialog();
        }

        private void tsiListadoClientesDeudores_Click(object sender, EventArgs e)
        {
            new FrmClientesDeudores().ShowDialog();
        }

        private void tsiConsultaCliente_Click(object sender, EventArgs e)
        {
            new frmConsultaDeUnCliente().ShowDialog();
        }
        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
