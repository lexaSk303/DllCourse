using SystemInfoApp.Interop;
using SystemInfoLibrary;

Console.WriteLine("=== Первое приложение ===");
var info = new SystemInfo();

Console.WriteLine($"Название: {info.GetApplicationName()}");
Console.WriteLine($"Версия библиотеки: {info.GetLibraryVersion()}");
Console.WriteLine($"Имя компьютера: {info.GetComputerName()}");
Console.WriteLine($"PID процесса: {WindowsApi.GetCurrentProcessId()}");