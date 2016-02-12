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
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menus());
        }
        public static void Exit()
        {
            Application.Exit();
        }
    }
}
