using System;

namespace SistemaEmpresaBiblioteca
{
    
    interface IBonus
    {
        double CalcularBonus();
    }

    // Classe base
    class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Salário: R$ {Salario}");
        }
    }

    class Gerente : Funcionario, IBonus
    {
        public string Departamento { get; set; }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Departamento: {Departamento}");
        }

        public double CalcularBonus()
        {
            return Salario * 0.20;
        }
    }

    class Desenvolvedor : Funcionario, IBonus
    {
        public string Linguagem { get; set; }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Linguagem: {Linguagem}");
        }

        public double CalcularBonus()
        {
            return Salario * 0.10;
        }
    }
}