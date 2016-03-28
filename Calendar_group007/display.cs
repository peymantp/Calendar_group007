using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace PJCalender
{
    public partial class Menus
    {
        private delegate void DisplayDelegate();

        public void displayAll()
        {
            clear();
            displayMonthNumbers();
            displayLabelDay();
            displayAgenda();
        }

        private void displayAgenda()
        {
            if (events == null || events.Count == 0)
                google.readEventLocal(this);
            if (events.Count > 0)
            {
                Label label = new Label();
                label.Text = events.Count + "";
                string dayHold = null;
                String nl = Environment.NewLine;
                int column = 0;
                int row = 0;
                TableLayoutPanel TLA = new TableLayoutPanel();
                flowLayoutPanel.Controls.Add(label);
                foreach (Event eventItem in events)
                {
                    column = 0;
                    TLA.RowCount = ++row;

                    if (eventItem.Start.DateTime != null)
                    {
                        DateTime start = (DateTime)eventItem.Start.DateTime;
                        string startDay = start.ToLongDateString();
                        string startTime = start.ToLongTimeString();

                        DateTime end = (DateTime)eventItem.End.DateTime;
                        string endDay = end.ToLongDateString();
                        string endTime = end.ToLongTimeString();

                        string discription = eventItem.Description;
                        string Summary = eventItem.Summary;

                        //Start hour and end hour
                        label = new Label();
                        label.Text = startTime + nl + endTime;
                        TLA.Controls.Add(label, column++, row);

                        //Summary and discription
                        label = new Label();
                        label.Text = (Summary + nl + discription);
                        TLA.Controls.Add(label, column++, row);
                    }
                    }
                TLA.MinimumSize = new System.Drawing.Size(722, 0);
                TLA.AutoSize = true;
                flowLayoutPanel.Controls.Add(TLA);
            }
        }

        public void displayMonthNumbers()
        {
            DateTime tem = new DateTime(Selected.Year, Selected.Month, 1);
            int firstWeekDay = (int)tem.DayOfWeek;
            int max = DateCalculations.monthDayNumber(Selected.AddMonths(-1));
            int thisMonthLength = DateCalculations.monthDayNumber(Selected);
            int day = max - firstWeekDay + 1;
            for (int row = 1; row < 7; ++row)
            {
                for (int column = 0; column < 7; ++column, ++day)
                {
                    if (day > max)
                    {
                        day = 1;
                        max = thisMonthLength;
                    }
                    Label label = new Label();
                    label.Text = "" + day;
                    Control c = tableLayoutPanelMonth.GetControlFromPosition(column, row);
                    c.Controls.Clear();
                    c.Controls.Add(label);
                }
            }
        }

        public void clear()
        {
            flowLayoutPanel.Controls.Clear();
        }

        private void displayLabelDay()
        {
            labelDay.Text = Selected.ToLongDateString();
        }

        /// <summary> 
        /// Changes the text on the button login/logout if a new user is created
        /// </summary>
        /// <param name="sender">object calling event</param>
        /// <param name="e">Event</param>
        public void loginButtonChangeText()
        {
            String message;

            if (buttonLog.Text.Equals("Login"))
            {
                message = "Logout";
                if (buttonLog.InvokeRequired)
                {
                    //Executes the DisplayDelegate on the thread that owns the control's 
                    //underlying window handle.                                      
                    Invoke(new DisplayDelegate(loginButtonChangeText));
                } // end if
                else // add message to text box
                {
                    buttonLog.Text = message;
                }
            }
            else
            {
                message = "Login";
                if (buttonLog.InvokeRequired)
                {
                    //Executes the DisplayDelegate on the thread that owns the control's 
                    //underlying window handle.                                      
                    Invoke(new DisplayDelegate(loginButtonChangeText));
                } // end if
                else // add message to text box
                {
                    buttonLog.Text = message;
                }
            }

            


        }
    }
}
