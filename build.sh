cd syntSharp/syntSharp.x86
dotnet build
cd bin
dotnet Tools/Mosa.Tool.Launcher.Console.dll -autostart -oMax -vmware-svga -include ../../syntSharp/include syntSharp.x86.dll