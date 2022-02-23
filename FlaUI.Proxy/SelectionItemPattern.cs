using FlaUI.Core.AutomationElements;
using FlaUI.Core.Patterns;

namespace FlaUI.Bridge
{
    public class SelectionItemPattern
    {
        private ISelectionItemPattern pattern;

        internal SelectionItemPattern(ISelectionItemPattern pattern)
        {
            this.pattern = pattern;
        }

        public ISelectionItemPatternEventIds EventIds { get { return pattern.EventIds; } }
        public bool IsSelected { get { return pattern.IsSelected; } }
        public AutomationElement SelectionContainer { get { return pattern.SelectionContainer; } }

        public void AddToSelection() { pattern.AddToSelection(); }
        public void RemoveFromSelection() { pattern.RemoveFromSelection(); }
        public void Select() { pattern.Select(); }
    }
}
