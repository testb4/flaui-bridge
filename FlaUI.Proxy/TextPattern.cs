using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Patterns;
using System.Drawing;

namespace FlaUI.Bridge
{
    public class TextPattern
    {
        private ITextPattern pattern;

        internal TextPattern(ITextPattern pattern)
        {
            this.pattern = pattern;
        }

        public ITextRange DocumentRange { get { return pattern.DocumentRange; } }
        public SupportedTextSelection SupportedTextSelection { get { return pattern.SupportedTextSelection; } }

        public ITextRange[] GetSelection() { return pattern.GetSelection(); }
        public ITextRange[] GetVisibleRanges() { return pattern.GetVisibleRanges(); }
        public ITextRange RangeFromChild(AutomationElement child) { return pattern.RangeFromChild(child); }
        public ITextRange RangeFromPoint(Point point) { return pattern.RangeFromPoint(point); }
    }
}