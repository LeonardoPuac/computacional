namespace PROYECTO_2;

using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar la cantidad de partidas requeridas:");

            int cantidadPartidas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar la cantidad de tiros al dado por partida:");

            int cantidadTiros = Convert.ToInt32(Console.ReadLine());

            int puntosCasa = 0;

            int puntosUsuario = 0;

            int partidasGanadasCasa = 0;

            int partidasGanadasUsuario = 0;

            Random random = new Random();

            for (int i = 0; i < cantidadPartidas; i++)
            {
                // Se reinician los puntos al momento para cada partida
                puntosCasa = 0;
                puntosUsuario = 0;

                for (int j = 0; j < cantidadTiros; j++)
                {
                    int dado1 = random.Next(1, 7);
                    int dado2 = random.Next(1, 7);
                    int suma = dado1 + dado2;

                    if (j == 0)
                    {
                        Console.WriteLine("El primer tiro - Suma: " + suma);
                        if (suma == 12 || suma == 6)
                            puntosUsuario += 12;

                        else if (suma == 4 || suma == 6 || suma == 10)
                            puntosCasa += 12;
                        else if (suma == 2 || suma == 3 || suma == 5 || suma == 7 || suma == 8 || suma == 9)
                            puntosUsuario += suma;
                    }
                    else
                    {
                        Console.WriteLine("Tiro " + (j + 1) + " - Suma: " + suma);
                        if (suma == 2 || suma == 3 || suma == 5 || suma == 7 || suma == 8 || suma == 9)
                        {
                            if (puntosUsuario == 0)

                                puntosCasa += 6;
                            else
                                puntosUsuario += suma;
                        }
                    }
                }

                Console.WriteLine("Puntos del jugador: " + puntosUsuario);
                Console.WriteLine("Puntos de la casa: " + puntosCasa);

                if (puntosUsuario > puntosCasa)
                    partidasGanadasUsuario++;
                else
                    partidasGanadasCasa++;
            }

            Console.WriteLine("Partidas ganadas por el usuario: " + partidasGanadasUsuario);
            Console.WriteLine("Partidas ganadas por la casa: " + partidasGanadasCasa);

            Console.ReadLine();
        }
    }

