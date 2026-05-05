using simulacro_ED_3T;
using System.Runtime.CompilerServices;

List<Libro> libros = new List<Libro>();

libros.Add(new Libro("El Quijote", "Miguel de Cervantes", 1605, true));
libros.Add(new Libro("Cien años de soledad", "Gabriel García Márquez", 1967, true));
libros.Add(new Libro("La sombra del viento", "Carlos Ruiz Zafón", 2001, true));


foreach (Libro libro in libros)
{
    Console.WriteLine(libro.toString());
}

foreach (Libro libro in libros)
{
    if (libro.getAutor().Contains("Orwell"))
    {
        Console.WriteLine(libro.toString());
    }
}

Console.WriteLine(DateTime.Now.ToShortDateString());


 void guardarLibros(List<Libro> lista, string ruta)
{
    StreamWriter writer = new StreamWriter(ruta);
    File.CreateText(ruta);
    foreach (Libro libro in lista)
    {
        writer.WriteLine(libro.toString());
    }
    writer.Close();
}
