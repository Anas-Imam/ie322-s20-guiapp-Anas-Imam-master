using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MY_FIRST_APP
{
    public partial class FrmPic : Form
    {
        Assembly _assembly;
        Stream _imageStream;

        public FrmPic()
        {
            InitializeComponent();
        }

        private void btnImageFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Anas_\\OneDrive\\سطح المكتب\\IE-256\\anas.jpg");
            }
            catch
            {
                MessageBox.Show("Image file not found");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void btnImageFromResource_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = Image.FromStream(_imageStream);
            }
            catch 
            {
                MessageBox.Show("Error creating image from Resource");
                
            }

        }

        private void FrmPic_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("MY_FIRST_APP.pic.photo_2020-02-29_13-16-58.jpg");
        }
    }
}
