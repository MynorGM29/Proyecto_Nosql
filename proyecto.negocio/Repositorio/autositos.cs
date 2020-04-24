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
    public class autositos
    {


        private const string _collName = "autos";
        private const string _dbName = "proyecto";

        private IMongoCollection<autos> ObtenerColeccionDeAutos()
        {
            var laConexion = new Conexion();
            var db = laConexion.GetDatabaseReference("localhost", _dbName);
            var collection = db.GetCollection<autos>(_collName);
            return collection;
        }

        public IList<autos> ListarTodos
            (string nombreDelHost, string dbName)
        {

            var elCliente = new Conexion();
            var laBaseDeDatos = elCliente.GetDatabaseReference(nombreDelHost, dbName);
            var laColeccion = laBaseDeDatos.GetCollection<autos>("autos");
            var filter = new BsonDocument();
            var elResultado = laColeccion.Find<autos>(filter).ToList();
            //IList<Animalito> laLista = new List<Animalito>();
            return elResultado;
        }

        public IList<autos> ListarAutosPorNombre(string elNombre)
        {
            var losAutos = ObtenerColeccionDeAutos();
            /* Filter to retrieve movies where the name equals to "elNombre" */
            var expresssionFilter = Builders<autos>.Filter.Eq(x => x.marca, elNombre);
            var result = losAutos.Find(expresssionFilter).ToList();
            return result;
        }
    }
}
