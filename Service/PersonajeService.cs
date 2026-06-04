namespace Service;
using Domain;
using Repositroy;
using Service.DTOs;
public class PersonajeService
{
    private readonly PersonajeRepository _personajeRepository;
    private readonly CasaRepository _casaRepository;
    
    public PersonajeService()
    {
        _casaRepository = new CasaRepository();
        _personajeRepository = new PersonajeRepository();
        
    }
    
    public void CrearMago(string nombre, string apellido, DateTime fechaNacimiento, string genero, string tipoSangre, int idCasa)
    {
        ValidarDatosBasicos(nombre, apellido, fechaNacimiento);
        if (string.IsNullOrWhiteSpace(tipoSangre))
        {
            throw new ArgumentException("El tipo de sangre es obligatorio para un mago.");
        }
        if (!_casaRepository.Existe(idCasa))
        {
            throw new InvalidOperationException($"No se puede crear el mago. La casa con ID {idCasa} no existe.");
        }
        Mago nuevoMago = new Mago(nombre, apellido, fechaNacimiento, genero, "Mago", tipoSangre, idCasa);
        _personajeRepository.Agregar(nuevoMago);
    }
    
    
    public void CrearMuggle(string nombre, string apellido, DateTime fechaNacimiento, string genero, string Profesion, bool SabeDeMagia)
    {
        ValidarDatosBasicos(nombre, apellido, fechaNacimiento);
        
        Muggle nuevoMuggle = new Muggle(nombre, apellido, fechaNacimiento, genero, "Muggle", Profesion, SabeDeMagia);
        _personajeRepository.Agregar(nuevoMuggle);
    }
    public void CrearDuende(string nombre, string apellido, DateTime fechaNacimiento, string genero, bool trabaja, bool forja)
    {
        ValidarDatosBasicos(nombre, apellido, fechaNacimiento);
        
        Duende nuevoDuende = new Duende(nombre, apellido, fechaNacimiento, genero, "Duende", trabaja, forja);
        _personajeRepository.Agregar(nuevoDuende);
    }
    
    private void ValidarDatosBasicos(string nombre, string apellido, DateTime fechaNacimiento)
    {
        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
        {
            throw new ArgumentException("El nombre y el apellido no pueden estar vacíos.");
        }

        if (fechaNacimiento > DateTime.Now)
        {
            throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");
        }
        
    }
    public IEnumerable<PersonajeDto> ObtenerTodosLosPersonajes()
    {
        IEnumerable<Personaje> personajesDominio = _personajeRepository.ObtenerTodos();
        var listaDtos = new List<PersonajeDto>();

        foreach (var p in personajesDominio)
        {
            var dto = new PersonajeDto
            {
                Nombre = p.Nombre,
                Apellido = p.Apellido
            };

            // Mapeo síncrono dependiendo del tipo de herencia del Dominio
            if (p is Mago mago)
            {
                dto.Tipo = "Mago";
            }
            else if (p is Muggle muggle)
            {
                dto.Tipo = "Muggle";
            }
            else if (p is Duende duende)
            {
                dto.Tipo = "Duende";
            }

            listaDtos.Add(dto);
        }

        return listaDtos;
    }
}