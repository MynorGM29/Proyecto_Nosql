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
    public class proveedores
    {
        [BsonId]
        public int id { get; set; }

        [BsonElement("nombre")]
        public string nombre { get; set; }

        [BsonElement("ubicacion")]
        public string ubicacion { get; set; }

        [BsonElement("encargado")]
        public Encargado[] DatosEncargado { get; set; }

        [BsonElement("marca_provee")]
        public string marca_provee { get; set; }

        [BsonElement("enc_emp")]
        public int encargadoEmpleado { get; set; }

    }

    public class Encargado
    {
        [BsonElement("nombre")]
        public string nombre { get; set; }

        [BsonElement("identificacion")]
        public string identificacion { get; set; }

        [BsonElement("telefono")]
        public string telefono { get; set; }

        [BsonElement("correo")]
        public string correo { get; set; }
    }
}
