import flaui.bridge.Automation;
import flaui.bridge.FlaUIBridge;
import flaui.core.Application;
import system.Object;
import system.TimeSpan;

public class Dene {

    public static void main(String[] args) {
        try {
            FlaUIBridge.init();
            Application app = Application.Attach("C:\\Program Files\\Notepad2\\Notepad2.exe", 0);
            Automation automation = new Automation();
            Object automation2 = automation.getUIA2Automation();
            TimeSpan timeout = new TimeSpan(0, 0, 5);
            System.out.println(app.GetMainWindow(automation2, timeout).getTitle());
            automation.setForeground(app.getMainWindowHandle());

        } catch (Exception e) {
            e.printStackTrace();
        }

    }
}
