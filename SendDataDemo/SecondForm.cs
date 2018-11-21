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
    public partial class SecondForm : Form
    {
        public string myName,channelName;
        public SecondForm()
        {
            InitializeComponent();
        }

        private void SecondForm_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }
        Form1 f1 = new Form1();
        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
        public string myText;
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 myText = txtName.Text;
            }
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            txtName.Text = myName;
            lblChannel.Text = channelName;
        }
    }
}
