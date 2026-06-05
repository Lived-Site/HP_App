namespace Repositroy;
using Domain;

public class PersonajeRepository : RepositoryBase<Personaje>
{
    
    public PersonajeRepository()
    {
        if (!ObtenerTodos().Any())
        {
            CargarPersonajesPorDefecto();
        }
    }
    

    private void CargarPersonajesPorDefecto()
    {
        Mago harry = new Mago("Harry", "Potter", new DateTime(1980, 7, 31), "Hombre", "Mago","harry.png", "Mestiza", 1);
        Mago hermione = new Mago("Hermione", "Granger", new DateTime(1979, 9, 19), "Mujer", "Mago", "hermione.png","Nacida de Muggles", 1);
        Mago ron = new Mago("Ron", "Weasley", new DateTime(1980, 3, 1), "Hombre", "Mago", "ron.png", "Pura", 1);
        Mago tom = new Mago("Tom", "Riddle", new DateTime(1926, 12, 31), "Hombre", "Mago", "tom.jpg", "Mestiza", 2);

       
        
        // Gryffindor (ID: 1)
        Mago dumbledore = new Mago("Albus", "Dumbledore", new DateTime(1881, 8, 1), "Hombre", "Mago", "dumbeldore.png", "Mestiza", 1);
        Mago neville = new Mago("Neville", "Longbottom", new DateTime(1980, 7, 30), "Hombre", "Mago", "neville.png", "Pura", 1);
        Mago mcgonagall = new Mago("Minerva", "McGonagall", new DateTime(1935, 1, 4), "Mujer", "Mago", "McGonagall.jpg", "Mestiza", 1);
        Mago sirius = new Mago("Sirius", "Black", new DateTime(1959, 11, 3), "Hombre", "Mago", "sirius.png", "Pura", 1);
        Mago lupin = new Mago("Remus", "Lupin", new DateTime(1960, 3, 10), "Hombre", "Mago", "lupin.jfif", "Mestiza", 1);
        Mago ginny = new Mago("Ginny", "Weasley", new DateTime(1981, 8, 11), "Mujer", "Mago", "ginny.jpeg", "Pura", 1);
        Mago fred = new Mago("Fred", "Weasley", new DateTime(1978, 4, 1), "Hombre", "Mago", "fred.png", "Pura", 1);
        Mago george = new Mago("George", "Weasley", new DateTime(1978, 4, 1), "Hombre", "Mago", "george.jpg", "Pura", 1);
        Mago mollyWeasley = new Mago("Molly", "Weasley", new DateTime(1949, 10, 30), "Mujer", "Mago", "molly.png", "Pura", 1);
        Mago arthurWeasley = new Mago("Arthur", "Weasley", new DateTime(1950, 2, 6), "Hombre", "Mago", "arthur.jpg", "Pura", 1);
        Mago seamus = new Mago("Seamus", "Finnigan", new DateTime(1980, 9, 1), "Hombre", "Mago", "fin.webp", "Mestiza", 1);
        Mago dean = new Mago("Dean", "Thomas", new DateTime(1980, 9, 7), "Hombre", "Mago", "dean.jfif", "Mestiza", 1);
        
        // Slytherin (ID: 2)
        Mago snape = new Mago("Severus", "Snape", new DateTime(1960, 1, 9), "Hombre", "Mago", "silueta.png", "Mestiza", 2); 
        Mago draco = new Mago("Draco", "Malfoy", new DateTime(1980, 6, 5), "Hombre", "Mago", "silueta.png", "Pura", 2);
        Mago bellatrix = new Mago("Bellatrix", "Lestrange", new DateTime(1951, 12, 30), "Mujer", "Mago", "silueta.png", "Pura", 2);
        Mago lucius = new Mago("Lucius", "Malfoy", new DateTime(1954, 9, 22), "Hombre", "Mago", "silueta.png", "Pura", 2);
        Mago narcissa = new Mago("Narcissa", "Malfoy", new DateTime(1955, 9, 1), "Mujer", "Mago", "silueta.png", "Pura", 2);
        Mago regulus = new Mago("Regulus", "Black", new DateTime(1961, 9, 1), "Hombre", "Mago", "silueta.png", "Pura", 2);
        Mago pansy = new Mago("Pansy", "Parkinson", new DateTime(1979, 9, 1), "Mujer", "Mago", "silueta.png", "Pura", 2);
        
        // Hufflepuff (ID: 3)
        Mago cedric = new Mago("Cedric", "Diggory", new DateTime(1977, 9, 1), "Hombre", "Mago", "silueta.png", "Pura", 3);
        Mago tonks = new Mago("Nymphadora", "Tonks", new DateTime(1973, 9, 1), "Mujer", "Mago", "silueta.png", "Mestiza", 3);
        Mago newt = new Mago("Newt", "Scamander", new DateTime(1897, 2, 24), "Hombre", "Mago", "silueta.png", "Pura", 3);
        
        // Ravenclaw (ID: 4)
        Mago luna = new Mago("Luna", "Lovegood", new DateTime(1981, 2, 13), "Mujer", "Mago", "silueta.png", "Pura", 4);
        Mago cho = new Mago("Cho", "Chang", new DateTime(1979, 9, 1), "Mujer", "Mago", "Pura", "silueta.png", 4); 
        Mago Lockhart = new Mago("Gilderoy", "Lockhart", new DateTime(1964, 1, 26), "Hombre", "Mago", "silueta.png", "Mestiza", 4);
        Mago ollivander = new Mago("Garrick", "Ollivander", new DateTime(1919, 9, 25), "Hombre", "Mago", "silueta.png", "Mestiza", 4);
        
        Agregar(harry);
        Agregar(hermione);
        Agregar(ron);
        Agregar(tom);
        Agregar(snape);
        Agregar(dumbledore);
        Agregar(draco);
        Agregar(neville);
        Agregar(luna);
        Agregar(mcgonagall);
        Agregar(sirius);
        Agregar(lupin);
        Agregar(ginny);
        Agregar(fred);
        Agregar(george);
        Agregar(cedric);
        Agregar(cho);
        Agregar(bellatrix);
        Agregar(mollyWeasley);
        Agregar(arthurWeasley);
        Agregar(seamus);
        Agregar(dean);
        Agregar(lucius);
        Agregar(narcissa);
        Agregar(regulus);
        Agregar(pansy);
        Agregar(tonks);
        Agregar(newt);
        Agregar(Lockhart);
        Agregar(ollivander);
    }
    public override Personaje? ObtenerPorId(int id)
    {
        return _elementos.FirstOrDefault(p => p.IdPersonaje == id);
    }

    public override bool Existe(int id)
    {
        return _elementos.Any(p => p.IdPersonaje == id);
    }

    public void Editar(int idAEditar, string NuevoNombre,string NuevoApellido, string NuevoGenero, string nuevaRaza)
    {
        var personajeActual = ObtenerPorId(idAEditar);
        
        if (personajeActual != null)
        {
            personajeActual.CambiarNombre(NuevoNombre);
            personajeActual.CambiarApellido(NuevoApellido);
            personajeActual.ModificarGenero(NuevoGenero);
            personajeActual.ModificarRaza(nuevaRaza);
        }
    }
}