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
using proyGim.Models;

namespace proyGim
{
    public partial class Form_socios : Form
    {


        public Form_socios()
        {
            InitializeComponent();
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_socios_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_correo.Text = "";
            txt_direc.Text = "";
            txt_sexo.Text = "";
            //dtp_fecha_nac.Value = ;
            txt_tel.Text = "";
            txt_descripcion.Text = "";

            //Refrescar();
        }

        #region refrescar
        //private void Refrescar()
        //{
        //    using (GimnasioEntities db = new GimnasioEntities())
        //    {
        //        var lst = from d in db.socios
        //                  select d;
        //        dgv_socios.DataSource = lst.ToList();
        //    }

        //}
        #endregion

        private void button1_Click(object sender, EventArgs e) // boton aceptar
        {
            dgv_socios.Rows.Add(txt_nombre.Text,txt_apellido.Text,txt_dni.Text,txt_tel.Text,txt_correo.Text,txt_direc.Text,txt_sexo.Text,dtp_fecha_nac.Value,txt_descripcion.Text);



            //using (GimnasioEntities db = new GimnasioEntities())
            //{


            //    socios oSocios = new socios();
            //    oSocios.nombre = txt_nombre.Text;
            //    oSocios.apellido = txt_apellido.Text;
            //    oSocios.dni = txt_dni.Text;
            //    oSocios.correo = txt_correo.Text;
            //    oSocios.direccion = txt_direc.Text;
            //    oSocios.sexo = txt_sexo.Text;
            //    oSocios.fecha_nac = dtp_fecha_nac.Value;
            //    oSocios.telefono = txt_tel.Text;
            //    oSocios.descripcion = txt_descripcion.Text;

            //    if      
            //            (
                        
            //            txt_nombre.Text != ""
            //            && txt_apellido.Text != ""
            //            && txt_dni.Text != ""
            //            && txt_correo.Text != ""
            //            && txt_direc.Text != ""
            //            && txt_sexo.Text != ""
            //            //&& dtp_fecha_nac.Text != ""
            //            && txt_tel.Text != ""

            //            )

            //            db.socios.Add(oSocios);
            //            db.SaveChanges();

            //            txt_nombre.Text = "";
            //            txt_apellido.Text = "";
            //            txt_dni.Text = "";
            //            txt_correo.Text = "";
            //            //dtp_fecha_nac.Text = "";
            //            txt_tel.Text = "";
            //            txt_descripcion.Text = "";
            //            MessageBox.Show("Nuevo socio agregado");

             
            //}


            //{ 
            //    dataGrid_socios.Rows.Add(txt_nombre.Text,txt_apellido.Text,txt_dni.Text,txt_tel.Text,txt_fecha_nac.Text,txt_tel.Text,txt_descripcion.Text);

            //}
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // boton salir
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

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Delete()
        {
            foreach (DataGridViewRow item in this.dgv_socios.SelectedRows)
            {
                dgv_socios.Rows.RemoveAt(item.Index);
            }
        }
        private void button3_Click(object sender, EventArgs e) // boton borrar
        {
            Delete();
        }

        Bitmap bitmap;
        private void button6_Click(object sender, EventArgs e) // boton imprimir
        {
            int height = dgv_socios.Height;
            dgv_socios.Height = dgv_socios.RowCount * dgv_socios.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgv_socios.Width, dgv_socios.Height);
            dgv_socios.DrawToBitmap(bitmap, new Rectangle(0, 0, dgv_socios.Width, dgv_socios.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgv_socios.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void imprimirPlanillaDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int height = dgv_socios.Height;
            dgv_socios.Height = dgv_socios.RowCount * dgv_socios.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgv_socios.Width, dgv_socios.Height);
            dgv_socios.DrawToBitmap(bitmap, new Rectangle(0, 0, dgv_socios.Width, dgv_socios.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgv_socios.Height = height;
        }

        private void button8_Click(object sender, EventArgs e) // boton limpiar
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_correo.Text = "";
            //dtp_fecha_nac.Text = "";
            txt_tel.Text = "";
            txt_descripcion.Text = "";
            txt_sexo.Text = "";
            txt_direc.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) // boton salir desde el menu
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

        private void button7_Click(object sender, EventArgs e) // boton guardar
        {

        }
    }
}
