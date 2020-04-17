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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            cmbDays.Items.Add("Sunday");
            cmbDays.Items.Add("Monday");
            cmbDays.Items.Add("Tuesday");
            cmbDays.Items.Add("Wednesday");
            cmbDays.Items.Add("Thursday");
            cmbDays.Items.Add("Friday");
            cmbDays.Items.Add("Saturday");
            cmbDays.Items.Add("Funday");
            cmbDays.Items.Add("Examday");
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count>=1)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Can't remove last item");
            }
        }

        private void btnShowSelected1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.Text);
        }

        private void btnShowSelected2_Click(object sender, EventArgs e)
        {
            string itemText = cmbDays.GetItemText(cmbDays.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void btnRemove2ndLast_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 2)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Can't remove 2ast item");
            }
        }

        private void btnShowSelected3_Click(object sender, EventArgs e)
        {
            var item = cmbDays.SelectedItem;
            if (item != null)
                MessageBox.Show(item.ToString());
        }

        private void btnRemoveByIndex_Click(object sender, EventArgs e)
        {
            cmbDays.Items.RemoveAt(1);
        }

        private void btnRemoveByName_Click(object sender, EventArgs e)
        {
            cmbDays.Items.Remove("Friday");
        }
    }
}
