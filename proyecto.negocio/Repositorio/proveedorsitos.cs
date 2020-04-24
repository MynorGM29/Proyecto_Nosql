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
    public class proveedorsitos
    {

        private const string _collName = "proveedores";
        private const string _dbName = "proyecto";

        private IMongoCollection<proveedores> ObtenerColeccionDeProveedores()
        {
            var laConexion = new Conexion();
            var db = laConexion.GetDatabaseReference("localhost", _dbName);
            var collection = db.GetCollection<proveedores>(_collName);
            return collection;
        }

        public IList<proveedores> ListarTodos
            (string nombreDelHost, string dbName)
        {

            var elCliente = new Conexion();
            var laBaseDeDatos = elCliente.GetDatabaseReference(nombreDelHost, dbName);
            var laColeccion = laBaseDeDatos.GetCollection<proveedores>("proveedores");
            var filter = new BsonDocument();
            var elResultado = laColeccion.Find<proveedores>(filter).ToList();
            //IList<Animalito> laLista = new List<Animalito>();
            return elResultado;
        }

        public IList<proveedores> ListarProveedoresPorNombre(string elNombre)
        {
            var losProveedores = ObtenerColeccionDeProveedores();
            /* Filter to retrieve movies where the name equals to "elNombre" */
            var expresssionFilter = Builders<proveedores>.Filter.Eq(x => x.nombre, elNombre);
            var result = losProveedores.Find(expresssionFilter).ToList();
            return result;
        }

    }
}
