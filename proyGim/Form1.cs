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
    public partial class Form1 : Form
    {

        public static class ConexionBD
        {
            public static SqlConnection ObtenerConexion()
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\source\repos\proyGim\proyGim\Gimnasio.mdf;Integrated Security=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
        }


    public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                Form2 fm = new Form2();
                fm.Show();

            }
            else
            {
                MessageBox.Show("El usuario o la contraseña no son correctos");
            }
        }
    }
}
