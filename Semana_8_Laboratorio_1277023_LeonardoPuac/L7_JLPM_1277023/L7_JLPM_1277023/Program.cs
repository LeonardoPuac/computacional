namespace L7_JLPM_1277023;

using System;

internal class Program
{

    static void Main(string[]args)
    {
        Console.WriteLine("\nIngrese un número");
        int N = Convert.ToInt32(Console.ReadLine());
        int A = 0, B = 1, C = 0, i = 2;
        string resultados = "";
        resultados = A.ToString();

        if (N > 0)
        {
            resultados = A.ToString();

            if (N > 1)
            {
                resultados = B.ToString();

                while (N > i)
                {
                    C = A + B;
                    resultados = C.ToString();
                    A = B;
                    B = C;
                    i++;

                }
                Console.WriteLine("Resultados " + resultados);
            }
        
           else
          {
            Console.WriteLine("Reslutados " + resultados);
          }
        }
        else
        {
            Console.WriteLine("Resultados " + resultados);
        }
        Console.ReadKey();



    }

}