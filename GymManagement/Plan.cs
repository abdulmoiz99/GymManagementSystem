using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    class Plan
    {
        public string name { get; set; }
        public double discountRate { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int duration { get; set; }

        public Plan(string name, double discountRate, string startDate, string endDate, int duration)
        {
            AddPlan(name, discountRate, startDate, endDate, duration);
        }
        private void AddPlan(string name, double discountRate, string startDate, string endDate, int duration)
        {
            File.AppendAllText(Application.StartupPath+  @"\Data\Plan.txt", name + "\t" + discountRate + "\t" + startDate + "\t" + endDate + "\t" + duration + Environment.NewLine);
            MessageBox.Show("Record Added Successfully");
        }
        public static void FillCombo(ComboBox comboBox)
        {
            string[] lineOfContents = File.ReadAllLines(Application.StartupPath + @"\Data\Plan.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('\t');
                comboBox.Items.Add(tokens[0]);
            }
        }

    }
}
