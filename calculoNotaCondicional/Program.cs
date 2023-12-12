using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoNotaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            double semestre1, semestre2, notaFinal;

            Console.WriteLine("Insira a nota do 1º Semestre:");
            semestre1 = double.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------");

            Console.WriteLine("Insira a nota do 2º Semestre:");
            semestre2 = double.Parse(Console.ReadLine());

            notaFinal = semestre1 + semestre2;

            Console.WriteLine("---------------------------");

            if (notaFinal >= 60.00)
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal);
            } else
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal);
                Console.WriteLine("REPROVADO");
            }


            Console.ReadLine();

        }
    }
}
