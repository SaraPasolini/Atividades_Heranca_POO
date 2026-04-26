class Dispositivo
{
    protected string marca;
    protected string modelo;

    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
    }
}

class Celular : Dispositivo
{
    protected int armazenamento;

    public void ExibirDadosCelular()
    {
        ExibirDados();
        Console.WriteLine($"Armazenamento: {armazenamento}GB");
    }

    public void SetDados(string m, string mod, int arm)
    {
        marca = m;
        modelo = mod;
        armazenamento = arm;
    }
}

class Program
{
    static void Main()
    {
        // Produto / Livro
        Livro livro = new Livro();
        livro.SetDados("Dom Casmurro", 39.90, "Machado de Assis");
        Console.WriteLine("=== Livro ===");
        livro.ExibirDadosLivro();

        Console.WriteLine();

        // Pessoa / Aluno
        Aluno aluno = new Aluno();
        aluno.SetDados("Ana", 20, "Sistemas de Informação");
        Console.WriteLine("=== Aluno ===");
        aluno.ExibirDadosAluno();

        Console.WriteLine();

        // Dispositivo / Celular
        Celular celular = new Celular();
        celular.SetDados("Samsung", "Galaxy S21", 128);
        Console.WriteLine("=== Celular ===");
        celular.ExibirDadosCelular();
    }
}