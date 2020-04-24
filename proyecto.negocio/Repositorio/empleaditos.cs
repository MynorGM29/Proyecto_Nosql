using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using proyecto.modelo.MisColecciones;

namespace proyecto.negocio.Repositorio
{
    public class empleaditos
    {

        private const string _collName = "empleados";
        private const string _dbName = "proyecto";

        private IMongoCollection<empleados> ObtenerColeccionDeEmpleados()
        {
            var laConexion = new Conexion();
            var db = laConexion.GetDatabaseReference("localhost", _dbName);
            var collection = db.GetCollection<empleados>(_collName);
            return collection;
        }

        public IList<empleados> ListarTodos
            (string nombreDelHost, string dbName)
        {

            var elCliente = new Conexion();
            var laBaseDeDatos = elCliente.GetDatabaseReference(nombreDelHost, dbName);
            var laColeccion = laBaseDeDatos.GetCollection<empleados>("empleados");
            var filter = new BsonDocument();
            var elResultado = laColeccion.Find<empleados>(filter).ToList();
            //IList<Animalito> laLista = new List<Animalito>();
            return elResultado;
        }

        public IList<empleados> ListarEmpleadosPorNombre(string elNombre)
        {
            var losAutos = ObtenerColeccionDeEmpleados();
            /* Filter to retrieve movies where the name equals to "elNombre" */
            var expresssionFilter = Builders<empleados>.Filter.Eq(x => x.nombre, elNombre);
            var result = losAutos.Find(expresssionFilter).ToList();
            return result;
        }

    }
}
