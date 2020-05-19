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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AddMember_Click(object sender, EventArgs e)
        {
            frm_AddMember form = new frm_AddMember();
            form.ShowDialog();
        }

        private void btn_AddPlan_Click(object sender, EventArgs e)
        {
            frm_AddPlan form = new frm_AddPlan();
            form.ShowDialog();
        }

        private void btn_ShowMembers_Click(object sender, EventArgs e)
        {
            frm_ShowMember form = new frm_ShowMember();
            form.ShowDialog();
        }
    }
}
