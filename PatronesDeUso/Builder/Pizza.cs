using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    //patron de uso builder
    public class Pizza
    {
        private readonly string _masa;
        private readonly string _salsa;
        private readonly string _relleno;
        private readonly string _tamaño;

        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Relleno { get; set; }
        public string Tamaño { get; set; }

        public Pizza(string tamaño, string relleno, string salsa,string masa)
        {
            this.Tamaño = tamaño;
            this.Relleno = relleno;
            this.Salsa = salsa;
            this.Masa = masa;
        }

        public Pizza()
        {

        }
    }
}
