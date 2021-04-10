using System;
using System.Collections.Generic;

namespace P5_Pokedex
{
    class Competitivo
    {
        // Método para crear equipo competitivo
        public HashSet<PokemonCapturado> equipoCompetitivo;

        public Competitivo()
        {
            equipoCompetitivo = new HashSet<PokemonCapturado>();
        }

    }
}