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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rodYellow1.Checked == true)

                rodYellow1.ForeColor = Color.FromName("yellow");
            else
                rodYellow1.ForeColor = Color.FromName("Black");


           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRadio_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rodRed1.Checked == true)
            
                rodRed1.ForeColor = Color.FromArgb(255, 0, 0);
                else
                    rodRed1.ForeColor = Color.FromName("Black");
            
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rodGreen1.Checked == true)

                rodGreen1.ForeColor = Color.FromName("green");
            else
                rodGreen1.ForeColor = Color.FromName("Black");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rodBlue1.Checked == true)

                rodBlue1.ForeColor = Color.FromName("blue");
            else
                rodBlue1.ForeColor = Color.FromName("Black");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rodBlue1.ForeColor = Color.FromName("Black");
            rodGreen1.ForeColor = Color.FromName("Black");
            rodYellow1.ForeColor = Color.FromName("Black");
            rodRed1.ForeColor = Color.FromName("Black");
        }
    }
}
