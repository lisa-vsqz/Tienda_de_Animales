﻿using TiendaAnimalesEtsotikos.Models;

namespace TiendaAnimalesEtsotikos.Util
{
    public class Utils
    {

        public static List<Animal> ListaAnimal = new List<Animal>()
        {
            new Animal()
            {
                Id = 0,
                Nombre = "julian",
                NombreCientifico = "guerrero",
                PaisOrigen = "Quitumbe",
                Altura = 11,
                Peso = 10,
                Status = 0,
                Enfermedad = "tos",
                Propietario = 1729234,

            },
            new Animal()
            {
                Id = 1,
                Nombre = "nico",
                NombreCientifico = "garcia",
                PaisOrigen = "Quito",
                Altura = 22,
                Peso = 20,
                Status = 1,
                Enfermedad = "moquillo",
                Propietario = 1729234,

            },
            new Animal()
            {
                Id = 2,
                Nombre = "salsa",
                NombreCientifico = "choque",
                PaisOrigen = "Guayas",
                Altura = 33,
                Peso = 30,
                Status = 2,
                Enfermedad = "gripe",
                Propietario = 1729234,

            }
        };


            public static List<Cliente> ListaCliente = new List<Cliente>()
        {
            new Cliente()
            {
                Cedula = 1234,
                Nombre = "julian",
                Direccion = "guerrero",
                AnimalComprado = 123,
                Password = "asd"

            },
            new Cliente()
            {
                Cedula = 0987,
                Nombre = "sara",
                Direccion = "guerrero",
                AnimalComprado = 098,
                Password = "asd"

            }
        };

        public static List<Veterinario> ListaVeterinario = new List<Veterinario>()
        {
            new Veterinario()
            {
                NombreVeterinario = "solca",
                DireccionVeterinario = "sangolqui",
                TelefonoVeterinario = 23875

            },
            new Veterinario()
            {
                NombreVeterinario = "perritosINC",
                DireccionVeterinario = "condado",
                TelefonoVeterinario = 098765

            }
        };

    }
}
