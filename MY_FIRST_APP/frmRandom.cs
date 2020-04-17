using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_FIRST_APP
{
    public partial class frmRandom : Form
    {
        Random y = new Random();
        public frmRandom()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnGeneraleRandomColor_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);
            lblrgb.Text = Convert.ToString(r) + "_" + Convert.ToString(g) + "_" + Convert.ToString(b);
            btnGeneraleRandomColor.BackColor = Color.FromArgb(r, g, b);
        }

        private void btnRandomNumber_Click(object sender, EventArgs e)
        {
            btnRandomNumber.Text = Convert.ToString(y.Next(1, 100));
            
        }
    }
}
