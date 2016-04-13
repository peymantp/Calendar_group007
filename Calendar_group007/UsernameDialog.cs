using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// arthor: Peyman Justin
/// </summary>
namespace PJCalender
{
    /// <summary>
    /// Unused dialog
    /// </summary>
    public partial class UsernameDialog : Form
    {
        private Menus f { get; set; }

        public UsernameDialog(Menus form)
        {
            f = form;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            //new google(f, textBox1.Text);
            new User(f);
            this.Close();
        }
    }
}
