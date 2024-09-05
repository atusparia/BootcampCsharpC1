double numero1 = 5;
double numero2 = 10;

double resultado = numero1 + numero2;

//con double para trabajar con decimales
void Suma(double n1, double n2)
{
    double resultado = n1 + n2;
    Console.WriteLine(resultado);
}

void Sumar2()
{
    resultado = numero1 + numero2;
    Console.WriteLine(resultado);
}


double Sumar3(double n1, double n2)
{
    double resultado = n1 + n2;
    return resultado;
}

Func<double, double, double> SumaLamda = (n1, n2) => (n1 + n2);

Console.WriteLine("Sumando 1 void, parámetros");
Suma(5,10);

Console.WriteLine("Sumando 2 void Global");
Sumar2();

//se hace esto porque devuelve un valor
Console.WriteLine("Sumando 3 devolución, parámetros");
double result = Sumar3(5,10);
Console.WriteLine(result);

Console.WriteLine("Sumando 4 con Lambda");
double result2 = SumaLamda(5, 10);
Console.WriteLine(result2);