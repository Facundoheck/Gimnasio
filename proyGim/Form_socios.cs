using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyGim
{
    public partial class Form_socios : Form
    {

        private string connectionString = @"Data Source=Desktop1\SQLEXPRESS;AttachDbFilename=C:\Users\Usuario\source\repos\proyGim\BD\Gimnasio.mdf;Integrated Security=True;";


        public Form_socios()
        {
            InitializeComponent();
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_socios_Load(object sender, EventArgs e)
        {
            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Definir una consulta SQL
                string query = "SELECT * FROM socios"; // Reemplaza "TuTabla" con el nombre de la tabla que deseas consultar

                // Crear un adaptador de datos y un DataTable para almacenar los resultados
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Llenar el DataTable con los datos de la consulta
                adapter.Fill(dataTable);

                // Enlazar el DataGridView con el DataTable o mostrar los datos en el control que desees
                dataGrid_socios.DataSource = dataTable;

                // Cerrar la conexión
                connection.Close();
            }
        }

        //private void Form_socios_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'gimnasioDataSet.socios' table. You can move, or remove it, as needed.
        //    this.sociosTableAdapter.Fill(this.gimnasioDataSet.socios);

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != ""
                    && txt_apellido.Text != ""
                    && txt_dni.Text != ""
                    && txt_correo.Text != ""
                    && txt_direc.Text != ""
                    && txt_sexo.Text != ""
                    && txt_fecha_nac.Text != ""
                    && txt_tel.Text != "")
            { 
                dataGrid_socios.Rows.Add(txt_nombre.Text,txt_apellido.Text,txt_dni.Text,txt_tel.Text,txt_fecha_nac.Text,txt_tel.Text,txt_descripcion.Text);
                txt_nombre.Text = "";
                txt_apellido.Text = "";
                txt_dni.Text = "";
                txt_correo.Text = "";
                txt_fecha_nac.Text = "";
                txt_tel.Text = "";
                txt_descripcion.Text = "";
                MessageBox.Show("Nuevo socio agregado");
            }
        }
    }
}
