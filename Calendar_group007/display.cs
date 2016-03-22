﻿using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections;
using System.Windows.Forms;

namespace PJCalender
{
    public partial class Menus
    {
        public void displayAgenda()
        {
            ArrayList events = google.readEventLocal();
            if (events == null)
                return;
            if (events.Count > 0)
            {
                Label label = null;
                string dayHold = null;
                String nl = Environment.NewLine;
                int column = 0;
                int row = 0;
                TableLayoutPanel TLA = null;
                foreach (Event eventItem in events)
                {
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

                        //adding table to the agenda page and setting it to null for the next days events
                        //styling for the table happens here
                        if (!String.Equals(dayHold, startDay) & TLA != null)
                        {
                            TLA.MinimumSize = new System.Drawing.Size(722, 0);
                            TLA.AutoSize = true;
                            TableLayoutRowStyleCollection styles = TLA.RowStyles;

                            foreach (RowStyle style in styles)
                            {
                                style.SizeType = SizeType.Absolute;
                                style.Height = 50;
                            }
                            flowLayoutPanel.Controls.Add(TLA);

                            //set table and row count to ZERO
                            TLA = null;
                            row = 0;
                        }

                        //adding new events to the table
                        if (TLA != null)
                        {
                            //add row to table
                            TLA.RowCount = ++row;

                            column = 0;
                            //Start hour and end hour
                            label = new Label();
                            label.Text = startTime + nl + endTime;
                            TLA.Controls.Add(label, column++, row);

                            //Summary and discription
                            label = new Label();
                            label.Text = (Summary + nl + discription);
                            TLA.Controls.Add(label, column++, row);
                        }

                        //first table row in a table
                        if (!String.Equals(dayHold, startDay) & TLA == null)
                        {
                            label = new Label();
                            label.Text = startDay;
                            label.Width = 700;
                            flowLayoutPanel.Controls.Add(label);

                            TLA = new TableLayoutPanel();
                            TLA.ColumnCount = 2;
                            TLA.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                            column = 0;
                            //Start hour and end hour
                            label = new Label();
                            label.Text = startTime + nl + endTime;
                            TLA.Controls.Add(label, column++, row);

                            //Summary and discription
                            label = new Label();
                            label.Text = (Summary + nl + discription);
                            TLA.Controls.Add(label, column++, row);

                        }
                        //store day of last event
                        dayHold = startDay;
                    }
                    else if (eventItem.Start.DateTime == null && eventItem.Start.Date != null)
                    {
                        string startDay = eventItem.Start.Date;
                        string endDay = eventItem.End.Date;

                        string discription = eventItem.Description;

                        //only print each day once
                        if (!String.Equals(dayHold, startDay))
                        {
                            label = new Label();
                            label.Text = startDay;
                            label.Width = 700;
                            flowLayoutPanel.Controls.Add(label);
                        }
                        dayHold = startDay;
                    }
                }
            }
        }
    }
}
