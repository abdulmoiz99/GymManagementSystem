using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    class Member
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNo { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string imageAddress { get; set; }

        public string plan { get; set; }

        public double subFee = 50;
        public double VAT = 0.23; // 23%
        public Member(int ID, string name, string surname, string phoneNo, string address, string email, string plan,string total, string ImageAddress)
        {
            this.Id = GenerateID();
            AddMember(ID, name, surname, phoneNo, address, email, plan,total, ImageAddress);
        }
        public void AddMember(int ID, string name, string surname, string phoneNo, string address, string email, string plan, string total, string ImageAddress)
        {
            File.AppendAllText(Application.StartupPath + @"\Data\Members.txt", ID + "\t" + name + "\t" + surname + "\t" + phoneNo + "\t" + address + "\t" + email + "\t" + plan + "\t" + total + "\t" + ImageAddress);
            MessageBox.Show("Record Added Successfully");
        }   
        public static int GenerateID()
        {
            string[] clients = File.ReadAllLines(Application.StartupPath + @"\Data\Members.txt");
            if (clients.Length > 0)
            {
                string[] subset = clients[clients.Length - 1].Split('\t');
                int id = int.Parse(subset[0]);
                return id + 1;
            }
            else return 1;
        }

    }


}
