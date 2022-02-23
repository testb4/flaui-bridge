
using FlaUI.Core.AutomationElements;
using FlaUI.Core.AutomationElements.Scrolling;

namespace FlaUI.Bridge
{
    public class AutomationElementExtensions
    {
        private AutomationElement element;

        public AutomationElementExtensions(AutomationElement element)
        {
            this.element = element;
        }

        public Button AsButton() { return element.AsButton(); }
        public CheckBox AsCheckBox() { return element.AsCheckBox(); }
        public ComboBox AsComboBox() { return element.AsComboBox(); }
        public DataGridView AsDataGridView() { return element.AsDataGridView(); }
        public Grid AsGrid() { return element.AsGrid(); }
        public GridCell AsGridCell() { return element.AsGridCell(); }
        public GridHeader AsGridHeader() { return element.AsGridHeader(); }
        public GridHeaderItem AsGridHeaderItem() { return element.AsGridHeaderItem(); }
        public GridRow AsGridRow() { return element.AsGridRow(); }
        public HorizontalScrollBar AsHorizontalScrollBar() { return element.AsHorizontalScrollBar(); }
        public Label AsLabel() { return element.AsLabel(); }
        public ListBox AsListBox() { return element.AsListBox(); }
        public ListBoxItem AsListBoxItem() { return element.AsListBoxItem(); }
        public Menu AsMenu() { return element.AsMenu(); }
        public MenuItem AsMenuItem() { return element.AsMenuItem(); }
        public ProgressBar AsProgressBar() { return element.AsProgressBar(); }
        public RadioButton AsRadioButton() { return element.AsRadioButton(); }
        public Slider AsSlider() { return element.AsSlider(); }
        public Tab AsTab() { return element.AsTab(); }
        public TabItem AsTabItem() { return element.AsTabItem(); }
        public TextBox AsTextBox() { return element.AsTextBox(); }
        public Thumb AsThumb() { return element.AsThumb(); }
        public TitleBar AsTitleBar() { return element.AsTitleBar(); }
        public ToggleButton AsToggleButton() { return element.AsToggleButton(); }
        public Tree AsTree() { return element.AsTree(); }
        public TreeItem AsTreeItem() { return element.AsTreeItem(); }
        public VerticalScrollBar AsVerticalScrollBar() { return element.AsVerticalScrollBar(); }
        public Window AsWindow() { return element.AsWindow(); }

    }
}
