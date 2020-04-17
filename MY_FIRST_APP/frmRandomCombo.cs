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
    public partial class frmRandomCombo : Form
    {
        Random r = new Random();
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            cmbRandom1.ResetText();
            cmbRandom1.Items.Clear();
            RBLess500.Checked = false;
            RBLess500.Checked = false;

        }

        private void btnGenerate1_Click(object sender, EventArgs e)
        {
            cmbRandom1.ResetText();
            cmbRandom1.Items.Clear();
            for (int i = 0; i < r.Next(1,5) ; i++)

            cmbRandom1.Items.Add(r.Next(100, 999));
        }
    }
}
