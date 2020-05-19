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
    public partial class frm_AddPlan : Form
    {
        int daysLeft = 0;
        public frm_AddPlan()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_AddPlan_Load(object sender, EventArgs e)
        {
            GetDaysLeft(dt_Start.Value, dt_Expiry.Value);
        }

        private void GetDaysLeft(DateTime StartDate, DateTime EndDate)
        {
            daysLeft = Convert.ToInt32((EndDate - StartDate).TotalDays);
            if (daysLeft < 0)
            {
                MessageBox.Show("Expiry Date must be greater than Start Date!", "Wrong Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dt_Expiry.Value = dt_Start.Value.AddDays(1);
                lbl_Duration.Text = "1 day(s)";
                daysLeft = 1;
            }
            else
            {
                lbl_Duration.Text = daysLeft.ToString() + " day(s)";
            }
        }

        private void dt_Start_ValueChanged(object sender, EventArgs e)
        {
            GetDaysLeft(dt_Start.Value, dt_Expiry.Value);
        }

        private void dt_Expiry_ValueChanged(object sender, EventArgs e)
        {
            GetDaysLeft(dt_Start.Value, dt_Expiry.Value);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please Enter Name");
            }
            else
            {
                var plan = new Plan(txt_Name.Text, Convert.ToDouble(num_DiscountRate.Value), dt_Start.Value.ToShortDateString(), dt_Expiry.Value.ToShortDateString(), daysLeft);
            }
        }
    }
}
