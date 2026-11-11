using SystemInfoLibrary;

Console.WriteLine("=== Второе приложение ===");
var info = new SystemInfo();

Console.WriteLine($"Название: {info.GetApplicationName()}");
Console.WriteLine($"Версия библиотеки: {info.GetLibraryVersion()}");
Console.WriteLine($"Среда выполнения: {info.GetRuntimeDescription()}");
Console.WriteLine($"Имя компьютера: {info.GetComputerName()}");