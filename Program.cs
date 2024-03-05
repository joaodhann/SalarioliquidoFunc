using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SalarioliquidoFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário: ");
            double salb = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu vale alimentação: ");
            double valeal = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de filhos: ");
            int filhos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu número de horas extras: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que você recebe por hora extra: ");
            double hrextra = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor do INSS");
            double inss = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do IRRF");
            double irrf = double.Parse(Console.ReadLine());

            double ft = filhos * 100;
            double ht = horas * hrextra;

            double saltotal = salb + valeal + ft + ht - inss - irrf;

            Console.WriteLine("Seu salário líquido: " + saltotal.ToString("C"));

            Console.ReadKey();

        }
    }
}
