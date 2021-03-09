using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Se debe crear un programa el cual filtre por medio de la edad y de la
            estatura a las personas que desean entrar a un parque.
            */

            string datos = "";
            int edad = 0;
            Double estatura = 0.00;

            Console.WriteLine("Hola, Bienvenido al Parque de Diversiones");

            Console.WriteLine("Por favor, ingrese su edad");
            
                 datos = Console.ReadLine();
                 edad = Convert.ToInt32(datos);
            
            if (edad < 18)
                Console.WriteLine("Su edad de {0} años, es menor al limite permitido. No puede entrar gracias por su visita", edad);
            else if (edad >= 18)
                Console.WriteLine("Por favor, ingrese su estatura");
  
                  datos = Console.ReadLine();
                  estatura = Convert.ToDouble(datos);
            
            if (estatura < 1.6)
                Console.WriteLine("Tu estatura {0} te permite ingresar a la casa encanta, el gusanito y el carrusel",  estatura);
            else if (estatura >= 1.6)
                Console.Write("Tu estatura {0}, te permite ingresar a la casa encantada, el gusanito, el carrusel y a la montaña rusa", estatura);

                Console.ReadLine();
        }
    }
}
