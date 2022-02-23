@echo off
copy FlaUI.Bridge\bin\Debug\FlaUI.Bridge.dll work\
java -Duser.dir=work -cp jni4net.j-0.8.8.0.jar;target Dene
