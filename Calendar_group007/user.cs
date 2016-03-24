using System;
using System.Threading;
using System.IO;
using System.Windows.Forms;
/// <summary>
/// arthor: Peyman Justin
/// </summary>
namespace PJCalender
{
    /// <summary>
    /// Handles all user files and actions
    /// </summary>
    class User
    {

        public User(String userLoggedIn, Menus mainForm)
        {
            if (!System.IO.Directory.Exists(".credentials/.archived.users"))
                System.IO.Directory.CreateDirectory(".credentials/.archived.users");
            string[] files = Directory.GetFiles(@".credentials/.archived.users", "*");

            bool fileNotFound = true;

            foreach (String file in files)
            {
                if (file.Split('-')[1].Equals(userLoggedIn))
                {
                    File.Move(file, @".credentials/currentUser/" + file.Split('\\')[1]);
                    userLoggedIn = file.Split('-')[1];
                    fileNotFound = false;
                    break;
                }
            }

            if (fileNotFound)
            {
                if (!String.IsNullOrEmpty(userLoggedIn))
                {

                    Thread t = new Thread(() => new google(mainForm, userLoggedIn));
                    t.Name = "Google";
                    t.Start();
                }
            }

            mainForm.displayAgenda();

        }

        static public void Logout()
        {
            try
            {
                string file = Directory.GetFiles(@".credentials/currentUser", "*")[0];
                File.Delete(@".credentials/.archived.users/" + file.Split('\\')[1]);
                File.Move(file, @".credentials/.archived.users/" + file.Split('\\')[1]);
            }
            catch (System.IndexOutOfRangeException indexEx)
            {
                MessageBox.Show(indexEx.ToString(), indexEx.GetType().ToString());
            }
        }

        static public String currentUserLoggedIn()
        {
            String file;
            try
            {
                if (!Directory.Exists(".credentials/currentUser"))
                {
                    Directory.CreateDirectory(".credentials/currentUser");
                    return null;
                }
                else {
                    file = Directory.GetFiles(".credentials/currentUser", "*")[0];

                    return file.Split('-')[1];
                }
            }
            catch (System.IndexOutOfRangeException ex)
            {
                //MessageBox.Show(ex.ToString(), ex.GetType().ToString());
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString());
            }
            return null;
        }
    }
}
