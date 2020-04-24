using MongoExample.PruebaConsola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.consultas
{
    class Program
    {
        static void Main(string[] args)
        {

            DoJob();

        }

        private static void DoJob()
        {
            var elInvocador = new Invocador();
            elInvocador.ConsultarAnimalitos();
        }

        /*private static void DoJobDuenoAnimalito()
        {
            var elInvocador = new InvocadorDueno();
            elInvocador.ConsultarAnimalitos();
        }
        private static void DoJobTelefonoAnimalito()
        {
            var elInvocador = new InvocadorDuenoTelefonos();
            elInvocador.ConsultarAnimalitos();
        }
        */
    }
}
