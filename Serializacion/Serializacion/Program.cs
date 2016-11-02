using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona();

            unaPersona.nombre = "Diego";

            Serializador.SerializarPersona(unaPersona);

            //-------------------------------

            List<Persona> listadoPersona = new List<Persona>();

            listadoPersona.Add(new Persona("Noberto"));
            listadoPersona.Add(new Alumno("Juan", 123));
            listadoPersona.Add(new Alumno("Jorgela",666));

            

            Serializador.SerializarListadoPersona(listadoPersona);

            
            Aula unAula = new Aula(1, "lab",listadoPersona);
            //unAula.ListadoAlumnos = listadoPersona;
            //unAula.numero = 12;
            unAula.profesor = unaPersona;

            

            Serializador.SerializarListadoAula(unAula);

            //Solo serializa propiedades con set y get, no admite solo uno de ellos.


            Persona otraPersona = new Persona("Lucas");
            otraPersona.Serializar();

            //Deserializar la persona
            otraPersona.Desserealizar();
            //Serializador.DeserializarPersona(otraPersona);


            Console.ReadKey();
        }
    }
}
