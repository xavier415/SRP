
namespace SRP
{
    
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Direccion: {Direccion}");
            Console.WriteLine($"Correo: {CorreoElectronico}");
        }
    }

    
    public class ServicioCorreo
    {
        public void EnviarCorreoElectronico(string correoElectronico, string mensaje)
        {
            // Lógica para enviar correo electrónico
            Console.WriteLine($"Enviando correo a {correoElectronico} con el mensaje: {mensaje}");
        }
    }

}
