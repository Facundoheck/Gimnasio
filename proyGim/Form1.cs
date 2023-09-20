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

                String cmbItemValue = cmb_rol.SelectedItem.ToString();

                if (dtable.Rows.Count > 0)
                {
                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        if (dtable.Rows[i]["rol"].ToString() == cmbItemValue)
                        {
                            this.Hide();
                            Form_main fm = new Form_main();
                            fm.Show();
                        }

                    }
                    //user = txt_usuario.Text;
                    //pass = txt_contra.Text;
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Quiere salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gimnasioDataSet1.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.gimnasioDataSet1.usuarios);
            // TODO: This line of code loads data into the 'gimnasioDataSet.socios' table. You can move, or remove it, as needed.
            this.sociosTableAdapter.Fill(this.gimnasioDataSet.socios);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy(this.gimnasioDataSet1.usuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
