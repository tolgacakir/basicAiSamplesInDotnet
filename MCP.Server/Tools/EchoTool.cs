using System.ComponentModel;
using ModelContextProtocol.Server;
using Serilog;

namespace MCP.Server.Tools;

[McpServerToolType]
public static class EchoTool
{
    [McpServerTool, Description("Returns back the provided message.")]
    public static string Echo(string message)
    {
        Log.Information($"Echo: {message}");
        return $"Echo: {message}";
    }
}