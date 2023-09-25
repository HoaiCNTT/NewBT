using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 Fr1 = new Bai1();
            Fr1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Art5 Fr1 = new Art5();
            Fr1.Show();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    Art0 Fr1 = new Art0();
        //    Fr1.Show();
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            Ex5 Fr1 = new Ex5();
            Fr1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Art6 Fr1 = new Art6();
            Fr1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Art7 Fr1 = new Art7();
            Fr1.Show();
        }
    }
}
