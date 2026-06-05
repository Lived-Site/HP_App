namespace Service;

using Domain;
using Repositroy; // Ojo aquí: verifica si no quisiste escribir 'Repository' en tu archivo original
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
    
    public void CrearMago(string nombre, string apellido, DateTime fechaNacimiento, string genero, string foto, string tipoSangre, int idCasa)
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
        Mago nuevoMago = new Mago(nombre, apellido, fechaNacimiento, genero, "Mago", foto, tipoSangre, idCasa);
        _personajeRepository.Agregar(nuevoMago);
    }
    
    public void CrearMuggle(string nombre, string apellido, DateTime fechaNacimiento, string genero, string foto, string Profesion, bool SabeDeMagia)
    {
        ValidarDatosBasicos(nombre, apellido, fechaNacimiento);
        
        Muggle nuevoMuggle = new Muggle(nombre, apellido, fechaNacimiento, genero, "Muggle", foto, Profesion, SabeDeMagia);
        _personajeRepository.Agregar(nuevoMuggle);
    }

    public void CrearDuende(string nombre, string apellido, DateTime fechaNacimiento, string genero, string foto, bool trabaja, bool forja)
    {
        ValidarDatosBasicos(nombre, apellido, fechaNacimiento);
        
        Duende nuevoDuende = new Duende(nombre, apellido, fechaNacimiento, genero, "Duende", foto, trabaja, forja);
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
            string urlProcesada = (p.Foto != null && p.Foto.StartsWith("data:image")) 
                ? p.Foto 
                : $"images/{p.Foto ?? "silueta.png"}";

            var dto = new PersonajeDto
            {
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                FotoUrl = urlProcesada
            };

            if (p is Mago magoEncontrado)
            {
                dto.Tipo = "Mago";
                dto.IdCasa = magoEncontrado.IdCasa;
            }
            else if (p is Muggle)
            {
                dto.Tipo = "Muggle";
            }
            else if (p is Duende)
            {
                dto.Tipo = "Duende";
            }

            listaDtos.Add(dto);
        }

        return listaDtos;
    }
}