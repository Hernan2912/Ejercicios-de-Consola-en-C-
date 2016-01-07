using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desviacionymedia
{
    class Program
    {
        static void Main(string[] args)
        {


            if (args.Length == 0)
            {

                Console.WriteLine("No ingreso ningun dato");
                Console.Read();


            }
            else {

                //Calular la media 
                double sumatoria = 0;
                double media;
                for (int i = 0; i < (args.Length); i++)
                    sumatoria += (Convert.ToInt32(args[i]));

                media = (sumatoria / args.Length);

                //Calcular desviacion estandar

                double sum = 0;
                double desviacion;

                for (int i = 0; i < (args.Length); i++)
                    sum += (Math.Pow(((Convert.ToInt32(args[i])) - media), 2));

                desviacion = (Math.Sqrt(sum / (args.Length - 1)));


              
                //Impresion

                Console.Write("\ndesviacionymedia ");
                for (int i = 0; i < (args.Length); i++)
                    Console.Write(args[i] + " ");

                Console.WriteLine("\n\nLa desviación típica es: " + desviacion.ToString("N6"));

                Console.WriteLine("\nLa media aritmética es: " + media);

                Console.Read();
            }
           

        }
        
    }
}
