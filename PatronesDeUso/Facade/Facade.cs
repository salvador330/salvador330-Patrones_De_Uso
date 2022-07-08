using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    public class Facade
    {
        protected Subsitema1 _subsitema1;
        protected Subsitema2 _subsitema2;

        public Facade(Subsitema1 _subsitema1, Subsitema2 _subsitema2)
        {
            this._subsitema1 = _subsitema1;
            this._subsitema2 = _subsitema2;
        }

        public string Operacion()
        {
            string resultado = "Facade inicializado subsistema:\n";
            resultado += this._subsitema1.operacion1();
            resultado += this._subsitema2.operacion1();
            resultado += "Fachada ordena subsistemas para realizar la acción:\n";
            resultado += this._subsitema1.operacion1();
            resultado += this._subsitema2.operacionZ();
            return resultado;
        }

    }
}
