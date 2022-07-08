using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeUso
{
    public  class Cliente
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operacion());
        }
    }
}
