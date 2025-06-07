using ModelContextProtocol.Client;

string path = "/Users/tolgacakir/RiderProjects/BasicAiSamplesDotNet/MCP.Server/bin/Debug/net9.0/MCP.Server.dll";

IMcpClient mcpClient = await McpClientFactory
    .CreateAsync(new StdioClientTransport(options: new StdioClientTransportOptions
    {
        Name = "Minimal MCP Server",
        Command = $"dotnet",
        Arguments = [path]
    }));
    
var tools = await mcpClient.ListToolsAsync();

for (int i = 0; i < tools.Count; i++)
{
    Console.WriteLine($"{i} - {tools[i].Name} ({tools[i].Description})");

}

string clientPrompt = Console.ReadLine();

var result = await mcpClient.CallToolAsync(
    "Echo",
    new Dictionary<string, object?>() { ["message"] = clientPrompt });
 
Console.WriteLine($"Result: {result.Content.First(c => c.Type == "text").Text}");


Console.WriteLine("Press any key to exit...");