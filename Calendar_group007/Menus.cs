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
        public DateTime Selected
        {
            get;
            private set;
        }
        /// <summary>
        /// List of events for the selected month
        /// </summary>
        public System.Collections.ArrayList events {
            get;
            set;
        }
        /// <summary>
        /// ctor for the application
        /// </summary>
        public Menus()
        {
            InitializeComponent();
            loginButtonChangeText();
            events = new System.Collections.ArrayList();
            //create user folder if it doesnt exist
            if (!System.IO.Directory.Exists(".credentials/currentUser"))
            {
                System.IO.Directory.CreateDirectory(".credentials/currentUser");
            }
            //select default values
            Selected = DateTime.Now;
            dateTimePicker.Value = Selected;
            displayAll();
            if (!System.IO.Directory.Exists(".credentials/currentUser"))
                System.IO.Directory.CreateDirectory(".credentials/currentUser");
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
                google.clearTableData();
                displayAll();
            }
            else
            {
                new User(this);
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
        /// <summary>
        /// Opens the current instance of the program if user tries 
        /// to create a secount  
        /// http://stackoverflow.com/questions/35470399/if-an-instance-of-the-application-is-already-running-call-a-method-within-the-a
        /// </summary>
        /// <param name="m">ref Message</param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }
        /// <summary>
        /// displays the application on top of all other
        /// running applications on the system
        /// http://stackoverflow.com/questions/35470399/if-an-instance-of-the-application-is-already-running-call-a-method-within-the-a
        /// </summary>
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
        /// <summary>
        /// retrieves data from google servers
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="e">event triggered</param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(() => new google(this));
            t.Name = "Google";
            t.Start();
        }
        /// <summary>
        /// displays all the data inside sql
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.T))
            {
                dataGridView1.Visible = true;
                displayDataGrid();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
