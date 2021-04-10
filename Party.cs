using System;
using System.Collections.Generic;

namespace P5_Pokedex
{
    class Party
    {   
        // Método para crear lista Party
        public List<PokemonCapturado> listaParty;

        public Party()
        {
            listaParty = new List<PokemonCapturado>();
        }


        // Método para añadir Pokémon a la lista de Party creada
        public void add(PokemonCapturado registro)
        {
            listaParty.Add(registro);
        }

    }
}