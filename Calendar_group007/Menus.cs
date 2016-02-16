using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace PJCalender
{
    public partial class Menus : Form
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        public Menus()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
            labelDay.Text = DateTime.Now.ToLongDateString();

            UserCredential credential;
            using (var stream =
                new System.IO.FileStream("client_secret.json", System.IO.FileMode.Open, FileAccess.Read))
            {
                //string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string credPath = (".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "peyman",
                    System.Threading.CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 30;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;
            try
            {
                // List events.
                Events events = request.Execute();
                if (events.Items != null && events.Items.Count > 0)
                {
                    Label label = null;
                    string dayHold = null;
                    String nl = Environment.NewLine;
                    int column = 0;
                    int row = 0;
                    TableLayoutPanel TLA = null;
                    foreach (var eventItem in events.Items)
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
                                TLA.MinimumSize = new Size(722, 0);
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

                            textBoxTest.Text += eventItem.Summary + " at " + startTime + " ends " +
                                endTime + nl + "  X " + discription + nl;
                            //store day of last event
                            dayHold = startDay;
                        }
                        else if(eventItem.Start.DateTime == null && eventItem.Start.Date != null)
                        {
                            string startDay = eventItem.Start.Date;
                            string endDay = eventItem.End.Date;

                            string discription = eventItem.Description;

                            //only print each day once
                            if (!String.Equals(dayHold, startDay))
                            {
                                textBoxTest.Text += nl + startDay + nl;
                                label = new Label();
                                label.Text = startDay;
                                label.Width = 700;
                                flowLayoutPanel.Controls.Add(label);
                            }
                            textBoxTest.Text += eventItem.Summary + "endDay: " + endDay + nl
                                             + "   " + discription + nl;
                            dayHold = startDay;
                        }
                    }
                }
                else
                {
                    textBoxTest.Text += Environment.NewLine + "No upcoming events found.";
                }
            }
            catch (System.Net.Http.HttpRequestException requestEx)
            {
                MessageBox.Show(requestEx.ToString(), requestEx.GetType().ToString());
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            global::PJCalender.Program.Exit();
        }

        private void buttonPickDay_Click(object sender, EventArgs e)
        {
            dayPickerDialog d = new dayPickerDialog();
            d.Show();
        }

        private void dateTimePicker_DatePicked(object sender, EventArgs e)
        {
            DateTime t = dateTimePicker.Value;
            labelDay.Text = t.ToLongDateString();
            monthDayNumber(t);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Number of days within each month</returns>
        private int monthDayNumber(DateTime date)
        {
            //adding days to month view HARD CODED
            /*
            int day = 27;
            for(int row = 1; row < 7; row++)
            {
                for(int column = 0; column < 7; column++, day++)
                {
                    if (day == 32)
                        day = 1;
                    Label label = new Label();
                    label.Name = "label" + day + "ofMonth";
                    label.Text = ""+day;
                    tableLayoutPanelMonth.Controls.Add(label, column, row);
                }
            }
            */
            switch (date.Month)
            {
                case 1: //January
                    return 31;
                case 2: // Februrary
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
                case 8:     //Augest
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
    }
}
