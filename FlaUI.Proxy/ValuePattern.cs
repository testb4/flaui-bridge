using FlaUI.Core.Patterns;

namespace FlaUI.Bridge
{
    public class ValuePattern
    {
        private IValuePattern pattern;

        internal ValuePattern(IValuePattern pattern)
        {
            this.pattern = pattern;
        }

        public bool IsReadOnly { get { return pattern.IsReadOnly; } }
        public string Value { get { return pattern.Value; } }
        public void SetValue(string value) { pattern.SetValue(value); }
    }
}