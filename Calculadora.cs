public class Calculadora
{ 
   public static void CalcularSoma()
{
    double a, b, resultado;

    Console.WriteLine("--- Soma A+B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = Aritmetica.soma (a, b);

    Console.WriteLine($"{a} somado com {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void CalcularSubtracao()
{
    double a, b, resultado;

    Console.WriteLine("--- Subtração A-B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = Aritmetica.subtracao (a, b);

    Console.WriteLine($"{a} subtraindo {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void CalcularMultiplicacao()
{
    double a, b, resultado;

    Console.WriteLine("--- Multiplicação A*B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = Aritmetica.multiplicacao (a, b);

    Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void CalcularDivisao()
{
    double a, b, resultado;

    Console.WriteLine("--- Divisão A/B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    if (b == 0)
    {
        Console.WriteLine("\nNão é possível dividir por zero.");
    }
    else
    {
        resultado = Aritmetica.divisao (a, b)
 / b;
        Console.WriteLine($"{a} dividido por {b} é {resultado}");
    }

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

}