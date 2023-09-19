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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void btn_socios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_socios fm = new Form_socios();
            fm.Show();
        }
    }
}
