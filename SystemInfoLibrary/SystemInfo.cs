namespace SystemInfoLibrary;

public sealed class SystemInfo
{
    public string GetApplicationName() => "Student System Programming";
    public string GetLibraryVersion() => "1.2.0";
    public string GetRuntimeDescription() => $".NET {Environment.Version}";
    public string GetComputerName() => Environment.MachineName;
}