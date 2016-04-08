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
        /// <summary>
        /// creates files for new user 
        /// </summary>
        /// <param name="userLoggedIn">username</param>
        /// <param name="mainForm">parent form</param>
        public User(String userLoggedIn, Menus mainForm)
        {
            if (!System.IO.Directory.Exists(".credentials/.archived.users"))
                System.IO.Directory.CreateDirectory(".credentials/.archived.users");
            string[] files = Directory.GetFiles(@".credentials/.archived.users", "*");

            bool fileNotFound = true;
            userLoggedIn = "user";
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

                    Thread t = new Thread(() => new google(mainForm));
                    t.Name = "Google";
                    t.Start();
                }
            }

            Menus.displayAll(mainForm); // make delegate

        }
        /// <summary>
        /// Logout current user
        /// </summary>
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
        /// <summary>
        /// to do delete this
        /// </summary>
        /// <returns></returns>
        static public string currentUserLoggedIn()
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
