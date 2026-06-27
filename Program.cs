
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
Console.WriteLine("Configuración .csproj");
Console.WriteLine("Carpetas scr/ creada");
Console.WriteLine("Metadatos de inicialización implementados");
Console.WriteLine();
Console.WriteLine("Proxiomo paso: Agregar argumentos CLI y configuración de repositorio en Github");