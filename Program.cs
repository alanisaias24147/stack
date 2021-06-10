using System;
using stackNotas;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            stackNotas stackNotas = new stackNotas;
            stackNotas.push();
            stackNotas.push();
            stackNotas.push();

            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";
                //pedir opcion al usuario
                while (opcion != "1" && opcion != "2" && opcion != "9")
                {
                    Console.WriteLine("ingresa tu nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("1) decir \"Hola Mundo!\"");
                    Console.WriteLine("2) decir \"Hola [nombre]!\"");
                    Console.WriteLine("9) salir");

                    opcion = Console.ReadLine();

                    if (opcion != "1" && opcion != "2" && opcion != "9")
                    {
                        Console.WriteLine("La opcion seleccionada no es correcta");
                    }
                }

                if (opcion == "1")
                {
                    Console.WriteLine("Hola Mundo!");
                }
                else if (opcion == "2")
                {
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Hola " + nombre);
                }
            }
        }
    }
}
