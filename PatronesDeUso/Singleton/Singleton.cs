using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get { return _instance; }
        } 


        public string PagarCliente(string cliente,string numerotarjeta , int monto)
        {
            string resultado = "\n\rPago Rechazado";
            Random r = new Random();
            int numero =r.Next(10, 100);
            Console.WriteLine("Cobro a cliente " + cliente + " la suma de " + monto +"$ de su tarjeta de credito "+numerotarjeta);

            if (numero > 40)
            {
                resultado = "\n\rPago Aceptado";
            }
            
            return resultado;
        }

    }
}
