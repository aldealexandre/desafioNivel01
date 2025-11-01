namespace desafioNivel01
{
    class Program
    {
        static void Main(string[] args)
        {
            boasVindas();
            nomeCompleto();
            cacular();
            quantidadeCaracteres();



        }

        public static void boasVindas()
        {
            Console.WriteLine("Boas Vindas\n");
            Console.WriteLine("Digite seu nome: ");
            string? nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + "! Seja muito bem - vindo!");
        }

        public static void nomeCompleto()
        {
            Console.WriteLine("Nome completo\n");
            Console.WriteLine("Digite seu nome: ");
            string? nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            string? sobrenome = Console.ReadLine();
            Console.WriteLine("Seu nome completo é: " + nome + " " + sobrenome);
        }

        public static void cacular()
        {
            Console.WriteLine("Cálculos matemáticos\n");
            Console.WriteLine("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            var soma = valor1 + valor2;
            var subtracao = valor1 - valor2;
            var multiplicacao = valor1 * valor2;
            var divisao = valor1 / valor2;
            var media = (valor1 + valor2) / 2;

            Console.WriteLine("Resultados\n");
            Console.WriteLine("Soma: " + soma.ToString("F2"));
            Console.WriteLine("Subtração: " + subtracao.ToString("F2"));
            Console.WriteLine("Multiplicação: " + multiplicacao.ToString("F2"));
            Console.WriteLine("Divisão: " + divisao.ToString("F2"));
            Console.WriteLine("Média: " + media.ToString("F2"));
        }

        public static void quantidadeCaracteres()
        {
            Console.WriteLine("Quantidade de acaracteres\n");
            Console.WriteLine("Digite uma frase: ");
            string? frase = Console.ReadLine();
            int quantidade = frase.Length;
            Console.WriteLine("A frase digitada possui " + quantidade + " caracteres.");
        }

        public static void placaVeiculo()
        {
            Console.WriteLine("Consulta Placa\n");
            Console.WriteLine("Digite a placa do veículo (formato ABC-1234): ");
            string? placa = Console.ReadLine();
            
        }
    }
}
