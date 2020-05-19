using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class frm_AddMember : Form
    {
        string ImagePath;
        public frm_AddMember()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                ImagePath = openFileDialog.FileName;
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void frm_AddMember_Activated(object sender, EventArgs e)
        {
            lbl_ID.Text = Member.GenerateID().ToString();
        }
    }
}
