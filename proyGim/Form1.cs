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

        SqlConnection conn = new SqlConnection(@"Data Source=Desktop1\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True");
        //SqlDataAdapter da;
        //SqlCommand cmd;


        //public static class ConexionBD
        //{
        //    public static SqlConnection ObtenerConexion()
        //    {
        //        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\source\repos\proyGim\proyGim\Gimnasio.mdf;Integrated Security=True;";
        //        SqlConnection connection = new SqlConnection(connectionString);
        //        return connection;
        //    }
        //}


    public Form1()
        {

            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {



            //con.Open();
            //cmd = new SqlCommand("SELECT * FROM usuarios WHERE usuario='"+txt_usuario.Text+"'and cont='"+txt_contra.Text+"'", con);
            //da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //int i = ds.Tables[0].Rows.Count;
            //if (i == 1)
            //{
            //    this.Hide();
            //    Form_main fm = new Form_main();
            //    fm.Show();
            //}



            //if (textBox1.Text == "admin" && textBox2.Text == "admin")
            //{
            //    this.Hide();
            //    Form_main fm = new Form_main();
            //    fm.Show();

            //}
            //else
            //{
            //    MessageBox.Show("El usuario o la contraseña no son correctos");
            //}
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            String user, pass;

            user = txt_usuario.Text;
            pass = txt_contra.Text;

            try
            {
                String query = "SELECT * FROM usuarios WHERE usuario='" + txt_usuario.Text + "'and cont='" + txt_contra.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                da.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    user = txt_usuario.Text;
                    pass = txt_contra.Text;

                    this.Hide();
                    Form_main fm = new Form_main();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_usuario.Clear();
                    txt_contra.Clear();

                }


            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
