using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    public class HawaianaBuilder :PizzaBuilder
    {
        public HawaianaBuilder(string tamaño)
        {
            this._pizza = new Pizza
            { Tamaño = tamaño };

        }

        public override void PasoPrepararMasa() 
        {
            this._pizza.Masa = "suave";
        }

        public override void PasoAñadirSalsa()
        {
            this._pizza.Salsa = "Dulce";
        }

        public override void PasoPrepararRelleno()
        {
            this._pizza.Relleno = "piña+tomate+jamon";
        }
    }
}
