using System.ComponentModel;
using ModelContextProtocol.Server;
using Serilog;

namespace MCP.Server.Tools;

[McpServerToolType]
public class CalculatorTool
{

    [McpServerTool, Description("Returns sum of two numbers")]
    public static int Sum(int a, int b)
    {
        Log.Information("Sum of two numbers is {a} and {b}", a, b);
        return a + b;
    }
    
    [McpServerTool, Description("Returns difference between two numbers")]
    public static int Difference(int a, int b)
    {
        Log.Information("Difference between two numbers is {a} and {b}", a, b);
        return a - b;
    }
    
    [McpServerTool, Description("Returns product of two numbers")]
    public static int Product(int a, int b)
    {
        Log.Information("Product of two numbers is {a} and {b}", a, b);
        return a * b;
    }

    [McpServerTool, Description("Returns quotient of two numbers")]
    public static int Quotient(int a, int b)
    {
        if (b == 0) 
            throw new DivideByZeroException("Cannot divide by zero.");
        
        Log.Information("Quotient of two numbers is {a} and {b}", a, b);
        return a / b;
    }
}