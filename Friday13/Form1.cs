using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friday13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime friday = new DateTime(Convert.ToInt32(textBox1.Text), 1, 13);
            List<string> list = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                friday = friday.AddMonths(1);
                string a = friday.ToString("f ffff");
                Regex regex = new Regex(@"13 (/w*)");

                MatchCollection matches = regex.Matches(a);

                if(matches.Count > 0)
                {
                    foreach(Match match in matches)
                    {
                        list.Add(friday.ToString("d MMMM"));
                    }
                }
            }
        }
    }
}
