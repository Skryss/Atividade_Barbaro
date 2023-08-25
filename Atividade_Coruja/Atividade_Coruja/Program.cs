using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Coruja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Atividade_1
            double d_nro1 = 0;

            Console.Write("Digite um Número: ");
            d_nro1 = double.Parse(Console.ReadLine());

            Console.Write("Brabo! O Sucessor do numero {2} é {0} e o Antecessor é {1}", d_nro1 + 1, d_nro1 - 1, d_nro1);

            Console.ReadLine();
            #endregion
           

            #region Atividade_2
            String s_nm = "";
            String s_end = "";
            String s_tel = "";

            Console.Write("\nInsira um nome: ");
            s_nm = Console.ReadLine();

            Console.Write("Insira o endereço da sua moradia: ");
            s_end = Console.ReadLine();

            Console.Write("E agora um Telefone para contato: ");
            s_tel = Console.ReadLine();

            Console.WriteLine("\nNome: {0}", s_nm);
            Console.WriteLine("Endereço: {0}", s_end);
            Console.WriteLine("Telefone: {0}", s_tel);

            Console.ReadLine();
            #endregion
            

            #region Atividade_3
            int i_nmr1 = 0;
            int i_nmr2 = 0;

            Console.Write("Digite o 1º Número inteiro: ");
            i_nmr1 = int.Parse(Console.ReadLine());

            Console.Write("Digite agora o 2º Número: ");
            i_nmr2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Perfeito! Aqui está a soma {0}, a subtração {1} e a multiplicação {2}", i_nmr1 + i_nmr2, i_nmr1 - i_nmr2, i_nmr1 * i_nmr2);

            Console.ReadLine();
            #endregion


            #region Atividade_4
            double d_peso1 = 0;
            double d_alt1 = 0;

            Console.Write("digite sua altura: ");
            d_alt1 = double.Parse(Console.ReadLine());

            Console.Write("digite seu peso: ");
            d_peso1 = double.Parse(Console.ReadLine());

            Console.Write("o valor do seu IMC é {0}", d_peso1 / Math.Pow(d_alt1, 2));
            Console.ReadLine();
            #endregion



        }
    }
}
