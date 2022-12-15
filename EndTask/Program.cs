// See https://aka.ms/new-console-template for more information  
using System.Diagnostics;
using System.Runtime.InteropServices;

[DllImport("user32.dll")]
static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

[DllImport("kernel32.dll")]
static extern IntPtr GetConsoleWindow();

HideTheConsole();

static void HideTheConsole()
{
    ShowWindow(GetConsoleWindow(), 0);
}

string[] All = { "smc_independent", "SR_GameServer",
"SR_ShardManager", "MachineManager", "AgentServer", "FarmManager", "GatewayServer",
"DownloadServer", "GlobalManager", "CustomCertificationServer", "VSROProxy",
"sro_client"};


foreach (var item in All)
{
    foreach (var process in Process.GetProcessesByName(item))
    {
        process.Kill();
    }
}