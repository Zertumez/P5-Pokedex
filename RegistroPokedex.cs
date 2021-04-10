using System;

namespace P5_Pokedex
{
    class RegistroPokedex
    {
        public string nombre;
        public Nullable<int> id;

        public RegistroPokedex(string nombre, Nullable<int> id)
        {
            this.nombre = nombre;
            this.id = id;
        }
    }
}