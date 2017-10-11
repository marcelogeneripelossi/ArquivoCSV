using System;
using System.IO;

namespace arquivocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nome, email;
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome=Console.ReadLine();

            Console.WriteLine("Digite o seu e-mail: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            idade=Convert.ToUInt16(Console.ReadLine());

            StreamWriter arquivo = new StreamWriter("dados.csv",true);
            arquivo.WriteLine(nome + ";" + email + ";" + idade + ";" + DateTime.Now.ToShortDateString());
            arquivo.Close();

        }
    }
}
