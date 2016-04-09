﻿using System;
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
            //delegate version
            //DisplayDelegate d = new DisplayDelegate(displayAgenda);
            //d += new DisplayDelegate(displayMonthNumbers);
            //Thread t = new Thread(() => d.Invoke());
            //Thread t = new Thread(() => displayAgenda());
            //t.Name = "displayAgenda";
            //t.Start();

            //List version
            List<Thread> threads = new List<Thread>();
            threads.Add(new Thread(() => displayAgenda()));
            threads.Add(new Thread(() => displayLabelDay()));
            threads.Add(new Thread(() => displayMonthNumbers()));
            int i = 0;
            foreach (var item in threads)
            {
                item.Name = "" + i;
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
            else
                flowLayoutPanel.Controls.Clear();
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
