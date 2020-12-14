using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Hello how are you");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message Box for button 3");
        }
    }
}
