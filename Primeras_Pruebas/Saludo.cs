using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_pruebas
{
    public class Saludo
    {
        private string nombre;
        private string apellido;

        public Saludo()
        {
            nombre = "";
            apellido = "";
        }
        public Saludo(string nom, string ape)
        {
            nombre = nom;
            apellido = ape;
        }

        public void CapturarNombre()
        {
            Console.WriteLine("Ingresa tu nombre:");
            nombre = Console.ReadLine();
        }
        public void CapturarApellido()
        {
            Console.WriteLine("Ingresa tu apellido:");
            apellido = Console.ReadLine();
        }
        /// <summary>
        /// metodo que saluda en forma básica
        /// </summary>
        public void Saludar()
        {
            Console.WriteLine("Hola {0} {1}", nombre, apellido);

        }
        /// <summary>
        /// metodo que saluda en forma gentil
        /// </summary>
        public void SaludoFormal()
        {
            Console.WriteLine("Hola Sr/ra: {0} {1}", nombre, apellido);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="leyenda">es el texto que aparece luego de la palabra hola</param>
        public void SaludoFormal(String leyenda)
        {
            Console.WriteLine("Hola {0}: {1} {2}", leyenda, nombre, apellido);
        }
    }
}
