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
    public partial class dayPickerDialog : Form
    {
        public dayPickerDialog()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(this.Size.Width, 566);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.textBox1.Text = "Date Selected: " + e.Start.Year + "," + e.Start.Month + "," + e.Start.Day;
        }
    }
}
