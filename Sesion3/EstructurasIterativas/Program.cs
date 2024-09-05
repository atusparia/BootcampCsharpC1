// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Ingresa los numeros a sumar");
int numero1  = int.Parse(Console.ReadLine());
int numero2  = int.Parse(Console.ReadLine());
int resultado = numero1 + numero2;
Console.WriteLine($"Resultado es {resultado}");
*/

/*
Console.WriteLine("Ingresa el numero limite");
int numerolimite = int.Parse(Console.ReadLine());
int contador = 0;

while (contador<numerolimite)
{
    contador = contador + 1;
    Console.WriteLine(contador);
}
//Console.ReadLine();

Console.WriteLine("DO - WHILE");

Console.WriteLine("Ingresa el numero limite");
contador = 0;

do {
    contador++;
    Console.WriteLine(contador);
} while (contador < numerolimite);

Console.ReadLine();
*/


int opcion = 0;
/*
Console.WriteLine("Menú----------->");
Console.WriteLine("1.- Sumar");
Console.WriteLine("2.- Restar");
Console.WriteLine("3.- Multiplicar");
Console.WriteLine("4.- Dividir");
Console.WriteLine("5.- Potencia");
Console.WriteLine("6.- Raíz");
Console.WriteLine("7.- Salir");
Console.WriteLine("Ingesa la opción");

opcion = int.Parse(Console.ReadLine());
*/
while (opcion !=7)
{
    Console.WriteLine("Menú----------->");
    Console.WriteLine("1.- Sumar");
    Console.WriteLine("2.- Restar");
    Console.WriteLine("3.- Multiplicar");
    Console.WriteLine("4.- Dividir");
    Console.WriteLine("5.- Potencia");
    Console.WriteLine("6.- Raíz");
    Console.WriteLine("7.- Salir");
    Console.WriteLine("Ingesa la opción");

    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Sumando");        
    }
    if(opcion == 2) { Console.WriteLine("Resta"); }
    
}

Console.WriteLine("Salida");