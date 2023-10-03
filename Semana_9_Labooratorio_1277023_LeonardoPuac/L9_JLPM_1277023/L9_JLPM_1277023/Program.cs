namespace L9_JLPM_1277023;

class Program 

{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            // Calcula la sumatoria desde 1 hasta el número ingresado usando un do-while
            int sumatoria = 0;
            int contador = 1;
            do
            {
                sumatoria += contador;
                contador++;
            } while (contador <= numero);

            Console.WriteLine("Resultado de sumatoria " + sumatoria);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\nTabla del " + i + ":\t");

                for (int j = 1; j <= numero; j++)
                {
                    Console.Write(i * j + "\t");
                }
            }

            Console.ReadLine();
        }

    }
}


