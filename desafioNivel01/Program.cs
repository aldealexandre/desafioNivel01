using System.Globalization;

namespace desafioNivel01
{
    class Program
    {
        static void Main(string[] args)
        {
            //boasVindas();
            //nomeCompleto();
            //cacular();
            //quantidadeCaracteres();
            //placaVeiculo();
            dataAtual();



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
            Console.WriteLine("Digite a placa do veículo (formato ABC1234): ");
            string? placa = Console.ReadLine()?.Trim();
            if(string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Entrada vazia!");
            }
            else if (placa.Length != 7)
            {
                Console.WriteLine("Placa inválida! Deve conter 7 caracteres.");
            }
            else
            {
                string letras = placa.Substring(0, 3);
                string numeros = placa.Substring(3, 4);
                bool letrasValidas = letras.All(char.IsLetter);
                bool numerosValidos = numeros.All(char.IsDigit);
                if (letrasValidas && numerosValidos)
                {
                    Console.WriteLine("Placa válida!");
                }
                else
                {
                    Console.WriteLine("Placa inválida! Formato correto é ABC1234.");
                }
            }
        }

        public static void dataAtual()
        {
            DateOnly dataAtual = new DateOnly(2025,11,03);
            Console.WriteLine(dataAtual.ToString("D", CultureInfo.CreateSpecificCulture("pt-br")));
            Console.WriteLine(dataAtual.ToString("d", CultureInfo.CreateSpecificCulture("pt-br")));

            var hora = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(hora.ToString("HH:mm"));

            Console.WriteLine(dataAtual.ToString("d MMMM yyyy", CultureInfo.CreateSpecificCulture("pt-br")));
        }

    }
}
