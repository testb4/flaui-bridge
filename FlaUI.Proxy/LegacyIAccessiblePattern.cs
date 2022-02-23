using FlaUI.Core.AutomationElements;
using FlaUI.Core.Patterns;
using FlaUI.Core.Patterns.Infrastructure;
using FlaUI.Core.WindowsAPI;

namespace FlaUI.Bridge
{
    public class LegacyIAccessiblePattern
    {
        private readonly ILegacyIAccessiblePattern pattern;

        internal LegacyIAccessiblePattern(ILegacyIAccessiblePattern _pattern)
        {
            pattern = _pattern;
        }

        public int ChildId { get { return pattern.ChildId; } }

        public string DefaultAction { get { return pattern.DefaultAction; } }
        public string Description { get { return pattern.Description; } }
        public string Help { get { return pattern.Help; } }
        public string KeyboardShortcut { get { return pattern.KeyboardShortcut; } }
        public string Name { get { return pattern.Name; } }
        public AccessibilityRole Role { get { return pattern.Role; } }
        public AutomationElement[] Selection { get { return pattern.Selection; } }
        public AccessibilityState State { get { return pattern.State; } }
        public string Value { get { return pattern.Value; } }

        public void DoDefaultAction() { pattern.DoDefaultAction(); }
        public void Select(int flagsSelect) { pattern.Select(flagsSelect); }
        public void SetValue(string value) { pattern.SetValue(value); }
    }
}
