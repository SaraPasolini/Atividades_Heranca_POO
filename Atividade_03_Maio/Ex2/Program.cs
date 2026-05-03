interface IEmprestimo
    {
        void Emprestar();
        void Devolver();
    }

    class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Ano: {AnoPublicacao}");
        }
    }

    class Livro : ItemBiblioteca, IEmprestimo
    {
        public string Autor { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Autor: {Autor}");
        }

        public void Emprestar()
        {
            Console.WriteLine($"Livro {Titulo} emprestado!");
        }

        public void Devolver()
        {
            Console.WriteLine($"Livro {Titulo} devolvido!");
        }
    }

    class Revista : ItemBiblioteca, IEmprestimo
    {
        public int NumeroEdicao { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Edição: {NumeroEdicao}");
        }

        public void Emprestar()
        {
            Console.WriteLine($"Revista {Titulo} emprestada!");
        }

        public void Devolver()
        {
            Console.WriteLine($"Revista {Titulo} devolvida!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // FUNCIONÁRIOS
            Gerente gerente = new Gerente
            {
                Nome = "Ana",
                Idade = 40,
                Salario = 8000,
                Departamento = "TI"
            };

            Desenvolvedor dev = new Desenvolvedor
            {
                Nome = "Carlos",
                Idade = 28,
                Salario = 5000,
                Linguagem = "C#"
            };

            Console.WriteLine("=== GERENTE ===");
            gerente.ExibirDados();
            Console.WriteLine($"Bônus: R$ {gerente.CalcularBonus()}");

            Console.WriteLine("\n=== DESENVOLVEDOR ===");
            dev.ExibirDados();
            Console.WriteLine($"Bônus: R$ {dev.CalcularBonus()}");

            Livro livro = new Livro
            {
                Titulo = "Clean Code",
                AnoPublicacao = 2008,
                Autor = "Robert C. Martin"
            };

            Revista revista = new Revista
            {
                Titulo = "Tech Today",
                AnoPublicacao = 2024,
                NumeroEdicao = 10
            };

            Console.WriteLine("\n=== LIVRO ===");
            livro.ExibirInformacoes();
            livro.Emprestar();
            livro.Devolver();

            Console.WriteLine("\n=== REVISTA ===");
            revista.ExibirInformacoes();
            revista.Emprestar();
            revista.Devolver();
        }
    }
