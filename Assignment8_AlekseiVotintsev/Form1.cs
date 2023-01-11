using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Assignment8_AlekseiVotintsev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool Boy = false;
                string[] BoyNames = new string[100];
                StreamReader BoysTXT;
                BoysTXT = File.OpenText("C:\\Users\\mikro\\OneDrive\\Рабочий стол\\BoyNames.txt");
                int boys = 0;

                while (!BoysTXT.EndOfStream && !Boy)
                {
                    boys++;
                    BoyNames[boys] = BoysTXT.ReadLine();

                    if (BoyNames[boys] == boyname.Text)
                    {
                        Boy = true;
                        MessageBox.Show(boyname.Text + " is found!" + " It is №" + boys);
                    }
                    else
                    {
                        MessageBox.Show("Name is not found");
                        break;
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool Girl = false;
                string[] GirlNames = new string[100];
                StreamReader GirlsTXT;
                GirlsTXT = File.OpenText("C:\\Users\\mikro\\OneDrive\\Рабочий стол\\GirlNames.txt");
                int girls = 0;
                while (!GirlsTXT.EndOfStream && !Girl)
                {
                    girls++;
                    GirlNames[girls] = GirlsTXT.ReadLine();

                    if (GirlNames[girls] == girlname.Text)
                    {
                        Girl = true;
                        MessageBox.Show(girlname.Text + " is found!" + " It is №" + girls);
                    }
                    else
                    {
                        MessageBox.Show("Name is not found");
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
