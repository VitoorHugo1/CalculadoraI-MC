namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            #region Verificando Idades
            if (idade <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade Invalida !");
                Console.ResetColor();
            }


            if (idade >= 15 && idade <= 60)
                PessoaDe20a60Anos();

            else if (idade > 60)
                PessoaAcimaDe60Anos();
            #endregion
        }

        public static void PessoaDe20a60Anos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" VALORES DO IMC: PESSOAS DE 15 A 60 ANOS");
            Console.ResetColor();
            Console.WriteLine("  ____________________________________");
            Console.WriteLine("  | VALORES DO IMC  |  CLASSIFICAÇÃO |");
            Console.WriteLine("  |_________________|________________|");
            Console.WriteLine("  | Menor que 18,5  | Baixo peso     |");
            Console.WriteLine("  | De 18,5 a 24,99 | Normal         |");
            Console.WriteLine("  | De 25 a 29,99   | Sobrepeso      |");
            Console.WriteLine("  | Maior que 30    | Obesidade      |");
            Console.WriteLine("  |_________________|________________|");

            Console.WriteLine();

            Console.Write("Digite o seu Peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.Write("Digite sua Altura ex(1.60): ");
            float altura = float.Parse(Console.ReadLine());

            if (altura < 0 || peso < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Peso ou altura invalida !");
                Console.ResetColor();
            }


            float finalIMC = peso / (altura * altura);

            Console.WriteLine($"IMC = {finalIMC}");

            Console.ReadKey();

        }


        public static void PessoaAcimaDe60Anos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" VALORES DO IMC: PESSOAS ACIMA DE 60 ANOS");
            Console.ResetColor();
            Console.WriteLine("  ____________________________________");
            Console.WriteLine("  | VALORES DO IMC |  CLASSIFICAÇÃO  |");
            Console.WriteLine("  |________________|_________________|");
            Console.WriteLine("  | Menor que 22   |  Baixo peso     |");
            Console.WriteLine("  | De 22 a 27     |  Normal         |");
            Console.WriteLine("  | De 27 a 29,99  |  Sobrepeso      |");
            Console.WriteLine("  | Maior que 30   |  Obesidade      |");
            Console.WriteLine("  |________________|_________________|");

            Console.Write("Digite o seu Peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.Write("Digite sua Altura ex(1.60): ");
            float altura = float.Parse(Console.ReadLine());

            if (altura < 0 || peso < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Peso ou altura invalida !");
                Console.ResetColor();
            }


            float finalIMC = peso / (altura * altura);

            Console.WriteLine($"IMC = {finalIMC}");

            Console.ReadKey();
        }
    }
}
