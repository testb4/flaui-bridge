package flaui.bridge;

import net.sf.jni4net.Bridge;

import java.io.File;
import java.net.URL;

public class FlaUIBridge {

    public static final String FLA_UI_BRIDGE_DLL = "FlaUI.Bridge.dll";

    public static void init() throws Exception {
        File libsDir = getLibsDir();
        Bridge.setVerbose(true);
        Bridge.init(libsDir);
        Bridge.LoadAndRegisterAssemblyFrom(new File(libsDir, FLA_UI_BRIDGE_DLL));
    }

    private static File getLibsDir() {
        URL dllResourceUrl = FlaUIBridge.class.getClassLoader().getResource(FLA_UI_BRIDGE_DLL);
        if (null==dllResourceUrl) {
            throw new RuntimeException(FLA_UI_BRIDGE_DLL + " is not in classpath.");
        }
        String path = dllResourceUrl.getFile();
        int beginIndex = path.indexOf('/')+1;
        int endIndex = path.lastIndexOf('/');
        path = path.substring(beginIndex, endIndex);
        return new File(path);
    }
}
