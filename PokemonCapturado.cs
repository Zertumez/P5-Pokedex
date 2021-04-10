using System;

namespace P5_Pokedex
{
    public enum Genero
    {
        MASCULINO,
        FEMENINO,
        NEUTRO
    }
    class PokemonCapturado : RegistroPokedex
    {
        public Genero genero;

        public PokemonCapturado(string nombre, Nullable<int> id, Genero genero) : base(nombre, id)
        {
            this.nombre = nombre;
            this.id = id;
            this.genero = genero;
        }
    }
}