using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voter_ID_Card_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname="sharad", upass="mishra", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if(name.Equals(uname) && pass.Equals(upass))
            {
                //login
                label3.Hide();
                appbody obj = new appbody();
                this.Hide();
                obj.Show();
            }
            else
            {
                //dont login
                label3.Show();
            }
        }
    }
}
