using System;

class Matematica
{
    // Multiplica dois inteiros
    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    // Multiplica três inteiros
    public int Multiplicar(int a, int b, int c)
    {
        return a * b * c;
    }

    // Multiplica dois doubles
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Matematica calc = new Matematica();

        Console.WriteLine("Multiplicação de 2 inteiros: " +
            calc.Multiplicar(2, 3));

        Console.WriteLine("Multiplicação de 3 inteiros: " +
            calc.Multiplicar(2, 3, 4));

        Console.WriteLine("Multiplicação de doubles: " +
            calc.Multiplicar(2.5, 3.2));
    }
}