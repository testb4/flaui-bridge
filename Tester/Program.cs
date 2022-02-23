using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FlaUI.UIA3;
using FlaUI.UIA2;

namespace Tester
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        static void Main(string[] args)
        {
            /*
            var procs = Process.GetProcesses();
            foreach(var p in procs)
            {
                try
                {
                    if (p.MainWindowHandle != IntPtr.Zero)
                    {
                        Console.WriteLine(p.MainModule.FileName);
                    }
                } catch(Exception) { }
            }*/
            /*
            var app = FlaUI.Core.Application.Attach(@"explorer.exe");
            var automation = new UIA2Automation();
            var window = automation.GetDesktop().FindFirstChild(cf => cf.ByName("Downloads"));
            var combo = window.FindFirstDescendant(cf => cf.ByControlType(controlType: FlaUI.Core.Definitions.ControlType.ComboBox));
            Console.WriteLine(combo.Properties.LabeledBy.Value);
            */
            Console.Read();
            /*
            var app = FlaUI.Core.Application.Attach(@"C:\Program Files\Notepad2\Notepad2.exe");
            var automation = new UIA2Automation();
            Console.WriteLine( app.GetMainWindow(automation).Title );
            IntPtr mainWindowHandle = app.MainWindowHandle;
            */
            //SetForegroundWindow(mainWindowHandle);
        }
    }
}
