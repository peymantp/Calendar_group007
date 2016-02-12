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

            //adding days to month view HARD CODED
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

            UserCredential credential;
            using (var stream =
                new System.IO.FileStream("client_secret.json", System.IO.FileMode.Open, FileAccess.Read))
            {
                //string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string credPath = (".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    System.Threading.CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                //textBoxTest.Text += "Credential file saved to: " + credPath;
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
                    //Monday, February 15, 2016
                    //COMP 3760 algorithm lecture  at 08:30:00 AM ends 09:20:00 AM
                    //   SW1 - 2009
                    //Farnaz Dargahi
                    string dayHold = null;
                    String nl = Environment.NewLine;
                    int column = 0;
                    int row = 0;
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

                            //only print each day once
                            if (!String.Equals(dayHold, startDay))
                            {
                                textBoxTest.Text += nl + startDay + nl;
                                Label label = new Label();
                                label.Text = startDay;
                                label.Width = 700;
                                /* method 1
                                tableLayoutAgenda.Controls.Add(label,0, row);
                                row++;
                                tableLayoutAgenda.RowCount = row + 1;
                                tableLayoutAgenda.Height += 22; //to-do
                                */
                                flowLayoutPanel.Controls.Add(label);
                            }
                            textBoxTest.Text += eventItem.Summary + " at " + startTime + " ends " + endTime + nl
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
    }
}
