using System;
using System.Collections.Generic;


class Aluno
{
    private string _nome;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public Aluno(string nome)
    {
        _nome = nome;
    }

    public void ExibirNome()
    {
        Console.WriteLine("Aluno: " + _nome);
    }
}


class EscolaDependencia
{
    public void ExibirAluno(Aluno aluno)
    {
        Console.Write("Dependência -> ");
        aluno.ExibirNome();
    }
}


class EscolaAssociacao
{
    private Aluno _aluno;

    public EscolaAssociacao(Aluno aluno)
    {
        _aluno = aluno;
    }

    public void ExibirAluno()
    {
        Console.Write("Associação -> ");
        _aluno.ExibirNome();
    }
}


class EscolaAgregacao
{
    private List<Aluno> _alunos = new List<Aluno>();

    public void AdicionarAluno(Aluno aluno)
    {
        _alunos.Add(aluno);
    }

    public void ExibirAlunos()
    {
        Console.WriteLine("Agregação -> Lista de alunos:");
        foreach (var aluno in _alunos)
        {
            aluno.ExibirNome();
        }
    }
}


class EscolaComposicao
{
    private List<Aluno> _alunos = new List<Aluno>();

    public void AdicionarAluno(string nome)
    {
        Aluno aluno = new Aluno(nome);
        _alunos.Add(aluno);
    }

    public void ExibirAlunos()
    {
        Console.WriteLine("Composição -> Lista de alunos:");
        foreach (var aluno in _alunos)
        {
            aluno.ExibirNome();
        }
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("=== PARTE 1: DEPENDÊNCIA ===");
        EscolaDependencia escolaDep = new EscolaDependencia();
        Aluno aluno1 = new Aluno("Pasolini");
        escolaDep.ExibirAluno(aluno1);

        Console.WriteLine("\n=== PARTE 2: ASSOCIAÇÃO ===");
        Aluno aluno2 = new Aluno("Maria");
        EscolaAssociacao escolaAssoc = new EscolaAssociacao(aluno2);
        escolaAssoc.ExibirAluno();

        Console.WriteLine("\n=== PARTE 3: AGREGAÇÃO ===");
        EscolaAgregacao escolaAg = new EscolaAgregacao();
        escolaAg.AdicionarAluno(new Aluno("João"));
        escolaAg.AdicionarAluno(new Aluno("Ana"));
        escolaAg.ExibirAlunos();

        Console.WriteLine("\n=== PARTE 4: COMPOSIÇÃO ===");
        EscolaComposicao escolaComp = new EscolaComposicao();
        escolaComp.AdicionarAluno("Carlos");
        escolaComp.AdicionarAluno("Fernanda");
        escolaComp.ExibirAlunos();

        Console.ReadLine();
    }
}