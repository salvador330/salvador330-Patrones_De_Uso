using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    public class Persona
    {
        public int _años;
        public DateTime _Cumpleaños;
        public string _nombre;
        public IdInformacion _IdInformacion;

        public Persona CopiaSuperficial()
        {
            return (Persona)this.MemberwiseClone();
        }

        public Persona CopiaProfunda()
        {
            Persona clone = (Persona)this.MemberwiseClone();
            clone._IdInformacion = new IdInformacion(_IdInformacion.IdIdnumero);
            clone._nombre = string.Copy(_nombre);
            return clone;
        }


    }
}
