using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;


namespace prykaplanIEFI
{
    public partial class frmAgregarClientes : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        int[] vecDni = new int[1000];
        OleDbConnection conexion = new OleDbConnection();

        public frmAgregarClientes()
        {
            InitializeComponent();
        }

        private void cdmCargar_Click(object sender, EventArgs e)
        {

            string barrio = lstBarrio.Text;
            int codigo = Convert.ToInt32(txtDni.Text);
            string actividad = lstActividad.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string saldo = txtSaldo.Text;

            conexion.ConnectionString = ruta;
            conexion.Open();

            string insert = "INSERT INTO Socio(Dni_Socio,Nombre_Apellido,Direccion,Codigo_Barrio,Codigo_Actividad,Saldo)" +
                "VALUES(@Dni, @Nombre, @Direccion, @Barrio, @Actividad, @Saldo)";

            //Verifica que no se agrege el mismo DNI 
            if (vecDni.Contains(codigo))
            {
                MessageBox.Show("Este Usuario ya se encuentra registrado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazInicial();
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand(insert, conexion);

                cmd.Parameters.AddWithValue("@Dni", codigo);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Direccion", direccion);

                //Buscar código barrio
                string selectBarrio = "Select * From Barrio";

                OleDbCommand commandBarrio = new OleDbCommand(selectBarrio, conexion);
                OleDbDataReader lectorBarrio = commandBarrio.ExecuteReader();

                while (lectorBarrio.Read())
                {
                    if (Convert.ToString(lectorBarrio["Detalle_Barrio"]) == barrio)
                    {
                        cmd.Parameters.AddWithValue("@Barrio", lectorBarrio["Codigo_Barrio"]);
                    }
                }

                //Buscar código actividad
                string selectactividad = "SELECT * FROM Actividad";

                OleDbCommand commandActividad = new OleDbCommand(selectactividad, conexion);
                OleDbDataReader lectorActividad = commandActividad.ExecuteReader();

                while (lectorActividad.Read())
                {
                    if (Convert.ToString(lectorActividad["Detalle_Actividad"]) == actividad)
                    {
                        cmd.Parameters.AddWithValue("@Actividad", lectorActividad["Codigo_Actividad"]);
                    }
                }

                cmd.Parameters.AddWithValue("@Saldo", saldo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Socio registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }

            conexion.Close();
        }

        private void moverVector()
        {
            int indice = 0;
            conexion.ConnectionString = ruta;

            //Muevo los DNI a un vector
            string selectDNI = "SELECT Dni_Socio FROM Socio";
            OleDbCommand cmdDNI = new OleDbCommand(selectDNI, conexion);

            conexion.Open();

            OleDbDataReader objLector = cmdDNI.ExecuteReader();

            while (objLector.Read())
            {
                vecDni[indice] = Convert.ToInt32(objLector[0]);
                indice++;
            }

            conexion.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtSaldo.Text = "";
        }

        private void agregarListas()
        {
            conexion.ConnectionString = ruta;
            conexion.Open();
            DataTable tablaBarrio = new DataTable();
            string selectBarrio = "Select * From Barrio";
            OleDbCommand cmdBarrio = new OleDbCommand(selectBarrio, conexion);
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(cmdBarrio);
            daBarrio.SelectCommand = cmdBarrio;
            daBarrio.Fill(tablaBarrio);
            lstBarrio.DisplayMember = "Detalle_Barrio";
            lstBarrio.ValueMember = "Codigo_Barrio";
            lstBarrio.DataSource = tablaBarrio;
            ;
            DataTable tablaActividad = new DataTable();
            string selectActividad = "Select * From Actividad";
            OleDbCommand cmdActividad = new OleDbCommand(selectActividad, conexion);
            OleDbDataAdapter daActividad = new OleDbDataAdapter(cmdActividad);
            daActividad.SelectCommand = cmdActividad;
            daActividad.Fill(tablaActividad);
            lstActividad.DisplayMember = "Detalle_Actividad";
            lstActividad.ValueMember = "Codigo_Actividad";
            lstActividad.DataSource = tablaActividad;
            conexion.Close();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            agregarListas();
            interfazInicial();
            txtDni.Focus();
            moverVector();
        }

        private void interfazInicial()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtSaldo.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtDni.Focus();
        }

        private void validar()
        {
            if (txtDni.Text != string.Empty && txtNombre.Text != string.Empty && txtDireccion.Text != string.Empty && txtSaldo.Text !=
                string.Empty && lstActividad.Text != string.Empty && lstBarrio.Text != string.Empty)
            {
                cdmCargar.Enabled = true;
            }
            else
            {
               cdmCargar.Enabled = false;
            }
        }

    }
}

