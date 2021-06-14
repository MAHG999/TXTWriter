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

namespace TXTWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = { textBox1.Text, textBox2.Text, textBox3.Text };

            using (StreamWriter OutPutFile = new StreamWriter(@"C:\Users\marco\source\repos\TXTWriter\bin\Debug\net5.0-windows\Documents\FileDemo.txt"))
            {
                foreach (var itemLines in lines)
                {
                    OutPutFile.WriteLine(itemLines);
                }
            }
        }
    }
}
