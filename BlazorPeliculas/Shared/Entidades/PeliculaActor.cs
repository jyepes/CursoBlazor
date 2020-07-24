using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPeliculas.Shared.Entidades
{
    public class PeliculaActor
    {
        public int PeliculaId { get; set; }
        public int PersonaId { get; set; }
        public Pelicula Pelicula { get; set; }
        public Persona Persona { get; set; }
        public string Personaje { get; set; }
        public int Orden { get; set; }
    }
}
