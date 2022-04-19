using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    public class PizzaBuilder
    {
        protected Pizza _pizza;
        public string Tamaño { get; set; }

        public Pizza ObtenerPizza() { return _pizza; }

        public virtual void PasoPrepararMasa() { }

        public virtual void PasoAñadirSalsa() { }

        public virtual void PasoPrepararRelleno() { }

        public virtual void PasoDoblarPoizza() { }


    }
}
