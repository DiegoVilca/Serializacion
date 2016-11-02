using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    public class Aula
    {
        public int numero;
        private List<Persona> listadoAlumnos;

        public List<Persona> ListadoAlumnos //Serializa aunque la lista sea privada
        {
            get { return listadoAlumnos; }
            
        }

        public Persona profesor;
        private string _nombreAula;

        

        public Aula()
        {

        }

        public Aula(int numero, string nombreAula, List<Persona> lista)
        {
           
            this.numero = numero;
            this.listadoAlumnos = lista;
            this._nombreAula = nombreAula;
        }


        public string NombreAula
        {
            set { _nombreAula = value; }
        }

    }
}
