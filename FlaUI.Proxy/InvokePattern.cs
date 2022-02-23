using FlaUI.Core.Patterns;

namespace FlaUI.Bridge
{
    public class InvokePattern
    {
        private IInvokePattern pattern;

        internal InvokePattern(IInvokePattern pattern)
        {
            this.pattern = pattern;
        }

        public IInvokePatternEventIds Events { get { return pattern.EventIds; } }

        public void Invoke() { pattern.Invoke(); }
    }
}
