
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core;
using System;
using System.Drawing;
using System.Globalization;

namespace FlaUI.Bridge
{
    public class AutomationProperty
    {
        private readonly FrameworkAutomationElementBase.IProperties values;

        private AutomationProperty(FrameworkAutomationElementBase.IProperties _values)
        {
            values = _values;
        }

        public static AutomationProperty ofElement(AutomationElement element)
        {
            return new AutomationProperty(element.Properties);
        }

        public string AcceleratorKey { get { return values.AcceleratorKey; } }
        public string AccessKey { get { return values.AccessKey; } }
        public string AriaProperties { get { return values.AriaProperties; } }
        public string AriaRole { get { return values.AriaRole; } }
        public string AutomationId { get { return values.AutomationId; } }
        public Rectangle BoundingRectangle { get { return values.BoundingRectangle; } }
        public string ClassName { get { return values.ClassName; } }
        public Point ClickablePoint { get { return values.ClickablePoint; } }
        public AutomationElement[] ControllerFor { get { return values.ControllerFor; } }
        public ControlType ControlType { get { return values.ControlType; } }
        public CultureInfo Culture { get { return values.Culture; } }
        public AutomationElement[] DescribedBy { get { return values.DescribedBy; } }
        public AutomationElement[] FlowsFrom { get { return values.FlowsFrom; } }
        public AutomationElement[] FlowsTo { get { return values.FlowsTo; } }
        public string FrameworkId { get { return values.FrameworkId; } }
        public bool HasKeyboardFocus { get { return values.HasKeyboardFocus; } }
        public string HelpText { get { return values.HelpText; } }
        public bool IsContentElement { get { return values.IsContentElement; } }
        public bool IsControlElement { get { return values.IsControlElement; } }
        public bool IsDataValidForForm { get { return values.IsDataValidForForm; } }
        public bool IsEnabled { get { return values.IsEnabled; } }
        public bool IsKeyboardFocusable { get { return values.IsKeyboardFocusable; } }
        public bool IsOffscreen { get { return values.IsOffscreen; } }
        public bool IsPassword { get { return values.IsPassword; } }
        public bool IsPeripheral { get { return values.IsPeripheral; } }
        public bool IsRequiredForForm { get { return values.IsRequiredForForm; } }
        public string ItemStatus { get { return values.ItemStatus; } }
        public string ItemType { get { return values.ItemType; } }
        public AutomationElement LabeledBy { get { return values.LabeledBy; } }
        public LiveSetting LiveSetting { get { return values.LiveSetting; } }
        public string LocalizedControlType { get { return values.LocalizedControlType; } }
        public string Name { get { return values.Name; } }
        public IntPtr NativeWindowHandle { get { return values.NativeWindowHandle; } }
        public bool OptimizeForVisualContent { get { return values.OptimizeForVisualContent; } }
        public OrientationType Orientation { get { return values.Orientation; } }
        public int ProcessId { get { return values.ProcessId; } }
        public string ProviderDescription { get { return values.ProviderDescription; } }
        public int[] RuntimeId { get { return values.RuntimeId; } }
    }
}
