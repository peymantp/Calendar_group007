using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace PJCalender
{
    public partial class Menus
    {
        /// <summary>
        /// This delegate is used to run most fucntions that edit the GUI
        /// </summary>
        private delegate void DisplayDelegate();
        /// <summary>
        /// This delegate is for functions that add labels to
        /// different controls
        /// </summary>
        /// <param name="c">The control being edited</param>
        /// <param name="l">Label being added to the control</param>
        private delegate void ControlDelegate(Control c, Label l);
        /// <summary>
        /// List of flowLayoutPanels in month view
        /// </summary>
        System.Collections.ArrayList listofC = new System.Collections.ArrayList();
        /// <summary>
        /// call all display functions
        /// </summary>
        public void displayAll()
        {
            //clear old controls
            clear();
            
            //reread events for current month in case moew were added
            google.readEventLocal(this);
            
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
        /// display all events for the selected month in a list format
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
                int column = 7;
                DBLayoutPanel TLA = new DBLayoutPanel();
                TLA.ColumnCount = 7;
                TLA.RowCount = events.Count;
                int i = 1;
                Label label;

                //add the header row to the table
                label = labelmaker("Start Date");
                TLA.Controls.Add(label, 0, 0);
                label = labelmaker("Start Time");
                TLA.Controls.Add(label, 1, 0);
                label = labelmaker("Summary");
                TLA.Controls.Add(label, 2, 0);
                label = labelmaker("Location");
                TLA.Controls.Add(label, 3, 0);
                label = labelmaker("Description");
                TLA.Controls.Add(label, 4, 0);
                label = labelmaker("End Date");
                TLA.Controls.Add(label, 5, 0);
                label = labelmaker("End Time");
                TLA.Controls.Add(label, 6, 0);

                foreach (eventStruct eventitem in events)
                {
                    for(int j = 0; j < column; j++)
                    {
                        label = labelmaker(eventitem.getItemByIndex(j));
                        TLA.Controls.Add(label, j, i);
                    }
                    ++i;
                }

                TLA.AutoSize = true;
                TLA.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                flowLayoutPanel.Controls.Add(TLA);
            }
        }
        /// <summary>
        /// Number the days in month tab
        /// </summary>
        private void displayMonthNumbers()
        {
            if (tableLayoutPanelMonth.InvokeRequired)
                Invoke(new DisplayDelegate(displayMonthNumbers));
            else {
                try {
                    DateTime tem = new DateTime(Selected.Year, Selected.Month, 1);
                    int firstWeekDay = (int)tem.DayOfWeek;
                    int max = DateCalculations.monthDayNumber(Selected.AddMonths(-1));
                    int thisMonthLength = DateCalculations.monthDayNumber(Selected);
                    int day = max - firstWeekDay + 1;
                    bool maxHit = false;
                    for (int row = 1; row < 7; ++row)
                    {
                        for (int column = 0; column < 7; ++column, ++day)
                        {
                            if (day > max)
                            {
                                day = 1;
                                max = thisMonthLength;
                                if (maxHit)
                                    maxHit = false;
                                maxHit = true;
                            }
                            Label label = new Label();
                            label.Text = "" + day;
                            if (maxHit)
                                label.Name = "Label" + Selected.Year + "-" + Selected.Month.ToString("D2") + "-" + day.ToString("D2");
                            Control c = tableLayoutPanelMonth.GetControlFromPosition(column, row);
                            listofC.Add(c);
                            c.Controls.Clear();
                            c.Controls.Add(label);
                        }
                    }
                } catch (Exception x)
                {

                }
            }         
        }
        /// <summary>
        /// Displays all the events within a month
        /// </summary>
        private void displayMonthEvents()
        {
            Label l;
            if (tableLayoutPanelMonth.InvokeRequired)
                Invoke(new DisplayDelegate(displayMonthEvents));
            else {
                DateTime start = new DateTime(Selected.Year, Selected.Month, 1);
                foreach (eventStruct evstrct in events)
                {
                    foreach(Control c in listofC)
                    {
                        Control[] cont = c.Controls.Find("Label" + evstrct.startDate, true);
                        if(cont.Length > 0)
                        {
                            l = labelmaker(evstrct.Summary);
                            c.Controls.Add(l);
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Display the events for the week selected 
        /// </summary>
        private void displayWeekEvents()
        {
            if (tableLayoutPanelWeek.InvokeRequired)
                Invoke(new DisplayDelegate(displayWeekEvents));
            else {
                //The date of the saturday. Used to calculate the
                //date of the other days in the same week
                DateTime begin = Selected.AddDays(-(int)Selected.DayOfWeek);
                Label label;
                string format = "yyyy-MM-dd";
                //Each Control represents a day of the week 0 being Saturday
                List<Control> controls = new List<Control>();
                controls.Add(tableLayoutPanelWeek.GetControlFromPosition(0, 1));
                controls.Add(tableLayoutPanelWeek.GetControlFromPosition(1, 1));
                controls.Add(tableLayoutPanelWeek.GetControlFromPosition(2, 1));
                controls.Add(tableLayoutPanelWeek.GetControlFromPosition(3, 1));
                controls.Add(tableLayoutPanelWeek.GetControlFromPosition(4, 1));
                controls.Add(tableLayoutPanelWeek.GetControlFromPosition(5, 1));
                controls.Add(tableLayoutPanelWeek.GetControlFromPosition(6, 1));

                foreach(Control c in controls)
                {
                    c.Controls.Clear();
                }
                foreach (eventStruct eventitem in events)
                {
                    if (begin.ToString(format).Equals(eventitem.startDate))
                    {
                        label = labelmaker(eventitem.Summary);
                        controls[0].Controls.Add(label);
                    }
                    else if((begin.AddDays(1)).ToString(format).Equals(eventitem.startDate))
                    {
                        label = labelmaker(eventitem.Summary);
                        controls[1].Controls.Add(label);
                    }
                    else if ((begin.AddDays(2)).ToString(format).Equals(eventitem.startDate))
                    {
                        label = labelmaker(eventitem.Summary);
                        controls[2].Controls.Add(label);
                    }
                    else if ((begin.AddDays(3)).ToString(format).Equals(eventitem.startDate))
                    {
                        label = labelmaker(eventitem.Summary);
                        controls[3].Controls.Add(label);
                    }
                    else if ((begin.AddDays(4)).ToString(format).Equals(eventitem.startDate))
                    {
                        label = labelmaker(eventitem.Summary);
                        controls[4].Controls.Add(label);
                    }
                    else if ((begin.AddDays(5)).ToString(format).Equals(eventitem.startDate))
                    {
                        label = labelmaker(eventitem.Summary);
                        controls[5].Controls.Add(label);
                    }
                    else if ((begin.AddDays(6)).ToString(format).Equals(eventitem.startDate))
                    {
                        label = labelmaker(eventitem.Summary);
                        controls[6].Controls.Add(label);
                    }
                }
            }
        }
        /// <summary>
        /// Used to create new Label object
        /// </summary>
        /// <param name="text">The text displayed by the label</param>
        /// <returns>A Label object with a set text</returns>
        private Label labelmaker(string text)
        {
            Label l = new Label();
            l.Text = text;
            return l;
        }
        /// <summary>
        /// Displays the eents in the day selected
        /// </summary>
        private void displayDayEvents()
        {
            if (panelDay.InvokeRequired)
                Invoke(new DisplayDelegate(displayDayEvents));
            else {
                if (events.Count > 0)
                {
                    string grab = Selected.ToString("yyyy-MM-dd"); //format 2016-04-01
                    String nl = Environment.NewLine;
                    int column = 7;
                    DBLayoutPanel TLA = new DBLayoutPanel();
                    TLA.ColumnCount = column;
                    TLA.RowCount = events.Count;
                    int i = 1;
                    Label label;

                    //The headers for the table
                    label = labelmaker("Start Date");
                    TLA.Controls.Add(label, 0, 0);
                    label = labelmaker("Start Time");
                    TLA.Controls.Add(label, 1, 0);
                    label = labelmaker("Summary");
                    TLA.Controls.Add(label, 2, 0);
                    label = labelmaker("Location");
                    TLA.Controls.Add(label, 3, 0);
                    label = labelmaker("Description");
                    TLA.Controls.Add(label, 4, 0);
                    label = labelmaker("End Date");
                    TLA.Controls.Add(label, 5, 0);
                    label = labelmaker("End Time");
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
                    TLA.MinimumSize = new System.Drawing.Size(722, 0);
                    TLA.AutoSize = true;
                    TLA.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    panelDay.Controls.Add(TLA);
                }
            }
        }
        /// <summary>
        /// clear information when
        ///     new user logs in
        ///     old user logs out
        ///     views need re-writing
        /// </summary>
        private void clear()
        {
            if (flowLayoutPanel.InvokeRequired)
                Invoke(new DisplayDelegate(clear));
            else {
                flowLayoutPanel.Controls.Clear();
                panelDay.Controls.Clear();
            }
            events.Clear();
        }
        /// <summary>
        /// display the day selected in the day view
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
            }
            else
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
        /// <summary>
        /// displays a label on the buttom left corner when the client
        /// is pulling data from google servers
        /// </summary>
        public void syncLabel()
        {
            if (labelLoading.InvokeRequired)
            {
                Invoke(new DisplayDelegate(syncLabel));
            }
            else
            {
                if (labelLoading.Visible)
                    labelLoading.Visible = false;
                else
                    labelLoading.Visible = true;
            }
        }
    }
}
