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

            Console.WriteLine(cocina.PizzaPreparada.Tamaño + "\r\n" + cocina.PizzaPreparada.Salsa);


            //otra pizza
            Console.WriteLine("cocinando una pizza CuatroQuesosBuilder \r\n");
            Cocina otrococina = new Cocina();

            otrococina.RecepcionarProximaPizza(new CuatroQuesosBuilder("familiar"));

            otrococina.CocinarPizzaPasoAPaso();

            Console.WriteLine(otrococina.PizzaPreparada.Tamaño + "\r\n" + otrococina.PizzaPreparada.Salsa);

            Console.WriteLine("\r\n  \r\n  \r\n  //////////////////////////////////////////////\r\n ");

            //Patron de uso facade

            Subsitema1 subsitema1 = new Subsitema1();
            Subsitema2 subsitema2 = new Subsitema2();

            Facade facade = new Facade(subsitema1, subsitema2);

            Cliente.ClientCode(facade);

            Console.WriteLine("\r\n  \r\n  \r\n  //////////////////////////////////////////////\r\n ");

            //Patron de uso Prototype 

            Persona p1 = new Persona();
            p1._años = 42;
            p1._Cumpleaños = Convert.ToDateTime("1999-05-05");
            p1._nombre = "Roberto";
            p1._IdInformacion = new IdInformacion(666);

            // Realizar una copia superficial de p1 y asignarla a p2.
            Persona p2 = p1.CopiaSuperficial();
            // Haz una copia profunda de p1 y asígnala a p3.
            Persona p3 = p1.CopiaProfunda();

            // Mostrar valores de p1, p2 y p3.
            Console.WriteLine("Valores originales de p1, p2, p3: ");
            Console.WriteLine("         valores de instancia p1: ");
            DisplayValues(p1);
            Console.WriteLine("         valores de instancia p2: ");
            DisplayValues(p2);
            Console.WriteLine("         valores de instancia p3: ");
            DisplayValues(p3);

            // Cambiar el valor de las propiedades de p1 y mostrar los valores de p1,
            // p2 y p3.

            p1._años = 32;
            p1._Cumpleaños = Convert.ToDateTime("1900-01-01");
            p1._nombre = "Frank";
            p1._IdInformacion.IdIdnumero = 7878;

            Console.WriteLine("\nValores de p1, p2 y p3 después de cambios a p1:");
            Console.WriteLine("   valores de instancia p1: ");
            DisplayValues(p1);
            Console.WriteLine("   valores de instancia p2 (los valores de referencia han cambiado):");
            DisplayValues(p2);
            Console.WriteLine("   valores de instancia p3 (todo se mantuvo igual):");
            DisplayValues(p3);


            Console.WriteLine("\r\n Toque para salir");
            Console.ReadLine();
        }

        public static void DisplayValues(Persona p)
        {
            Console.WriteLine("Nombre: {0:s}, Edad: {1:d}, Fecha de nacimiento: {2:MM/dd/yy}",
                p._nombre, p._años, p._Cumpleaños);
            Console.WriteLine("      ID#: {0:d}", p._IdInformacion.IdIdnumero);
        }
    }
}
