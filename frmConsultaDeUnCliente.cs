using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prykaplanIEFI
{
    public partial class frmConsultaDeUnCliente : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        OleDbConnection conexion = new OleDbConnection();
        public frmConsultaDeUnCliente()
        {
            InitializeComponent();
        }
        private void listarNombre()
        {
            conexion.ConnectionString = ruta;

            DataTable dt = new DataTable();
            string selectBarrio = "Select * From Socio";
            OleDbCommand cmdBarrio = new OleDbCommand(selectBarrio, conexion);
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(cmdBarrio);
            daBarrio.SelectCommand = cmdBarrio;
            conexion.Open();
            daBarrio.Fill(dt);
            conexion.Close();

            lstNombre.DisplayMember = "Nombre_Apellido";
            lstNombre.ValueMember = "Dni_Socio";
            lstNombre.DataSource = dt;
        }

        private void frmConsultaUnCliente_Load(object sender, EventArgs e)
        {
            listarNombre();
            lstNombre.SelectedIndex = -1;
        }


        private void buscarActividad()
        {
            string actividad = lblActividad.Text;
            string cadenaActividad = "Select * From Actividad";

            OleDbCommand commandActividad = new OleDbCommand(cadenaActividad, conexion);
            OleDbDataReader lectorActividad = commandActividad.ExecuteReader();

            while (lectorActividad.Read())
            {
                if (Convert.ToString(lectorActividad["Codigo_Actividad"]) == actividad)
                {
                    lblActividad.Text = Convert.ToString(lectorActividad["Detalle_Actividad"]);
                }
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaDeUnCliente_Load(object sender, EventArgs e)
        {

        }

        private void cdmMos_Click(object sender, EventArgs e)
        {

        }
    }
}

