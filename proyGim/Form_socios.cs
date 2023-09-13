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
            // TODO: This line of code loads data into the 'gimnasioDataSet.socios' table. You can move, or remove it, as needed.
            this.sociosTableAdapter.Fill(this.gimnasioDataSet.socios);

        }
    }
}
