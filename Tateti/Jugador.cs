
using System;
using System.Collections;

namespace tateti
{
    public class Jugador
    {
        //declaracion de la propiedad que almacena el tipo de ficha del jugador
        public string tipo_ficha;
        public Hashtable fichas;

        public Jugador(string tipoficha)
        {
            tipo_ficha = tipoficha;
            fichas = new Hashtable();
            fichas.Add(1, 0);
            fichas.Add(2, 0);
            fichas.Add(3, 0);
        }
    }
}