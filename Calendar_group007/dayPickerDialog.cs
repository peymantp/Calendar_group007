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
    public partial class dayPickerDialog : Form
    {
        /// <summary>
        /// Creates dialog with big calendar
        /// </summary>
        public dayPickerDialog()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(this.Size.Width, 566);
        }
        /// <summary>
        /// displays date selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.textBox1.Text = "Date Selected: " + e.Start.Year + "," + e.Start.Month + "," + e.Start.Day;
        }
    }
}
