class Pessoa
{
    protected string nome;
    protected int idade;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
    }
}

class Aluno : Pessoa
{
    protected string curso;

    public void ExibirDadosAluno()
    {
        ExibirDados();
        Console.WriteLine($"Curso: {curso}");
    }

    public void SetDados(string n, int i, string c)
    {
        nome = n;
        idade = i;
        curso = c;
    }
}