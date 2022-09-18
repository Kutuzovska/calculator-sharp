using MongoDB.Bson;
using MongoDB.Driver;

namespace App
{
    class MongoDistancesRepository : IDistancesRepository
    {
        IMongoCollection<BsonDocument> collection;

        public MongoDistancesRepository()
        {
            var hasCollection = Mongo.Db().GetCollection<BsonDocument>("distances");
            if (hasCollection == null)
                Mongo.Db().CreateCollection("distances");

            collection = Mongo.Db().GetCollection<BsonDocument>("distances");
        }

        public List<Distance> All()
        {
            List<Distance> distances = new List<Distance>();

            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument document in documents)
            {
                distances.Add(new Distance(((int)document["Start"]), (double)document["Price"]));
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