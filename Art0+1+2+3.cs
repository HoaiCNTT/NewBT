//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Windows.Forms.Design;
//using System.Xml.Serialization;

//namespace NewBT
//{
//    public partial class Art0 : Form
//    {
//        public Art0()
//        {
//            InitializeComponent();
//        }
//        InFfoWindows iw = new InFfoWindows();
//        void Art0_Load(object sender, EventArgs e)
//        {
//            InFfoWindows iw = new InFfoWindows();
//            iw = Read();
//            int width = this.Size.Width;
//            int height = this.Size.Height;
//            this.Location = iw.Location;
//            Write(iw);
//            this.Text = width.ToString() + " _ " + height.ToString();
//        }
//        void Art0_ResizeEnd(object sender, EventArgs e)
//        {
//            InFfoWindows iw = new InFfoWindows();
//            int width = this.Size.Width;
//            int height = this.Size.Height;
//            Write(iw);
//            this.Text = width.ToString() +" _ "+height.ToString();
//        }
//        string path = @"D:\form.xml";

//        public void Write(InFfoWindows iw)
//        {
//            XmlSerializer writer = new XmlSerializer(typeof(InFfoWindows));
//            StreamWriter file = new StreamWriter(path);
//            writer.Serialize(file, iw);
//            file.Close();
//        }
//        private void Art0_ArtClosing(object sender, EventArgs e)
//        {
//            InFfoWindows iw = new InFfoWindows();
//            iw.Width = this.Size.Width;
//            iw.Height = this.Size.Height;
//            iw.Location = this.Location;
//            Write(iw);
//        }
//        public InFfoWindows Read()
//        {
//            XmlSerializer reader = new XmlSerializer(typeof(InFfoWindows));
//            StreamReader file = new StreamReader(path);
//            InFfoWindows iw = (InFfoWindows)reader.Deserialize(file);
//            file.Close();
//            return iw ;
//        }
//    }
//}
