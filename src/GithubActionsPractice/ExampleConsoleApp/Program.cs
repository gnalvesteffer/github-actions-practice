using ExampleClassLibrary;
using System.Reflection;

var exampleClassLibraryAssembly = Assembly.Load(nameof(ExampleClassLibrary));
Console.WriteLine($"{nameof(ExampleClassLibrary)} v{exampleClassLibraryAssembly.GetName().Version}");

var printerTypes = exampleClassLibraryAssembly.GetTypes().Where(type => typeof(IPrinter).IsAssignableFrom(type) && !type.IsInterface);
foreach (Type printerType in printerTypes)
{
    if (Activator.CreateInstance(printerType) is IPrinter printer)
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"{printerType}:");
        Console.BackgroundColor = ConsoleColor.Black;
        printer.Print();
        Console.WriteLine();
        Console.WriteLine();
    }
}
