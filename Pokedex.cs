
using System;
using System.Collections.Generic;

namespace P5_Pokedex
{
    class Pokedex
    {
        // Método para crear lista de Pokédex
        public List<RegistroPokedex> listaDePokemon;

        public Pokedex()
        {
            listaDePokemon = new List<RegistroPokedex>();
        }

        // Método para añadir Pokémon a la lista de Pokédex creada
        public void add(RegistroPokedex registro)
        {
            listaDePokemon.Add(registro);
        }

        // Método para consultar todos los Pokémon en la Pokédex
        public void consultarTodos()
        {
            for (int i = 0; i < this.listaDePokemon.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Los 10 Pokémon que componen la Pokédex son los siguientes:");
                    Console.WriteLine("");
                }
                Console.WriteLine("Pokémon #" + (i+1));
                Console.WriteLine("Nombre: " + this.listaDePokemon[i].nombre);
                Console.Write("");
                Console.WriteLine("Id: " + this.listaDePokemon[i].id);
                Console.WriteLine("");
            }
        }

        // Método para consultar el Id del Pokémon cuyo nombre fue ingresado
        public string nombreAConsultar;
        public void consultarIdPorNombre(string nombreConsultar)
        {
            this.nombreAConsultar = nombreConsultar;
            var item1 = this.listaDePokemon.Find(x => x.nombre == nombreConsultar);
            Console.WriteLine("El Id del Pokémon cuyo nombre fue ingresado es: " + item1.id);
            Console.WriteLine("");
        }

        // Método para consultar el nombre del Pokémon cuya Id fue ingresada
        RegistroPokedex MissingNo = new RegistroPokedex("Missing No.", null);
        public Nullable<int> idAConsultar;
        public void consultarNombrePorId(int idConsultar)
        {
            this.idAConsultar = idConsultar;
            if (this.listaDePokemon.Exists(x => x.id == this.idAConsultar))
            {
                this.idAConsultar = idConsultar;
                var item1 = this.listaDePokemon.Find(x => x.id == this.idAConsultar);
                Console.WriteLine("El nombre del Pokémon cuyo Id fue ingresado es: " + item1.nombre);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(MissingNo.nombre);
                Console.WriteLine(MissingNo.id);
                Console.Write("");
            }
        }
    }
}