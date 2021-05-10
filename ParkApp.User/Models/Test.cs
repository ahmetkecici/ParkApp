using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkApp.User.Models
{
    public class Test
    {
        [BsonId]
        public ObjectId _Id { get; set; }
        public string NameSurname { get; set; }
        public int Age { get; set; }
        public ICollection<Adres>   Adress { get; set; }

    }
    public class Adres
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
