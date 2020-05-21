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
        string ImagePath="";
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
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Surname.Text == "")
            {
                MessageBox.Show("Enter Surname", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Phone.Text == "")
            {
                MessageBox.Show("Enter Phone No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Email.Text == "")
            {
                MessageBox.Show("Enter Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Address.Text == "")
            {
                MessageBox.Show("Enter Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_Plan.SelectedIndex < 0)
            {
                MessageBox.Show("Select Plan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_SubFee.Text == "")
            {
                MessageBox.Show("Enter Subscription Fee", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Member member = new Member(int.Parse(lbl_ID.Text), txt_Name.Text, txt_Surname.Text, txt_Phone.Text, txt_Address.Text, txt_Email.Text, cmb_Plan.Text, lbl_Total.Text, ImagePath);
                AllClear();
            }
        } 

        private void frm_AddMember_Activated(object sender, EventArgs e)
        {
            lbl_ID.Text = Member.GenerateID().ToString();
            Plan.FillCombo(cmb_Plan);
        }

        private void txt_SubFee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float subFee, vat=0;
                if (float.TryParse(txt_SubFee.Text, out subFee))
                {
                    vat = (subFee * 14 / 100);
                }
                lbl_VAT.Text =Convert.ToString(vat);
                lbl_Total.Text = Convert.ToString(subFee + vat);
            }
            catch (Exception)
            {

            }
           
        }
        private void AllClear()
        {
            txt_Name.Text = "";
            txt_Surname.Text = "";
            txt_Phone.Text = "";
            txt_Email.Text = "";
            txt_Address.Text = "";
            txt_SubFee.Text = "";
            cmb_Plan.SelectedIndex = 0;
        }
    }
}
