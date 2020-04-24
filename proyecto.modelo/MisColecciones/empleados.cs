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
        public class empleados
        {
            [BsonId]
            public int id { get; set; }

            [BsonElement("nombre")]
            public string nombre { get; set; }

            [BsonElement("apellidos")]
            public string apellidos { get; set; }

            [BsonElement("correo")]
            public string correo { get; set; }

            [BsonElement("telefono")]
            public string telefono { get; set; }

            [BsonElement("salario")]
            public string salario { get; set; }

            [BsonElement("comision")]
            public string comision { get; set; }

        }

    
}
