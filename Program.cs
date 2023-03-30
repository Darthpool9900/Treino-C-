using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            UInt16 idade  = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Digite o número do seu documento:");
            string doc = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua rua:");
            string rua = Console.ReadLine();

            Console.WriteLine("Digite o número da sua casa:");
            UInt32 casa = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Informe seu gênero pressione F para feminino ou M para masculino");
            string gen = Console.ReadKey().ToString();

            if (gen == "m")
            {
                gen = "Masculino";
            }
            else
            {
                gen = "Feminino";
            }

            Console.WriteLine("Nome:" + nome + "\nIdade:" + idade + "\nNúmero de documento:" + doc + "\nRua:" + rua + "Casa:" + casa + "\nSexo:" + gen);

            Console.ReadKey();
        }
    }
}
