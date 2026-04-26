using System;

class Produto
{
    protected string nome;
    protected double preco;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: R$ {preco}");
    }
}

class Livro : Produto
{
    protected string autor;

    public void ExibirDadosLivro()
    {
        ExibirDados();
        Console.WriteLine($"Autor: {autor}");
    }

    // Método para atribuir valores (facilita no Main)
    public void SetDados(string n, double p, string a)
    {
        nome = n;
        preco = p;
        autor = a;
    }
}