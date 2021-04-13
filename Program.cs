using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Para este ejercicio del tercer corte existe una empresa dedica a la nutrición de los perros tanto adultos como cachorros que necesita transformar su tabla de porciones 
            de alimento a un programa que solo indicado el peso, el nivel de actividad y la edad del canino le muestre cuanta cantidad de alimento (en gramos) debe comer el perro.
            */

            string Datos = "";
            string valor = "";
            int Sistema = 0;
            int opcion = 0;
            int Edad = 0;
            double Peso = 0.0;
            int Actividad = 0;
            int Tamaño = 0;
            int Tiempo = 0;

            Console.WriteLine("Bienvenido al Programa Nutricional de su Canino");
            Console.WriteLine("Si desea Salir ingrese 1, si desea Continuar ingrese 2");
            Datos = Console.ReadLine();
            Sistema = Convert.ToInt32(Datos);
            while (Sistema == 2)
            {
                do
                {
                    Console.WriteLine("Por favor Ingrese la Edad del Canino en meses (solo numero)");
                    Datos = Console.ReadLine();
                    Edad = Convert.ToInt32(Datos);
                    Console.WriteLine("Por favor Ingrese El Tamaño del Canino");
                    Console.WriteLine("1:Miniatura, 2:Pequeño, 3:Mediano, 4:Grande");
                    Datos = Console.ReadLine();
                    Tamaño = Convert.ToInt32(Datos);
                    switch (Tamaño)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el Peso de su Canino (en kg, y solo numero)");
                            Datos = Console.ReadLine();
                            Peso = Convert.ToDouble(Datos);
                            if (Peso == 2)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 5.300g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 7.950g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor= Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 10.600g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 13.250g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 15.900g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            else if (Peso == 5)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 25.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 37.500g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 50.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 62.500g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 75.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el Peso de su Canino (en kg, y solo en numero)");
                            Datos = Console.ReadLine();
                            Peso = Convert.ToDouble(Datos);
                            if (Peso == 5)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 25.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 37.500g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 50.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 62.500g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(opcion);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 75.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            else if (Peso == 10)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 84.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 126.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 168.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 210.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 252.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el Peso de su Canino (en kg, y solo en numero)");
                            Datos = Console.ReadLine();
                            Peso = Convert.ToDouble(Datos);
                            if (Peso == 10)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 84.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 126.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 168.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 210.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 252.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            else if (Peso == 15)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 168.750g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 253.125g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 337.500g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 421.875g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 506.250g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine("Ingrese el Peso de su Canino (en kg, y solo en numero)");
                            Datos = Console.ReadLine();
                            Peso = Convert.ToDouble(Datos);
                            if (Peso == 15)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 168.750g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 253.125g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 337.500g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 421.875g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 506.250g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            else if (Peso == 25)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 415.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 622.500g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 830.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 1.037.500g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 1.245.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            else if (Peso == 40)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 946.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 1.419.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 1.892.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 2.365.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 2.838.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            else if (Peso == 55)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 1.650.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 2.475.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 3.300.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 4.125.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 4.950.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            else if (Peso == 70)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 2.520.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 3.780.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 5.040.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 6.300.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 7.560.000g");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            else if (Peso == 90)
                            {
                                Console.WriteLine("Ingrese la Actividad Física del Canino");
                                Datos = Console.ReadLine();
                                Actividad = Convert.ToInt32(Datos);
                                Console.WriteLine("Ingrese el Tiempo que requiera calcular la Cantidad de Alimento");
                                Datos = Console.ReadLine();
                                Tiempo = Convert.ToInt32(Datos);
                                switch (Tiempo)
                                {
                                    case 2:
                                        Console.WriteLine("La porción del canino deben ser 3.906.000g");
                                        Console.WriteLine("Le recomendamos monitorear el peso de su perro, ya que en su nutricion este peso es considerado sobrepeso");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 3:
                                        Console.WriteLine("La porción del canino deben ser 5.859.000g");
                                        Console.WriteLine("Le recomendamos monitorear el peso de su perro, ya que en su nutricion este peso es considerado sobrepeso");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 4:
                                        Console.WriteLine("La porción del canino deben ser 7.812.000g");
                                        Console.WriteLine("Le recomendamos monitorear el peso de su perro, ya que en su nutricion este peso es considerado sobrepeso");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 5:
                                        Console.WriteLine("La porción del canino deben ser 9.765.000g");
                                        Console.WriteLine("Le recomendamos monitorear el peso de su perro, ya que en su nutricion este peso es considerado sobrepeso");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                    case 6:
                                        Console.WriteLine("La porción del canino deben ser 11.718.000g");
                                        Console.WriteLine("Le recomendamos monitorear el peso de su perro, ya que en su nutricion este peso es considerado sobrepeso");
                                        Console.WriteLine("Si desea volver al principio Ingrese 1, si desea salir Ingrese 2");
                                        valor = Console.ReadLine();
                                        opcion = Convert.ToInt32(valor);
                                        break;
                                }
                            }
                            break;
                    }
                } while (opcion !=2 && opcion==1);
                
            }
          
        Console.WriteLine("Gracias por su visita");  
        }
    }
}
