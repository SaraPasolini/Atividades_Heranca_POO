using System;

class Veiculo
{
    public virtual void Mover()
    {
        Console.WriteLine("O veículo está se movendo.");
    }
}

class Carro : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O carro está dirigindo na estrada.");
    }
}

class Bicicleta : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("A bicicleta está sendo pedalada.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Veiculo v1 = new Carro();
        Veiculo v2 = new Bicicleta();

        v1.Mover();
        v2.Mover();
    }
}