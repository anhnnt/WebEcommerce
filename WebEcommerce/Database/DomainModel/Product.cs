using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Database.DomainModel
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [DisplayFormat(DataFormatString = "{0:#,0}")]
        [Required]
        public double Price { get; set; }

        [DataType(DataType.ImageUrl)]
        [Required]
        public string Picture { get; set; }

        [Required]
        public string OS { get; set; }

        [Required]
        public int ReleasedYear { get; set; }

    }
}
