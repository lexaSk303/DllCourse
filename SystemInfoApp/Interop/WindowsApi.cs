using System.Runtime.InteropServices;

namespace SystemInfoApp.Interop;

public static class WindowsApi
{
    [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", CallingConvention = CallingConvention.Winapi)]
    public static extern uint GetCurrentProcessId();
}