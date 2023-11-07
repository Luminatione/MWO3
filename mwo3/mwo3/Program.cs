// See https://aka.ms/new-console-template for more information
using System.Reflection;

static string GetVersion()
{
    using (var stream = File.OpenRead("version"))
    {
        return new StreamReader(stream).ReadToEnd();
    }
}
Console.WriteLine(GetVersion());
