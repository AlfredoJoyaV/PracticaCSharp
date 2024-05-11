using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uso de operaciones booleanas AND &&
            //El uso de este seria de la siguiente forma, haremos un programa en donde te pida que respondas una series de preguntas y depende de tu respuestas se ejecutara el programa
            //En este caso sera si puedes conducir un automovil o no
            //Este es solo un pequeño caso que se puede implementar el AND


            byte a;
            string b, c;

            c = "S";


            Console.WriteLine("Tienes licencia de conducir");
            Console.WriteLine("S es SI y N es NO");
            Console.WriteLine("S/N");
            b = Console.ReadLine();
            Console.WriteLine("Coloca la edad que tienes");
            a = Convert.ToByte(Console.ReadLine());
            b=b.ToUpper();

            if (a >= 16 && a < 18 && b == c)
            {
                Console.WriteLine("Si puedes conducir pero con cuidado ¡ERES MENOR DE EDAD!");
            }
            else if (a >= 18 && b ==c)
            {
                Console.WriteLine("Si puedes conducir y eres mayor de edad");
            }
            else
            {
                Console.WriteLine("NO PUEDES CONDUCIR");
            }
        }
    }
}
