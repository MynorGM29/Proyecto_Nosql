using MongoDB.Driver;
using proyecto.modelo.MisColecciones;
using proyecto.negocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoExample.PruebaConsola
{
    public class Invocador
    {
        private string coleccion;
        private string nombre;
        public void ConsultarAnimalitos()
        {
            CapturarInformacion();

            if (coleccion == "1")
            {
                CapturarId();

                var listaClientes = EjecutarConsultaClientes(nombre);
                ImprimirListaDeClientes(listaClientes);

            }

            else if (coleccion == "2")
            {
                CapturarId();


                var listaAutos = EjecutarConsultaAutos(nombre);
                ImprimirListaDeAutos(listaAutos);

            }

            else if (coleccion == "3")
            {

                var listaAutos = EjecutarConsultaEmpleados(nombre);
                ImprimirListaDeEmpleados(listaAutos);


            }

            else if (coleccion == "4")
            {

                var listaAutos = EjecutarConsultaProveedores(nombre);
                ImprimirListaDeProveedores(listaAutos);


            }


        }

        private void ImprimirListaDeClientes(IList<clientes> listaClientes)
        {
            if (listaClientes.Count > 0)
            {
                foreach (var item in listaClientes)
                {
                    Console.WriteLine("Nombre: {0} - Apellidos: {1} - telefono: {2} - CosasCompradas: {3}", item.nombre, item.apellidos,
                        item.telefono,item.cosasCompradas);
                    /*if (item.dueno != null)
                        Console.WriteLine("Dueños: Nombre: {0} - email: {1}", item.dueno.Nombre, item.dueno.Email);
                    else
                        Console.WriteLine("Dueños: Desconocido");*/
                }
            }
            else
                Console.WriteLine("No se encontraron clientes.");
            ;
            Console.ReadLine();
        }

        private IList<clientes> EjecutarConsultaClientes(string numeroCliente)
        {

            var elConsultante = new clientesitos();
            var elResultado = elConsultante.ListarAnimalitosPorNombre(numeroCliente);
            return elResultado;
        }


        private void ImprimirListaDeAutos(IList<autos> listaAutos)
        {
            if (listaAutos.Count > 0)
            {
                foreach (var item in listaAutos)
                {
                    Console.WriteLine("Marca: {0} - Modelo: {1} - Anho: {2} - Tipo: {3}",
                        item.marca, item.modelo,
                        item.anho, item.motores);
                    /*if (item.dueno != null)
                        Console.WriteLine("Dueños: Nombre: {0} - email: {1}", item.dueno.Nombre, item.dueno.Email);
                    else
                        Console.WriteLine("Dueños: Desconocido");*/
                }
            }
            else
                Console.WriteLine("No se encontraron autos.");
            ;
            Console.ReadLine();
        }

        private IList<autos> EjecutarConsultaAutos(string nombreCliente)
        {

            var elConsultante = new autositos();
            var elResultado = elConsultante.ListarAutosPorNombre(nombreCliente);
            return elResultado;
        }



        private void ImprimirListaDeEmpleados(IList<empleados> listaEmp)
        {
            if (listaEmp.Count > 0)
            {
                foreach (var item in listaEmp)
                {
                    Console.WriteLine("Nombre: {0} - Apellido: {1} - Correo: {2} - Telefono: {3}" +
                        " - Salario: {4} - Comision: {5}",
                        item.nombre, item.apellidos,
                        item.correo, item.telefono,item.salario,item.comision);
                    /*if (item.dueno != null)
                        Console.WriteLine("Dueños: Nombre: {0} - email: {1}", item.dueno.Nombre, item.dueno.Email);
                    else
                        Console.WriteLine("Dueños: Desconocido");*/
                }
            }
            else
                Console.WriteLine("No se encontraron empleados.");
            ;
            Console.ReadLine();
        }

        private IList<empleados> EjecutarConsultaEmpleados(string nombreCliente)
        {

            var elConsultante = new empleaditos();
            var elResultado = elConsultante.ListarEmpleadosPorNombre(nombreCliente);
            return elResultado;
        }



        private void ImprimirListaDeProveedores(IList<proveedores> listaEmp)
        {
            if (listaEmp.Count > 0)
            {
                foreach (var item in listaEmp)
                {
                    Console.WriteLine("Nombre: {0} - Ubicacion: {1} - Encargado: {2} - Marca que provee: {3}" +
                        " - Empleado a cargo: {4}",
                        item.nombre, item.ubicacion,
                        item.DatosEncargado, item.marca_provee, item.encargadoEmpleado);
                    /*if (item.dueno != null)
                        Console.WriteLine("Dueños: Nombre: {0} - email: {1}", item.dueno.Nombre, item.dueno.Email);
                    else
                        Console.WriteLine("Dueños: Desconocido");*/
                }
            }
            else
                Console.WriteLine("No se encontraron empleados.");
            ;
            Console.ReadLine();
        }

        private IList<proveedores> EjecutarConsultaProveedores(string nombreCliente)
        {

            var elConsultante = new proveedorsitos();
            var elResultado = elConsultante.ListarProveedoresPorNombre(nombreCliente);
            return elResultado;
        }




        private void CapturarInformacion()
        {
            Console.Write("1-Clientes, 2-Autos, 3-Empleados, 4-Proveedores\n" +
                "Digite que tabla desea consultar: ");

            coleccion = Console.ReadLine();
            Console.Clear();

        }

        private void CapturarId()
        {
            Console.Write("Digite el nombre: ");

            nombre = Console.ReadLine();
            Console.Clear();

        }

    }
}
