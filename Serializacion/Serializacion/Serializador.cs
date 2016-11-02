using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    static class Serializador
    {
        public static void SerializarPersona(Persona unaPersona)
        { 
            //XmlTextWriter escritor //escribe el xml

            //XmlSerializer serializador

            

            try
            {

                using (XmlTextWriter escritor = new XmlTextWriter("persona.xml", Encoding.UTF8))
                {

                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));

                    serializador.Serialize(escritor, unaPersona);
                }

            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public static Persona DeserializarPersona(Persona persona)
        {
            try
            {
                Persona unaPersona = null;

                using (XmlTextReader lector = new XmlTextReader("persona.xml"))
                {

                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));

                    unaPersona = (Persona)serializador.Deserialize(lector);

                    return unaPersona;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SerializarListadoPersona(List<Persona> listadoPersona)
        {
            //XmlTextWriter escritor //escribe el xml

            //XmlSerializer serializador



            try
            {

                using (XmlTextWriter escritor = new XmlTextWriter("ListadoPersonas.xml", Encoding.UTF8))
                {

                    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));

                    serializador.Serialize(escritor, listadoPersona);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }



        public static void SerializarListadoAula(Aula aula)
        {
            //XmlTextWriter escritor //escribe el xml

            //XmlSerializer serializador



            try
            {

                using (XmlTextWriter escritor = new XmlTextWriter("Aula.xml", Encoding.UTF8))
                {

                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));

                    serializador.Serialize(escritor, aula);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool SerializarGenerico(ISerializable2016 iserializable)
        {
            return iserializable.Serializar();
        }




    }
}
