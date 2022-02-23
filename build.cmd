rem @echo off
rd /s /q build\proxy
md build\proxy\
copy \dev\jni4net\lib\*.* build\proxy\
copy \work\FlaUI\src\libs\Interop\4.5\*.* build\proxy\
copy FlaUI.Proxy\bin\Debug\*.dll build\proxy\
rem copy FlaUI.Proxy\bin\Debug\FlaUI.Proxy.dll build\proxy\
rd /s /q src\generated\java
rd /s /q FlaUI.Bridge\system
rd /s /q FlaUI.Bridge\flaui
\dev\jni4net\bin\proxygen.exe flaui.proxygen.xml -wd work > build\proxy\proxygen.log
