
// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================
// Autor: [Wilman Quiñonez]

using System.Reflection;
var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

if (args.Length > 0)
{
    switch (args[0])
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break;

        case "--version":
            Console.WriteLine($"Versión del ensamblado: {version}");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Error: Comando desconocido: '{args[0]}'");
            Console.WriteLine($"Use '--help' para ver la lista de comandos disponibles.");
            MostrarAyuda();
            Environment.Exit(1);
             break;
    
    }      
}

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Versión del ensamblado: {version}");
Console.WriteLine($"Versión: 1.0.0");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estado: Proyecto inicializado");

Console.WriteLine("Estructura del proyecto:");
Console.WriteLine("  InventarioApp/");
Console.WriteLine("    ├── Program.cs");
Console.WriteLine("    ├── inventarioApp.csproj");
Console.WriteLine("    └── .gitignore");
Console.WriteLine("    └── README.md");
Console.WriteLine("    └── src/ ");
Console.WriteLine("     └── Modulos/ (Proxima claese)");
Console.WriteLine();
Console.WriteLine("Proxiomo paso: Agregar Checkpoint");

void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");
}