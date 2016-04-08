using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace PJCalender
{
    public partial class Menus
    {
        private delegate void DisplayDelegate();
        private delegate void StaticDisplayDelegate(Menus m);
        /// <summary>
        /// call all display functions
        /// </summary>
        static public void displayAll(Menus m)
        {

            if (m.events == null || m.events.Count == 0)
                //ThreadPool.QueueUserWorkItem(google.readEventLocal, m);
                google.readEventLocal(m);
            m.clear();
            DisplayDelegate d = new DisplayDelegate(m.displayAgenda);
            Thread t = new Thread(() => d.Invoke());
            t.Name = "displayAgenda";
            t.Start();
            displayMonthNumbers(m);
            displayLabelDay(m);
            //m.displayAgenda();
        }
        /// <summary>
        /// display agendatab
        /// </summary>
        private void displayAgenda()
        {
            if (flowLayoutPanel.InvokeRequired)
            {
                Invoke(new DisplayDelegate(displayAgenda));
                return;
            } 

            if (events.Count > 0)
            {
                String nl = Environment.NewLine;
                int column = 8;
                DBLayoutPanel TLA = new DBLayoutPanel();
                TLA.ColumnCount = column;
                TLA.RowCount = events.Count;
                int i = 0;
                Label label;
                foreach (eventStruct eventitem in events)
                {
                    
                    for(int j = 0; j < column; j++)
                    {
                        label = new Label();
                        label.Text = eventitem.getItemByIndex(j);
                        TLA.Controls.Add(label, j, i);
                    }
                    ++i;
                }
                //TLA.MinimumSize = new System.Drawing.Size(722, 0);
                TLA.AutoSize = true;
                flowLayoutPanel.Controls.Add(TLA);
            }
        }
        /// <summary>
        /// Number days in month tab
        /// </summary>
        public static void displayMonthNumbers(object state)
        {
        Menus m = (Menus)state;
            DateTime tem = new DateTime(m.Selected.Year, m.Selected.Month, 1);
            int firstWeekDay = (int)tem.DayOfWeek;
            int max = DateCalculations.monthDayNumber(m.Selected.AddMonths(-1));
            int thisMonthLength = DateCalculations.monthDayNumber(m.Selected);
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
                    Control c = m.tableLayoutPanelMonth.GetControlFromPosition(column, row);
                    c.Controls.Clear();
                    c.Controls.Add(label);
                }
            }            
        }
        /// <summary>
        /// clear information when
        ///     new user logs in
        ///     old user logs out
        ///     views need re-writing
        /// </summary>
        public void clear()
        {
            flowLayoutPanel.Controls.Clear();
        }
        /// <summary>
        /// display day tab
        /// </summary>
        private static void displayLabelDay(object state)
        {
            Menus m = (Menus)state;
            m.labelDay.Text = m.Selected.ToLongDateString();
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
