// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime fechanacimiento = new DateTime(1985, 6, 8);
var fechaActual = DateTime.Now;

Console.WriteLine($"Naci la fecha: {fechanacimiento.Date.ToString("MM,dd,yy")}");
Console.WriteLine($"la fecha actual es: {fechaActual.Date.ToString("dd/MM/yyy")}");

var restaFechas = fechaActual - fechanacimiento;
Console.WriteLine($"tu edad es: {restaFechas.Days/365}");