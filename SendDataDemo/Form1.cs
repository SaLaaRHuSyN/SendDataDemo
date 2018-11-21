using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LabelText;
        private void button1_Click(object sender, EventArgs e)
        {
            using (SecondForm sf = new SecondForm())
            {
                sf.myName = lblName.Text;
                sf.channelName = txtChannelName.Text;
                sf.ShowDialog();
                lblName.Text = sf.myText;
               // lblName.Text = LabelText;
            }
        }
    }
}
