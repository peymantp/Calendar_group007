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
            UserCredential credential;

            using (var stream = new System.IO.FileStream("client_secret.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                //string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string credPath = (".credentials/currentUser");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                                                                         Scopes,
                                                                         user,
                                                                         System.Threading.CancellationToken.None,
                                                                         new FileDataStore(credPath, true)).Result;

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
                    // List events.s
                    Events events = request.Execute();
                    form.displayAgenda(events);
                }   
                catch (System.Net.Http.HttpRequestException requestEx)
                {
                    System.Windows.Forms.MessageBox.Show(requestEx.ToString(), requestEx.GetType().ToString());
                }
            }


        }
    }
}
