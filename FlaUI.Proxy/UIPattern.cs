using FlaUI.Core.AutomationElements;
using FlaUI.Core.Patterns;

namespace FlaUI.Bridge
{
    public class UIPattern
    {
        public static LegacyIAccessiblePattern getLegacyIAccessible(AutomationElement element)
        {
            ILegacyIAccessiblePattern pattern = element.Patterns.LegacyIAccessible.PatternOrDefault;
            return pattern != null ? new LegacyIAccessiblePattern(pattern) : null;
        }
        public static InvokePattern getInvoke(AutomationElement element)
        {
            IInvokePattern pattern = element.Patterns.Invoke.PatternOrDefault;
            return pattern != null ? new InvokePattern(pattern) : null;
        }
        public static SelectionItemPattern getSelectionItem(AutomationElement element)
        {
            ISelectionItemPattern pattern = element.Patterns.SelectionItem.PatternOrDefault;
            return pattern != null ? new SelectionItemPattern(pattern) : null;
        }
        public static TextPattern getText(AutomationElement element)
        {
            ITextPattern pattern = element.Patterns.Text.PatternOrDefault;
            return pattern!=null ? new TextPattern(pattern) : null;
        }
        public static ValuePattern getValue(AutomationElement element)
        {
            IValuePattern pattern = element.Patterns.Value.PatternOrDefault;
            return pattern != null ? new ValuePattern(pattern) : null;
        }
        public static WindowPattern getWindow(AutomationElement element)
        {
            IWindowPattern pattern = element.Patterns.Window.PatternOrDefault;
            return pattern != null ? new WindowPattern(pattern) : null;
        }
    }

}
