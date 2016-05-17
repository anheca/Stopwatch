using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOneStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            int instancia = 0;
            var cronometro = new Stopwatch();
            GetInstructions();

            var colorFuente = Console.ForegroundColor;

            do
            {

                Console.ForegroundColor = ConsoleColor.Black;
                keyInfo = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (keyInfo.Key == ConsoleKey.Escape) break;

                if (keyInfo.Key == ConsoleKey.S)
                {
                    instancia++;

                    if (instancia > 1)
                        GetInstructions();

                    try
                    {
                        cronometro.Start();
                    }
                    catch (ArgumentException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: {0}", e.Message);
                    }
                }

                if (keyInfo.Key == ConsoleKey.P)
                {
                    try
                    {
                        var duracion = cronometro.Stop();
                        GetDuration(duracion);

                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: {0}", e.Message);
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Enter);


        }

        private static void GetDuration(TimeSpan duracion)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                         " + "Duracion :        Dias........: {0}", duracion.Days);
            Console.WriteLine("                         " + "                  Horas.......: {0}", duracion.Hours);
            Console.WriteLine("                         " + "                  Minutos.....: {0}", duracion.Minutes);
            Console.WriteLine("                         " + "                  Segundos....: {0}", duracion.Seconds);
            Console.WriteLine("                         " + "                  Milisegundos: {0}", duracion.Milliseconds);
        }

        private static void GetInstructions()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                    WELCOME to STOPWATCH System");
            Console.WriteLine();
            Console.WriteLine("                    INSTRUCCIONES:");
            Console.WriteLine("                    [S]   = Iniciar Cronometro");
            Console.WriteLine("                    [P]   = Parar   Cronometro");
            Console.WriteLine("                    [ESC] = SALIR");
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Please Press any key as above:");

        }
    }
}
