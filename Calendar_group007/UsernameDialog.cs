using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJCalender
{
    public partial class UsernameDialog : Form
    {

        public String username { get; set; }

        Menus f;

        public UsernameDialog(Menus form)
        {
            f = form;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new google(f, textBox1.Text);
            username = textBox1.Text;
            this.Close();
        }
    }
}
