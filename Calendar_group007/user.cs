using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace PJCalender
{
    class User
    {
        String userLoggedIn;
        public User(String type, Menus mainForm)
        {
            //currentUserLoggedIn();
            if (type.Equals("Login"))
            {
                if (!System.IO.Directory.Exists(".credentials/.archived.users"))
                    System.IO.Directory.CreateDirectory(".credentials/.archived.users");
                string[] files = Directory.GetFiles(@".credentials/.archived.users", "*");

                UsernameDialog login = new UsernameDialog(mainForm);
                login.ShowDialog();

                userLoggedIn = login.username;

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
                        
                    }
                }

                type = "Logout";
            }
            else {
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
                type = "Login";
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
            catch(System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString());
            }
            return null;
        }
    }
}
