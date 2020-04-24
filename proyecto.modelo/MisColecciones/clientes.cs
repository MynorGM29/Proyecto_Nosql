using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace proyecto.modelo.MisColecciones
{

    [BsonIgnoreExtraElements]
    public class clientes
    {
        [BsonId]
        public int id{ get; set; }

        [BsonElement ("nombre")]
        public string nombre { get; set; }

        [BsonElement("apellidos")]
        public string apellidos { get; set; }

        [BsonElement("correo")]
        public string correo { get; set; }

        [BsonElement("telefono")]
        public string telefono { get; set; }

        [BsonElement("domicilio")]
        public string domicilio { get; set; }

        [BsonElement("compras")]
        public Compras[] cosasCompradas { get; set; }

    }

    public class Compras
    {
        [BsonElement("id_auto")]
        public int idAuto { get; set; }

        [BsonElement("id_vendedor")]
        public int idVendedor { get; set; }

        [BsonElement("precio")]
        public int precio { get; set; }

    }
    /*public class Vacunas
    {
        [BsonElement("fecha")]
        public DateTime Fecha { get; set; }
        [BsonElement("tipo")]
        public string Tipo { get; set; }
        [BsonElement("efectosSecundarios")]
        public string[] EfectosSecundarios { get; set; }
        [BsonExtraElements] public BsonDocument Metadata { get; set; }

    }*/
}
