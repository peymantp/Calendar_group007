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
        /// <summary>
        /// complicated string for event recurrence
        /// </summary>
        private string[] recurrence { get; set; }
        /// <summary>
        /// event creation dialog
        /// </summary>
        public eventDialog()
        {
            InitializeComponent();
            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }
        /// <summary>
        /// Shows option to customise reapeat options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (panelRepeat.Visible == false)
                panelRepeat.Visible = true;
            else
                panelRepeat.Visible = false;
        }
        /// <summary>
        /// Decide if event repeats every day, weeks, months, yearly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// decide if events are full/multi day event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// create event based on the options selected in the dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkBoxRepeat.Checked)
            {
                recurrence = null;
                makeRecurrence();
            }
            if(checkBoxAllDay.Checked)
            {
                dateTimePicker2.Value = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.AddDays(1).Day);
                dateTimePickerFrom.Value = new DateTime(dateTimePickerFrom.Value.Year, dateTimePickerFrom.Value.Month, dateTimePickerFrom.Value.Day);
            }
            google.createEvent(textBoxEvent.Text, textBoxWhere.Text, textBoxDescription.Text,
                dateTimePickerFrom.Value, dateTimePicker2.Value,recurrence);
            this.Close();
        }
        /// <summary>
        /// Creates complicated string for event recurrence
        /// </summary>
        private void makeRecurrence()
        {
            List<string> ruleList = new List<string>();
            ruleList.Add("RRULE:FREQ=" + comboBoxRepeats.SelectedText + ";INTERVAL=" + comboBoxRepeatEvery.SelectedText);

            if (radioButtonAfter.Checked)
            {
                ruleList.Add("RRULE:FREQ=" + comboBoxRepeats.SelectedText + ";COUNT=" + comboBoxAfter.SelectedText);
            }
            else if (radioButtonOn.Checked)
            {
                ruleList.Add("RRULE:FREQ=" + comboBoxRepeats.SelectedText + ";UNTIL=" 
                    + dateTimePickerOn.Value.ToString("yyyyMMdd")+"T"
                    + dateTimePickerOn.Value.ToString("HHmmss"));
            }

            if (panelWeekDay.Visible)
            {
                List<string> dayList = new List<string>();
                if (checkBox0.Checked) dayList.Add("SU");
                if (checkBox1.Checked) dayList.Add("MO");
                if (checkBox2.Checked) dayList.Add("TU");
                if (checkBox3.Checked) dayList.Add("WE");
                if (checkBox4.Checked) dayList.Add("TH");
                if (checkBox5.Checked) dayList.Add("FR");
                if (checkBox6.Checked) dayList.Add("SA");
                if (dayList.Count != 0)
                {
                    String days = "";
                    days += dayList.ElementAt(0);
                    for(int i = 1; i < dayList.Count; ++i)
                    {
                        days += "," + dayList.ElementAt(i);
                    }
                    ruleList.Add("RRULE:FREQ=" + comboBoxRepeats.SelectedText + ";BYDAY=" + days);
                }
            }

            recurrence = ruleList.ToArray();
        }
        /// <summary>
        /// enables more option to decide after how many times an event will stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonAfter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAfter.Checked)
                comboBoxAfter.Enabled = true;
            else
                comboBoxAfter.Enabled = false;
        }
        /// <summary>
        /// Enables option to decide when the event will stop recurrencing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOn.Checked)
                dateTimePickerOn.Enabled = true;
            else
                dateTimePickerOn.Enabled = false;
        }
        /// <summary>
        /// keeps the two date pickers consistent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePickerFrom.Value.AddHours(2);
        }
    }
}
