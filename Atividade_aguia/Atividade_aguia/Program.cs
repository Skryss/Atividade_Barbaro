using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aguia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade_N1
            int i_nro1 = 0;

            Console.Write("Escolha um número para ser mostrada a sua tabuada: ");
            i_nro1 = int.Parse(Console.ReadLine());

            Console.WriteLine("1 x {1} = {0}", i_nro1 * 1, i_nro1);
            Console.WriteLine("2 x {1} = {0}", i_nro1 * 2, i_nro1);
            Console.WriteLine("3 x {1} = {0}", i_nro1 * 3, i_nro1);
            Console.WriteLine("4 x {1} = {0}", i_nro1 * 4, i_nro1);
            Console.WriteLine("5 x {1} = {0}", i_nro1 * 5, i_nro1);
            Console.WriteLine("6 x {1} = {0}", i_nro1 * 6, i_nro1);
            Console.WriteLine("7 x {1} = {0}", i_nro1 * 7, i_nro1);
            Console.WriteLine("8 x {1} = {0}", i_nro1 * 8, i_nro1);
            Console.WriteLine("9 x {1} = {0}", i_nro1 * 9, i_nro1);
            Console.WriteLine("10 x {1} = {0}", i_nro1 * 10, i_nro1);
            
            Console.ReadLine();
            #endregion

            #region Atividade_N2
            double d_qua = 0;
            Console.Write("Digite a quantidade de Laudas:");
            d_qua = double.Parse(Console.ReadLine());

            double d_vl = 50.00;
            double d_vt = d_qua * d_vl;

            Console.WriteLine("Valor total encontrado: {0} R$  ", d_vt);

            int i_nu = 3;
            double d_vp = d_vt / i_nu;

            Console.WriteLine("Valor da parcela (em três iguais): {0} R$", d_vp);
            Console.ReadLine();
            #endregion

            #region Atividade_N3
            String s_nm = "";

            Console.Write("Coloque seu Nome: ");
            s_nm = Console.ReadLine();

            Console.WriteLine("Boa Vindas! {0} Esperamos que você se sinta confortavel!", s_nm);
            Console.Write("Aperte ENTER para finalizar");
            Console.ReadLine();
            #endregion
        }
    }
}
