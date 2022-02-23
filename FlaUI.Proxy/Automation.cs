using System;
using System.Runtime.InteropServices;
using FlaUI.UIA2;
using FlaUI.UIA3;

namespace FlaUI.Bridge
{
    public class Automation
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public Automation() {}

        public UIA2Automation getUIA2Automation()
        {
            return new UIA2Automation();
        }

        public UIA3Automation getUIA3Automation()
        {
            return new UIA3Automation();
        }

        public bool setForeground(IntPtr windowHandle)
        {
            if (IntPtr.Zero != windowHandle && null != windowHandle) {
                return SetForegroundWindow(windowHandle);

            } else {
                return false;
            }
        }

    }
}
