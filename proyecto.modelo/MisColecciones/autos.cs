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
    public class autos
    {

        [BsonId]
        public ObjectId id { get; set; }

        [BsonElement("marca")]
        public string marca { get; set; }

        [BsonElement("modelo")]
        public string modelo { get; set; }

        [BsonElement("anho")]
        public int anho { get; set; }

        [BsonElement("tipos")]
        public Tipos[] motores { get; set; }

    }

    public class Tipos
    {

        [BsonElement("motor")]
        public string motor { get; set; }

        [BsonElement("cv")]
        public string cv { get; set; }

        [BsonElement("caja")]
        public int caja { get; set; }

        [BsonElement("combustible")]
        public string combustible { get; set; }

        [BsonElement("estilo")]
        public int estilo { get; set; }

        [BsonElement("colores")]
        public string[] colores { get; set; }

        [BsonElement("cantidad")]
        public int cantidad { get; set; }

        [BsonElement("precio")]
        public int precio { get; set; }

    }

}
