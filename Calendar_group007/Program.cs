using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading;

namespace PJCalender
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        [STAThread]
        static void Main(string[] args)
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Menus());
                mutex.ReleaseMutex();
            }
            else {
                MessageBox.Show("only one instance at a time");
            }
        }
        public static void Exit()
        {
            Application.Exit();
        }
    }
}
