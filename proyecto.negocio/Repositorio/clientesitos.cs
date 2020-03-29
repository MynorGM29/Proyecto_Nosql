using MongoDB.Bson;
using MongoDB.Driver;
using proyecto.modelo.MisColecciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.negocio.Repositorio
{
   public class clientesitos
    {

        private const string _collName = "clientes";
        private const string _dbName = "proyecto";

        private IMongoCollection<clientes> ObtenerColeccionDeClientes()
        {
            var laConexion = new Conexion();
            var db = laConexion.GetDatabaseReference("localhost", _dbName);
            var collection = db.GetCollection<clientes>(_collName);
            return collection;
        }

        public IList<clientes> ListarTodos
            (string nombreDelHost, string dbName)
        {

            var elCliente = new Conexion();
            var laBaseDeDatos = elCliente.GetDatabaseReference(nombreDelHost, dbName);
            var laColeccion = laBaseDeDatos.GetCollection<clientes>("clientes");
            var filter = new BsonDocument();
            var elResultado = laColeccion.Find<clientes>(filter).ToList();
            //IList<Animalito> laLista = new List<Animalito>();
            return elResultado;
        }

        public IList<clientes> ListarAnimalitosPorNombre(string elNombre)
        {
            var losAnimalitos = ObtenerColeccionDeClientes();
            /* Filter to retrieve movies where the name equals to "elNombre" */
            var expresssionFilter = Builders<clientes>.Filter.Eq(x => x.nombre, elNombre);
            var result = losAnimalitos.Find(expresssionFilter).ToList();
            return result;
        }

        /*public IList<Animalito> ListarAnimalitosPorNombreDelDueno(string elNombreDelDueno)
        {
            var losAnimalitos = ObtenerColeccionDeAnimalitos();
            /* Filter to retrieve movies where the name equals to "elNombre" **
            var expresssionFilter = Builders<Animalito>.Filter.Eq(x => x.dueno.Nombre, elNombreDelDueno);
            var result = losAnimalitos.Find(expresssionFilter).ToList();
            return result;
        }*/

        /*public IList<Animalito> ListarAnimalitosPorTelefonoDelDueno(string elTelefonoDelDueno)
        {
            var losAnimalitos = ObtenerColeccionDeAnimalitos();
            /* Filter to retrieve movies where the name equals to "elNombre" **
            var expresssionFilter = Builders<Animalito>.Filter.In("dueno.telefonos", new[] { (BsonValue)elTelefonoDelDueno });
            //x => x.dueno.NumerosDeTelefono, elTelefonoDelDueno);
            var result = losAnimalitos.Find(expresssionFilter).ToList();
            return result;
        }*/

        /*public Animalito ObtenerAnimalitoPorId(ObjectId idDelAnimalito)
        {
            var losAnimalitos = ObtenerColeccionDeAnimalitos();
            /* Filter to retrieve movies where the name equals to "elNombre" **
            var expresssionFilter = Builders<Animalito>.Filter.Eq(x => x._id, idDelAnimalito);
            var elAnimalito = losAnimalitos.Find(expresssionFilter).ToList().FirstOrDefault();
            return elAnimalito;
        }*/

        /*public Propietario ObtenerPropietarioDeAnimalito(ObjectId idDelAnimalito)
        {
            var elPropietarioDelAnimalito = ObtenerAnimalitoPorId(idDelAnimalito).dueno;
            return elPropietarioDelAnimalito;
        }*/

    }
}
