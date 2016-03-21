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

namespace PJCalender
{

    class google
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        public google(Menus form, string user)
        {
            UserCredential credential = null;
            
            using (var stream = new System.IO.FileStream("client_secret.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                //string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string credPath = (".credentials/currentUser");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                                                                         Scopes,
                                                                         user,
                                                                         System.Threading.CancellationToken.None,
                                                                         new FileDataStore(credPath, true)).Result
                ;
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
                request.TimeMin = DateTime.Now;
                request.ShowDeleted = false;
                request.SingleEvents = true;
                request.TimeMax = DateTime.Now.AddYears(1); //todo change number to 20
                request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

                try
                {
                    Events events = request.Execute();
                    saveEventLocal(events);
                    form.displayAgenda();
                }
                catch (System.Net.Http.HttpRequestException requestEx)
                {
                    System.Windows.Forms.MessageBox.Show(requestEx.ToString(), requestEx.GetType().ToString());
                }
            }
        }

        static public ArrayList readEventLocal()
        {
            ArrayList events = new ArrayList();
            if (!System.IO.Directory.Exists(".save/currentUser"))
                return null;
            string[] files = Directory.GetFiles(@".save/currentUser", "*");
            foreach (String fileName in files)
            {
                using (StreamReader file = File.OpenText(fileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Event calEvent = (Event)serializer.Deserialize(file, typeof(Event));
                    events.Add(calEvent);
                }
            }
            return events;
        }

        public static void saveEventLocal(Events events)
        {
            if (!System.IO.Directory.Exists(".save/currentUser"))
                System.IO.Directory.CreateDirectory(".save/currentUser");

            foreach (var eventItem in events.Items)
            {
                try
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(".save/currentUser/" + eventItem.Id + ".json");
                    string json = JsonConvert.SerializeObject(eventItem, Formatting.Indented);
                    file.WriteLine(json);
                    try
                    {
                        file.Close();
                    }
                    catch (EncoderFallbackException fallback)
                    {
                        System.Windows.Forms.MessageBox.Show(fallback.ToString(), fallback.GetType().ToString());
                    }
                }
                catch (System.IO.DirectoryNotFoundException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString(), ex.GetType().ToString());
                }
                catch (System.IO.IOException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString(), ex.GetType().ToString());
                }
                catch (System.Security.SecurityException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString(), ex.GetType().ToString());
                }
            }
        }
    }
}
