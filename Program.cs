
// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================
// Autor: [Wilman Quiñonez]

using System.Reflection;
var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;


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