using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
        public void displayAll()
        {
            clear();
            google.readEventLocal(this);

            //List version
            List<Thread> threads = new List<Thread>();
            threads.Add(new Thread(() => displayMonthNumbers()));
            threads.Add(new Thread(() => displayAgenda()));
            threads.Add(new Thread(() => displayLabelDay()));
            threads.Add(new Thread(() => displayDayEvents()));
            threads.Add(new Thread(() => displayWeekEvents()));
            threads.Add(new Thread(() => displayMonthEvents()));
            int i = 0;
            foreach (var item in threads)
            {
                item.Name = "" + i;
                ++i;
                item.Start();
            }
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
                int column = 7;
                DBLayoutPanel TLA = new DBLayoutPanel();
                TLA.ColumnCount = column;
                TLA.RowCount = events.Count;
                int i = 1;
                Label label;

                label = new Label();
                label.Text = "Start Date";
                TLA.Controls.Add(label, 0, 0);
                label = new Label();
                label.Text = "Start Time";
                TLA.Controls.Add(label, 1, 0);
                label = new Label();
                label.Text = "Summary";
                TLA.Controls.Add(label, 2, 0);
                label = new Label();
                label.Text = "Location";
                TLA.Controls.Add(label, 3, 0);
                label = new Label();
                label.Text = "Description";
                TLA.Controls.Add(label, 4, 0);
                label = new Label();
                label.Text = "End Date";
                TLA.Controls.Add(label, 5, 0);
                label = new Label();
                label.Text = "End Time";
                TLA.Controls.Add(label, 6, 0);

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
                TLA.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                flowLayoutPanel.Controls.Add(TLA);
            }
        }
        /// <summary>
        /// Number days in month tab
        /// </summary>
        public void displayMonthNumbers()
        {
            if (tableLayoutPanelMonth.InvokeRequired)
                Invoke(new DisplayDelegate(displayMonthNumbers));
            else {
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
        }

        public void displayMonthEvents()
        {
            if (tableLayoutPanelMonth.InvokeRequired)
                Invoke(new DisplayDelegate(displayMonthEvents));
            else {

            }
        }

        public void displayWeekEvents()
        {
            if (tableLayoutPanelWeek.InvokeRequired)
                Invoke(new DisplayDelegate(displayWeekEvents));
            else {
                int today = (int)Selected.DayOfWeek;
                DateTime begin = Selected.AddDays(-today);
                int column = 7;
                Label label;

                foreach (eventStruct eventitem in events)
                {
                    if(event)
                }
            }
        }

        public void displayDayEvents()
        {
            if (flowLayoutPanelDay.InvokeRequired)
                Invoke(new DisplayDelegate(displayDayEvents));
            else {
                if (events.Count > 0)
                {
                    string grab = Selected.ToShortDateString();
                    String nl = Environment.NewLine;
                    int column = 7;
                    DBLayoutPanel TLA = new DBLayoutPanel();
                    TLA.ColumnCount = column;
                    TLA.RowCount = events.Count;
                    int i = 1;
                    Label label;
                    
                    label = new Label();
                    label.Text = "Start Date";
                    TLA.Controls.Add(label, 0, 0);
                    label = new Label();
                    label.Text = "Start Time";
                    TLA.Controls.Add(label, 1, 0);
                    label = new Label();
                    label.Text = "Summary";
                    TLA.Controls.Add(label, 2, 0);
                    label = new Label();
                    label.Text = "Location";
                    TLA.Controls.Add(label, 3, 0);
                    label = new Label();
                    label.Text = "Description";
                    TLA.Controls.Add(label, 4, 0);
                    label = new Label();
                    label.Text = "End Date";
                    TLA.Controls.Add(label, 5, 0);
                    label = new Label();
                    label.Text = "End Time";
                    TLA.Controls.Add(label, 6, 0);

                    foreach (eventStruct eventitem in events)
                    {
                        if (grab.CompareTo(eventitem.startDate) == 0)
                        {
                            for (int j = 0; j < column; j++)
                            {
                                label = new Label();
                                label.Text = eventitem.getItemByIndex(j);
                                TLA.Controls.Add(label, j, i);
                            }
                            ++i;
                        }
                    }
                    //TLA.MinimumSize = new System.Drawing.Size(722, 0);
                    TLA.AutoSize = true;
                    TLA.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    flowLayoutPanelDay.Controls.Add(TLA);
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
            if (flowLayoutPanel.InvokeRequired)
                Invoke(new DisplayDelegate(clear));
            else {
                flowLayoutPanel.Controls.Clear();
                flowLayoutPanelDay.Controls.Clear();
            }
            events.Clear();
        }
        /// <summary>
        /// display day tab
        /// </summary>
        private void displayLabelDay()
        {
            if (labelDay.InvokeRequired)
                Invoke(new DisplayDelegate(displayLabelDay));
            else
                labelDay.Text = Selected.ToLongDateString();
        }

        /// <summary> 
        /// Changes the text on the button login/logout if a new user is created
        /// </summary>
        /// <param name="sender">object calling event</param>
        /// <param name="e">Event</param>
        public void loginButtonChangeText()
        {
            if (buttonLog.InvokeRequired)
            {
                Invoke(new DisplayDelegate(loginButtonChangeText));
            } else
            {
                if (User.currentUserLoggedIn() == null)
                {
                    string test = User.currentUserLoggedIn();
                    buttonLog.Text = "Login";
                }
                else
                    buttonLog.Text = "Logout";
            }
        }
    }
}
