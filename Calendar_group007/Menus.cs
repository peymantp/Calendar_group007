using System;
using System.Windows.Forms;
/// <summary>
/// arthor: Peyman Justin
/// </summary>
namespace PJCalender
{
    /// <summary>
    /// Main form for the callender
    /// </summary>
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
            loginButtonChangeText();
            dateTimePicker.Value = DateTime.Now;
            labelDay.Text = DateTime.Now.ToLongDateString();
                
        }
        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender">object calling event</param>
        /// <param name="e">Event</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            global::PJCalender.Program.Exit();
        }
        /// <summary>
        /// Brings up a calendar for you to pick a day of
        /// </summary>
        /// <param name="sender">object calling event</param>
        /// <param name="e">Event</param>
        private void buttonPickDay_Click(object sender, EventArgs e)
        {
            dayPickerDialog d = new dayPickerDialog();
            d.Show();
        }
        /// <summary>
        /// displays the value selected in dateTimePicker
        /// </summary>
        /// <param name="sender">object calling event</param>
        /// <param name="e">Event</param>
        private void dateTimePicker_DatePicked(object sender, EventArgs e)
        {
            DateTime t = dateTimePicker.Value;
            labelDay.Text = t.ToLongDateString();
            monthDayNumber(t);
        }
        /// <summary>
        /// Returns the number of days in a month sent to the function
        /// </summary>
        /// <param name="date">A date containing a month</param>
        /// <returns>number of days in a month</returns>
        private int monthDayNumber(DateTime date)
        {
            switch (date.Month)
            {
                case 1: //January
                    return 31;
                case 2: // February
                    if (DateTime.IsLeapYear(date.Year))
                        return 29;
                    return 28;
                case 3:     //March
                    return 31;
                case 4:     //April
                    return 30;
                case 5:     //May
                    return 31;
                case 6:     //June
                    return 30;
                case 7:     //July
                    return 31;
                case 8:     //August
                    return 31;
                case 9:     //September
                    return 30;
                case 10:    //October
                    return 31;
                case 11:    //November
                    return 30;
                case 12:    //December
                    return 31;
            }
            return 0;
        }
        /// <summary>
        /// Changes the text on the button login/logout if a new user is created
        /// </summary>
        /// <param name="sender">object calling event</param>
        /// <param name="e">Event</param>
        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (buttonLog.Text.Equals("Logout"))
            {
                User.Logout();
                loginButtonChangeText();
            }
            else if (new UsernameDialog(this).ShowDialog() == DialogResult.OK)
            {
             //   loginButtonChangeText();
            }
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            eventDialog ev = new eventDialog();
            ev.Show();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }

        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }
    }
}
