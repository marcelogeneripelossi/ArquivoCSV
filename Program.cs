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

            FileInfo fi = new FileInfo("dados_cabecalho.csv");

            StreamWriter arquivo;
            arquivo = new StreamWriter("dados_cabecalho.csv",true);

            if(!fi.Exists){
            arquivo.WriteLine("Nome" + ";" + "E-mail" + ";" + "Idade" + ";" + "Data de Cadastro");

            }
            else {

            arquivo.WriteLine(nome + ";" + email + ";" + idade + ";" + DateTime.Now.ToShortDateString());
                
            }

            arquivo.Close();

        }
    }
}
