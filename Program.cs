using System;
using System.Collections.Generic;

namespace P5_Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nombre del juego
            Console.WriteLine(@"                                  ,'\");
            Console.WriteLine(@"    _.----.        ____         ,'  _\   ___    ___     ____");
            Console.WriteLine(@"_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.");
            Console.WriteLine(@"\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |");
            Console.WriteLine(@" \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |");
            Console.WriteLine(@"   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |");
            Console.WriteLine(@"    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |");
            Console.WriteLine(@"     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |");
            Console.WriteLine(@"      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |");
            Console.WriteLine(@"       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |");
            Console.WriteLine(@"        \_.-'       |__|    `-._ |              '-.|     '-.| |   |");
            Console.WriteLine(@"                                `'                            '-._|");
            Console.WriteLine("                        SHORT BUDGET EDITION");
            Console.WriteLine("");
            Console.WriteLine("");

            // Crear una lista Pokédex
            Pokedex listaPokedex = new Pokedex();

            // Crear y añadir el Pokemon a la lista con el método creado.
            RegistroPokedex metapod = new RegistroPokedex("Metapod", 11);
            RegistroPokedex pikachu = new RegistroPokedex("Pikachu", 25);
            RegistroPokedex mrMime = new RegistroPokedex("Mr. Mime", 122);
            RegistroPokedex magikarp = new RegistroPokedex("Magikarp", 129);
            RegistroPokedex cyndaquil = new RegistroPokedex("Cyndaquil", 155);
            RegistroPokedex blaziken = new RegistroPokedex("Blaziken", 257);
            RegistroPokedex piplup = new RegistroPokedex("Piplup", 393);
            RegistroPokedex pachirisu = new RegistroPokedex("Pachirisu", 417);
            RegistroPokedex arceus = new RegistroPokedex("Arceus", 493);
            RegistroPokedex wooloo = new RegistroPokedex("Wooloo", 831);

            listaPokedex.listaDePokemon.Add(metapod);
            listaPokedex.listaDePokemon.Add(pikachu);
            listaPokedex.listaDePokemon.Add(mrMime);
            listaPokedex.listaDePokemon.Add(magikarp);
            listaPokedex.listaDePokemon.Add(cyndaquil);
            listaPokedex.listaDePokemon.Add(blaziken);
            listaPokedex.listaDePokemon.Add(piplup);
            listaPokedex.listaDePokemon.Add(pachirisu);
            listaPokedex.listaDePokemon.Add(arceus);
            listaPokedex.listaDePokemon.Add(wooloo);

            // Métodos para consultar Pokémon
            listaPokedex.consultarTodos();
            listaPokedex.consultarIdPorNombre("Piplup");
            listaPokedex.consultarNombrePorId(25);

            // Hacer una lista Party
            Party listaPartyPokemon = new Party();

            // Crear Pokémon con géneros y añadirlos a la lista/Party con el método creado
            PokemonCapturado metapodCap = new PokemonCapturado(metapod.nombre, metapod.id, Genero.FEMENINO);
            PokemonCapturado pikachuCap = new PokemonCapturado(pikachu.nombre, pikachu.id, Genero.MASCULINO);
            PokemonCapturado mrMimeCap = new PokemonCapturado(mrMime.nombre, mrMime.id, Genero.FEMENINO);
            PokemonCapturado magikarpCap = new PokemonCapturado(magikarp.nombre, magikarp.id, Genero.FEMENINO);
            PokemonCapturado cyndaquilCap = new PokemonCapturado(cyndaquil.nombre, cyndaquil.id, Genero.MASCULINO);
            PokemonCapturado blazikenCap = new PokemonCapturado(blaziken.nombre, blaziken.id, Genero.MASCULINO);
            PokemonCapturado piplupCap = new PokemonCapturado(piplup.nombre, piplup.id, Genero.FEMENINO);
            PokemonCapturado pachirisuCap = new PokemonCapturado(pachirisu.nombre, pachirisu.id, Genero.FEMENINO);
            PokemonCapturado arceusCap = new PokemonCapturado(arceus.nombre, arceus.id, Genero.NEUTRO);
            PokemonCapturado woolooCap = new PokemonCapturado(wooloo.nombre, wooloo.id, Genero.MASCULINO);

            listaPartyPokemon.listaParty.Add(mrMimeCap);
            listaPartyPokemon.listaParty.Add(mrMimeCap);
            listaPartyPokemon.listaParty.Add(magikarpCap);
            listaPartyPokemon.listaParty.Add(cyndaquilCap);
            listaPartyPokemon.listaParty.Add(arceusCap);
            listaPartyPokemon.listaParty.Add(woolooCap);

            // Hacer un HashSet Competitivo y añadir 3 Pokémon a el
            Competitivo equipoCompetitivoDeTres = new Competitivo();

            equipoCompetitivoDeTres.equipoCompetitivo.Add(metapodCap);
            equipoCompetitivoDeTres.equipoCompetitivo.Add(pikachuCap);
            equipoCompetitivoDeTres.equipoCompetitivo.Add(woolooCap);
        }
    }
}
