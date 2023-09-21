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
using ClosedXML.Excel;

namespace proyGim
{
    public partial class Form_socios : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Desktop1\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True");

        public Form_socios()
        {
            InitializeComponent();
        }

        private void Form_socios_Load(object sender, EventArgs e)
        {

            //cargar datos de la bd al dgv
            filldgv();

            //inicializar vacias las casillas
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

        private void filldgv()
        { 
            con.Open();
            string query = "SELECT * FROM socios";
            SqlDataAdapter adapter = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_socios.DataSource = dt;
            con.Close();

        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la celda actual pertenece a la columna de fecha ("Fecha")
            if (dgv_socios.Columns[e.ColumnIndex].Name == "fecha_nac" && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda actual
                //DateTime fecha = (DateTime)e.Value;

                // Verificar si la celda actual no es nula y es de tipo DateTime
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime fecha = (DateTime)e.Value;

                    // Formatear la fecha como cadena
                    e.Value = fecha.ToString("dd/MM/yyyy"); // O el formato deseado
                    e.FormattingApplied = true; // Marcar como formateado para evitar la recursión
                }

            }
        }


        private void button1_Click(object sender, EventArgs e) // botón aceptar
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [socios] " +
                "(nombre, apellido, dni, telefono, correo, direccion, sexo, fecha_nac, descripcion) " +
                "VALUES " +
                "(@nombre, @apellido, @dni, @telefono, @correo, @direccion, @sexo, @fecha_nac, @descripcion)";

            // Agrega los parámetros con sus valores correspondientes
            cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@apellido", txt_apellido.Text);
            cmd.Parameters.AddWithValue("@dni", txt_dni.Text);
            cmd.Parameters.AddWithValue("@telefono", txt_tel.Text);
            cmd.Parameters.AddWithValue("@correo", txt_correo.Text);
            cmd.Parameters.AddWithValue("@direccion", txt_direc.Text);
            cmd.Parameters.AddWithValue("@sexo", txt_sexo.Text);
            cmd.Parameters.AddWithValue("@fecha_nac", dtp_fecha_nac.Value);
            cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            // Actualizar el DataGridView
            filldgv();
            //dgv_socios.Refresh();
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



        private void button3_Click(object sender, EventArgs e) // botón borrar
        {
            // Verificar si hay una fila seleccionada
            if (dgv_socios.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada (la primera en este caso)
                DataGridViewRow selectedRow = dgv_socios.SelectedRows[0];

                // Obtener el ID o clave primaria de la fila que se eliminará
                int idToDelete = int.Parse(selectedRow.Cells["id_socio"].Value.ToString());

                // Eliminar la fila de la base de datos
                con.Open();
                string deleteQuery = "DELETE FROM socios WHERE id_socio = @id"; // Ajusta según tu esquema de base de datos
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                {
                    deleteCmd.Parameters.AddWithValue("@id", idToDelete);
                    deleteCmd.ExecuteNonQuery();
                }
                con.Close();

                // Eliminar la fila del DataGridView
                dgv_socios.Rows.Remove(selectedRow);

                // Actualizar el DataGridView después de eliminar
                dgv_socios.Refresh();
            }
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

        private void button4_Click(object sender, EventArgs e) // boton exportar excel
        {

            // Crear un nuevo libro de Excel
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Datos");

            // Obtener los nombres de las columnas del DataGridView y agregarlos a la hoja de trabajo
            for (int col = 1; col <= dgv_socios.Columns.Count; col++)
            {
                worksheet.Cell(1, col).Value = dgv_socios.Columns[col - 1].HeaderText;
            }

            // Recorrer las filas del DataGridView y agregar los datos a la hoja de trabajo
            for (int row = 0; row < dgv_socios.Rows.Count; row++)
            {
                for (int col = 0; col < dgv_socios.Columns.Count; col++)
                {
                    worksheet.Cell(row + 2, col + 1).Value = dgv_socios.Rows[row].Cells[col].Value.ToString();

                }
            }

            // Guardar el archivo de Excel en una ubicación específica
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Datos exportados a Excel correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button7_Click_1(object sender, EventArgs e) // boton volver a menu principal
        {

            this.Close();

        }
    }
}
