using System;
using System.Collections.Generic;
using System.Text;

namespace simulacro_ED_3T
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private int anyo;
        private bool disponible;

        public Libro(string titulo, string autor, int anyo, bool disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anyo = anyo;
            this.disponible = disponible;
        }

        public string Titulo()
        {
            return titulo;
        }

        public string Autor()
        {
            return autor;
        }

        public int Anyo()
        {
            return anyo;
        }

        public bool isDisponible()
        {
            return disponible;
        }

        public string toString()
        {
            return "Titulo: " + titulo + ", Autor" + autor + ", Año: " + anyo;
        }
    }
}
