using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Reflection;

namespace App
{
    class MongoDistancesRepository : IDistancesRepository
    {
        IMongoCollection<BsonDocument> collection;

        public MongoDistancesRepository()
        {
            collection = Mongo.Db().GetCollection<BsonDocument>("distances");
        }

        public List<Distance> All()
        {
            List<Distance> distances = new List<Distance>();

            var filter = new BsonDocument();
            var documents = collection.Find(filter).ToList();


            foreach (BsonDocument document in documents)
            {
                Distance distance = new Distance { Start = (int)document["Start"], Price = (double)document["Price"] };
                distances.Add(distance);
            }

            return distances;
        }

        public void Add(Distance distance)
        {
            BsonDocument document = new BsonDocument
            {
                {"Start",distance.Start},
                {"Price", distance.Price},
            };
            collection.InsertOneAsync(document);
        }
    }
}