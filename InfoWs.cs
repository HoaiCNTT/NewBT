using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NewBT
{
    public partial class InfoWs : Form
    {
        public InfoWs()
        {
            InitializeComponent();
        }

        private void InfoWs_Load(object sender, EventArgs e)
        {

        }
    }
    public class InFfoWindows
    {
        [XmlIgnore]
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Location { get; set; }
    }
}
