using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_UnicornioBOSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();
            
            char EI = palavra[0];
            Console.WriteLine($"O primeiro caractere da palavra é: {EI}");

            char ultimaLetra = palavra[palavra.Length - 1];
            Console.WriteLine("Última letra: " + ultimaLetra);

            string PrimeiraAteTerceira = palavra.Substring(0, 3);
            Console.WriteLine("Da primeira Letra ate a Terceira: " + PrimeiraAteTerceira);
            
            char BOBO = palavra[3];
            Console.WriteLine($"A Quarta letra da palavra é: {BOBO}");

            string todasMenosPrimeira = palavra.Substring(1);
            Console.WriteLine("Todas as letras exceto a primeira: " + todasMenosPrimeira);

            string ultimasDuasLetras = palavra.Substring(palavra.Length - 2);
            Console.WriteLine("Duas últimas letras: " + ultimasDuasLetras);

            Console.ReadLine();
        }
    }
}
