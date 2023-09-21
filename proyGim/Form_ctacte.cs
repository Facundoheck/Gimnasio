using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyGim
{
    public partial class Form_ctacte : Form
    {
        public Form_ctacte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // boton salir
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

        private void button2_Click(object sender, EventArgs e) // boton volver
        {
            this.Close();
        }

        private void Form_ctacte_Load(object sender, EventArgs e)
        {

        }
    }
}
