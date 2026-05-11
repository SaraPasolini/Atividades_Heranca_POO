using System;

class Funcionario
{
    public virtual void ExibirDados()
    {
        Console.WriteLine("Funcionário cadastrado no sistema.");
    }
}

class Gerente : Funcionario
{
    public override void ExibirDados()
    {
        // Chama o método da classe pai
        base.ExibirDados();

        Console.WriteLine("O gerente também é responsável por liderar a equipe.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gerente gerente = new Gerente();

        gerente.ExibirDados();
    }
}