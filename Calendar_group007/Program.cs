using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

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
                NativeMethods.PostMessage((IntPtr)NativeMethods.HWND_BROADCAST,
                                            NativeMethods.WM_SHOWME,
                                            IntPtr.Zero,
                                            IntPtr.Zero);
            }
        }
        public static void Exit()
        {
            Application.Exit();
        }
    }

    internal class NativeMethods
    {
        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}
