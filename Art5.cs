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

namespace NewBT
{
    public partial class Art5 : Form
    {
        public Art5()
        {
            InitializeComponent();
        }

        private void Bai5_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\key_Logger.txt", true);
            sw.Write(e.KeyCode);
            sw.Close();
        }
    }
}
