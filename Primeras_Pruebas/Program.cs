using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_Pruebas
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            while (true)
            {
                Console.Clear();
                //limpiamos la consola cada ves que se ejecuta el while
                Console.WriteLine("******Aplicacion de Prueba****");
                Console.WriteLine("1-Cargar Cliente");
                Console.WriteLine("2-Hacerlo Hablar");
                Console.WriteLine("3-Salir");
                Console.Write("Ingrese una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        cliente1.CapturarDatos();
                        break;
                    case 2:
                        cliente1.Hablar();
                        Console.ReadLine();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Error en la opción");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

            /* Primera prueba
            String nombre;
            String apellido;
            byte edad = 21;
            Console.WriteLine(edad);
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido : ");
            apellido= Console.ReadLine();
            Console.WriteLine("Hola " + nombre +" "+ apellido);
            Console.WriteLine("Hola tu nombre es {0} y tu apellido es {1}", nombre, apellido);
             * /
             /* segunda pruba usando clase */
            /*Saludo misaludo = new Saludo();
            misaludo.CapturarNombre();
            misaludo.CapturarApellido();
            //misaludo.SaludoFormal();
            misaludo.SaludoFormal("amigo");
            /* tercera forma utilizando constructores
             */
            /* Saludo misaludo = new Saludo(" Emilia", "Lugo");
             misaludo.SaludoFormal();*/

            //Cliente micliente1= new Cliente();
            //Cliente micliente2 = new Cliente();
            //Cliente micliente3 = new Cliente();

            //micliente1.CapturarDatos();
            //micliente2.CapturarDatos();
            //micliente3.CapturarDatos();

            //micliente1.ImprimirHorizontal();
            //micliente2.ImprimirHorizontal();
            //micliente3.ImprimirHorizontal();

            //micliente.MostrarNombreCompleto();
            //Console.WriteLine(micliente.MostrarNombreCompleto());
            //micliente1.ImprimirFicha();
            //micliente2.ImprimirFicha();
            //micliente3.ImprimirFicha();

            //micliente1.Hablar();
            //micliente2.Hablar();
            //micliente3.Hablar();
            //Console.ReadKey();

