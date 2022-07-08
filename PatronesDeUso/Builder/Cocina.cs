using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    public class Cocina
    {
        private PizzaBuilder _pizzaBuilder;

        public void RecepcionarProximaPizza(PizzaBuilder pizzabuilder)
        {
           this._pizzaBuilder = pizzabuilder;
        }

        public void CocinarPizzaPasoAPaso()
        {
            this._pizzaBuilder.PasoPrepararMasa();
            this._pizzaBuilder.PasoAñadirSalsa();
            this._pizzaBuilder.PasoPrepararRelleno();
        }

        public Pizza PizzaPreparada
        {
            get { return this._pizzaBuilder.ObtenerPizza(); }
        }
    }
}
