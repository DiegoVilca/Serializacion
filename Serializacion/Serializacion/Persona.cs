using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    [XmlInclude(typeof(Alumno))] //necesario para serializar el alumno (usado en herencia)
        //Podria usarlo en la clase Aula
    public class Persona : ISerializable2016
    {
        //las reglas para serializar en xml solamente guarda lo publico (clase publica y demas cosas q exponga deben ser publicos)
        //Se guardan son atributos o propiedades, metodos no

        public string nombre;

        public Persona() //necesario para deserializar/serializar
        {

        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }


        public bool Serializar()
        {
            try
            {
                Serializador.SerializarPersona(this);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool Desserealizar()
        {
            try
            {
                Serializador.DeserializarPersona(this); //corregir
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
