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
        /// <summary>
        /// date selected for the views to show
        /// </summary>
        private DateTime Selected
        {
            get;
            set;
        }

        public System.Collections.ArrayList events {
            get;
            set;
        }

        public Menus()
        {
            InitializeComponent();
            loginButtonChangeText();
            if (!String.IsNullOrEmpty(User.currentUserLoggedIn()))
            {
                loginButtonChangeText();
                buttonLog.Enabled = false;
            }
            events = new System.Collections.ArrayList();
            Selected = DateTime.Now;
            dateTimePicker.Value = Selected;
            displayAll();
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
            Selected = dateTimePicker.Value;
            displayAll();
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
            else
            {
                new User(" ", this);
                buttonLog.Enabled = false;
            }
        }
        /// <summary>
        /// Opens event creation dialog
        /// </summary>
        /// <param name="sender">object calling event</param>
        /// <param name="e">Event</param>
        private void buttonEvent_Click(object sender, EventArgs e)
        {
            eventDialog ev = new eventDialog();
            ev.Show();

            buttonRefresh_Click(sender, e);
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
            // get our current "TopMost" value 
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            events = null;
            clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(() => new google(this));
            t.Name = "Google";
            //clear();
            t.Start();
            //displayAll(this);
        }
    }
}
