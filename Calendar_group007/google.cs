using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Data.SqlClient;
/// <summary>
/// arthor: Peyman Justin
/// </summary>
namespace PJCalender
{
    /// <summary>
    /// Handles all of the google api functionallity 
    /// </summary>
    public class google
    {
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "PJCalender";
        /// <summary>
        /// This object is not meant to be stored.
        /// Will retrieve events from your account and store them locally 
        /// </summary>
        /// <param name="form">The form calling crating this object</param>
        /// <param name="user">username of user</param>
        public google(Menus form)
        {
            using (var stream = new System.IO.FileStream("client_secret.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                UserCredential credential = null;
                //string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string credPath = (".credentials/currentUser");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                                                                         Scopes,
                                                                         "user",
                                                                         System.Threading.CancellationToken.None,
                                                                         new FileDataStore(credPath, true)).Result;
                // Create Google Calendar API service.
                if (credential == null)
                    return;

                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define parameters of request.
                EventsResource.ListRequest request = service.Events.List("primary");
                request.TimeMin =new DateTime(2000,1,1);
                request.ShowDeleted = false;
                request.SingleEvents = true;
                request.TimeMax = DateTime.Now.AddYears(20); //todo change number to 20
                request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

                try
                {
                    Events events = request.Execute();
                    saveEventLocal(events);
                }
                catch (System.Net.Http.HttpRequestException requestEx)
                {
                    System.Windows.Forms.MessageBox.Show(requestEx.ToString(), requestEx.GetType().ToString());
                }
                //Menus.displayAll(form);
            }
        }
        /// <summary>
        /// Event creation
        /// </summary>
        /// <param name="sum">Summary</param>
        /// <param name="where">Location of Event</param>
        /// <param name="desc">Description of event</param>
        /// <param name="st">Start date in DateTime</param>
        /// <param name="en">End date in DateTime</param>
        /// <param name="re">Recurrence of the event</param>
        static public void createEvent(String sum,
            String where,
            String desc,
            DateTime st,
            DateTime en,
            String[] re)
        {
            using (var stream = new System.IO.FileStream("client_secret.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                UserCredential credential = null;
                //string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string credPath = (".credentials/currentUser");
                string user = "";
                try {
                    user = (Directory.GetFiles(".credentials/currentUser", "*")[0]).Split('-')[1];
                }catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Login required before creating an event");
                    return;
                } 
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                                                                         Scopes,
                                                                         user,
                                                                         System.Threading.CancellationToken.None,
                                                                         new FileDataStore(credPath, true)).Result;
                // Create Google Calendar API service.
                if (credential == null)
                    return;

                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                Event newEvent = new Event()
                {
                    Summary = sum,
                    Location = where,
                    Description = desc,
                    Start = new EventDateTime()
                    {
                        DateTime = st,
                        TimeZone = "America/Vancouver",
                    },
                    End = new EventDateTime()
                    {
                        DateTime = en,
                        TimeZone = "America/Vancouver",
                    },
                    Recurrence = re,
                    Reminders = new Event.RemindersData()
                    {
                        UseDefault = true,
                    }
                };

                String calendarId = "primary";
                EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
                try {
                    Event createdEvent = request.Execute();
                } catch(Exception x)
                {
                    System.Windows.Forms.MessageBox.Show("Failed to create event");
                }
            }
        }
        /// <summary>
        /// todo remake fucntion
        /// </summary>
        /// <returns></returns>
        static public void readEventLocal(Menus form)
        {
            System.Threading.Thread t = System.Threading.Thread.CurrentThread;
            t.Priority = System.Threading.ThreadPriority.Highest;
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename" +
                @"=C:\Users\peymantp\Documents\Calendar_group007\Calendar_group007\Database.mdf;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[Table] ORDER by StartDate", conn);
                //cmd.CommandText = "Select * From [dbo].[Table]";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    eventStruct s = new eventStruct();
                    s.startDate = reader.GetString(1);
                    s.startTime = reader.GetString(2);
                    s.Summary = reader.GetString(3);
                    s.Location = reader.GetString(4);
                    s.Description = reader.GetString(5);
                    s.html = reader.GetString(6);
                    s.endDate = reader.GetString(7);
                    s.endTime = reader.GetString(8);
                    form.events.Add(s);
                }
            }
        }
        /// <summary>
        /// todo remake funciton
        /// </summary>
        /// <param name="events"></param>
        public static void saveEventLocal(Events events)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename" +
                @"=C:\Users\peymantp\Documents\Calendar_group007\Calendar_group007\Database.mdf;Integrated Security=True"))
            {
                conn.Open();
                foreach (var eventItem in events.Items)
                {
                    try
                    {
                        string StartDate;
                        string StartTime = "";
                        string EndDate;
                        string EndTime = "";
                        string Location = nullCatcher(eventItem.Location);
                        string Description = nullCatcher(eventItem.Description);
                        string htmlLink = eventItem.HtmlLink;

                        if (eventItem.Start.Date != null) {
                            StartDate = eventItem.Start.Date;
                            EndDate = eventItem.End.Date;
                        } else {
                            DateTime temp = (DateTime)eventItem.Start.DateTime;
                            StartDate = temp.ToString("yyyy/MM/dd");
                            StartTime = temp.ToString("HH:mm:ss");
                            temp = (DateTime)eventItem.End.DateTime;
                            EndDate = temp.ToString("yyyy/MM/dd");
                            EndTime = temp.ToString("HH:mm:ss");
                        }
                        string sql = @"IF NOT EXISTS(SELECT 1 FROM [dbo].[Table] WHERE Id = '" + eventItem.Id + "')" 
                        + " BEGIN INSERT INTO [dbo].[Table] (Id, StartDate, StartTime, Summary, Location, Description, html, EndData, EndTime) VALUES ('" +
                        eventItem.Id + "', '" +
                        StartDate + "', '" +
                        StartTime + "', '" +
                        eventItem.Summary + "', '" +
                        Location + "', '" +
                        Description + "', '" +
                        htmlLink + "', '" +
                        EndDate + "', '" +
                        EndTime + "') END ELSE " +
                        "BEGIN UPDATE[dbo].[Table] SET "
                        + "StartDate = @StartDate, "
                        + "StartTime = @StartTime, "
                        + "Summary = @Summary, "
                        + "Location = @Locations, "
                        + "Description = @Description, "
                        + "EndData = @EndData, "
                        + "EndTime = @EndTime "
                        + "WHERE " + "Id = @Id END";

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.Parameters.AddWithValue("@StartDate", StartDate);
                        cmd.Parameters.AddWithValue("@StartTime", StartTime);
                        cmd.Parameters.AddWithValue("@Summary", eventItem.Summary);
                        cmd.Parameters.AddWithValue("@Locations", Location);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@EndData", EndDate);
                        cmd.Parameters.AddWithValue("@EndTime", EndTime);
                        cmd.Parameters.AddWithValue("@Id", eventItem.Id);
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    } 
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.ToString(), ex.GetType().ToString());
                    }
                }
                conn.Close();
            }
        }

        private static string nullCatcher(string obj)
        {
            try
            {
                if (!String.IsNullOrEmpty(obj))
                    return obj;
            }
            catch (Exception e)
            {
                return "";
            }
            return "";
        }
    }
}
