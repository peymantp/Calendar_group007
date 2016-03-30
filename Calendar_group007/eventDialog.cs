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
    /// This dialog creates an event for you to send to google and display on calendar 
    /// </summary>
    public partial class eventDialog : Form
    {
        public eventDialog()
        {
            InitializeComponent();
        }

        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (panelRepeat.Visible == false)
                panelRepeat.Visible = true;
            else
                panelRepeat.Visible = false;
        }

        private void Repeats_Changed(object sender, EventArgs e)
        {
            if (comboBoxRepeats.SelectedItem.Equals("Daily"))
            {
                labelChange.Text = "days";
                panelWeekDay.Visible = false;
            }
            else if (comboBoxRepeats.SelectedItem.Equals("Weekly")) {
                labelChange.Text = "weeks";
                panelWeekDay.Visible = true;
            }
            else if (comboBoxRepeats.SelectedItem.Equals("Monthly")) {
                labelChange.Text = "months";
                panelWeekDay.Visible = false;
            }
            else if (comboBoxRepeats.SelectedItem.Equals("Yearly")) {
                labelChange.Text = "yearly";
                panelWeekDay.Visible = false;
            }
        }

        private void Check_AllDay(object sender, EventArgs e)
        {
            if (checkBoxAllDay.Checked)
            {
                dateTimePickerFrom.CustomFormat = "MMM dd, yyyy";
                dateTimePicker2.CustomFormat = "MMM dd, yyyy";
            } else
            {
                dateTimePickerFrom.CustomFormat = "dd, MM, yyyy: HH:mm";
                dateTimePicker2.CustomFormat = "dd, MM, yyyy: HH:mm";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
