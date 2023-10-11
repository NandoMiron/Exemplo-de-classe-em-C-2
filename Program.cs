using Aula40Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario a, b;                                          //cria 2 variaveis do tipo Funcionario
        a = new Funcionario();                                     //cria um objeto do tipo funcionario
        b = new Funcionario();                                     //cria um objeto do tipo funcionario


        /* Pede ao  usuario que ensira dos dados do primeiro funcionario e armazena os dados nas
         * variaveis nome e salario */
        Console.WriteLine("Dados do primeiro funcionario : ");
        Console.Write("Nome : ");
        a.Nome = Console.ReadLine();
        Console.Write("Sálario : ");
        a.Salario = Double.Parse(Console.ReadLine());

        /* Pede ao  usuario que ensira dos dados do primeiro funcionario e armazena os dados nas
         * variaveis nome e salario */

        Console.WriteLine("Dados do segundo funcionario : ");
        Console.Write("Nome : ");
        b.Nome = Console.ReadLine();
        Console.Write("Sálario : ");
        b.Salario = Double.Parse(Console.ReadLine());



        double media = (a.Salario + b.Salario) / 2; // cria uma variavel media e calcula a media dos salarios do usuarios

        Console.WriteLine("Salario medio : " + media.ToString("F2"));  //imprime a media dos salarios


    }
}