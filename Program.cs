
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
            Environment.Exit(2);
             break;
    
    }      
}

MostrarBanner();
// Modo interativo
Console.WriteLine("Ingrese un comando (o 'salir' para terminar):");
string? entrada = Console.ReadLine(); // STDIN para leer la entrada del usuario

if(string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir")
{
    Console.WriteLine("No se ingresó ningún comando. Saliendo del programa."); //STDOut para mostrar mensaje de salida
    Environment.Exit(0);
}


/*
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
*/
void MostrarBanner()
{
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
    Console.WriteLine();
    Console.WriteLine($"Versión: {version}");
    Console.WriteLine($".NET: {Environment.Version}");
    Console.WriteLine($"Sistema: {Environment.OSVersion.Platform}");
    Console.WriteLine();
}

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