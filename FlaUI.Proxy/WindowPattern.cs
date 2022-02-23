using FlaUI.Core.Definitions;
using FlaUI.Core.Patterns;

namespace FlaUI.Bridge
{
    public class WindowPattern
    {
        private IWindowPattern pattern;

        internal WindowPattern(IWindowPattern pattern)
        {
            this.pattern = pattern;
        }

        public bool CanMaximize { get { return pattern.CanMaximize; } }
        public bool CanMinimize { get { return pattern.CanMinimize; } }
        public bool IsModal { get { return pattern.IsModal; } }
        public bool IsTopmost { get { return pattern.IsTopmost; } }
        public WindowInteractionState WindowInteractionState { get { return pattern.WindowInteractionState; } }
        public WindowVisualState WindowVisualState { get { return pattern.WindowVisualState; } }

        public void Close() { pattern.Close(); }
        public void SetWindowVisualState(WindowVisualState state) { pattern.SetWindowVisualState(state); }
        public bool WaitForInputIdle(int milliseconds) { return pattern.WaitForInputIdle(milliseconds); }
    }
}
