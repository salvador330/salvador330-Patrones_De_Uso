using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //patron de uso singleton
            string paogo = Singleton.Instance.PagarCliente("cesar", "4563789612367894", 1500);
            Console.WriteLine(paogo);
            Console.WriteLine("\r\n  \r\n  \r\n  //////////////////////////////////////////////\r\n ");

            //patron de uso builder
            Console.WriteLine("cocinando una pizza HawaianaBuilder \r\n");
            Cocina cocina = new Cocina();

            cocina.RecepcionarProximaPizza(new HawaianaBuilder("familiar"));

            cocina.CocinarPizzaPasoAPaso();

            Console.WriteLine(cocina.PizzaPreparada.Tamaño+"\r\n"+cocina.PizzaPreparada.Salsa);


            //otra pizza
            Console.WriteLine("cocinando una pizza CuatroQuesosBuilder \r\n");
            Cocina otrococina = new Cocina();

            otrococina.RecepcionarProximaPizza(new CuatroQuesosBuilder("familiar"));

            otrococina.CocinarPizzaPasoAPaso();

            Console.WriteLine(otrococina.PizzaPreparada.Tamaño + "\r\n" + otrococina.PizzaPreparada.Salsa);


            Console.WriteLine("\r\n Toque para salir");
            Console.ReadLine();
        }
    }
}
