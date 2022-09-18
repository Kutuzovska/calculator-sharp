using ccalc.Common;
using ccalc.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ccalc.Repositories;

internal class MongoDistancesRepository : IDistancesRepository
{
    private readonly IMongoCollection<BsonDocument> _collection;

    public MongoDistancesRepository(Mongo mongo)
    {
        _collection = mongo.Db().GetCollection<BsonDocument>("distances");
    }

    public List<Distance> All()
    {
        var distances = new List<Distance>();

        var filter = new BsonDocument();
        var documents = _collection.Find(filter).ToList();

        documents.ForEach(document =>
        {
            var distance = new Distance {Start = (int) document["Start"], Price = (double) document["Price"]};
            distances.Add(distance);
        });
        
        return distances;
    }

    public void Add(Distance distance)
    {
        var document = new BsonDocument
        {
            {"Start", distance.Start},
            {"Price", distance.Price}
        };
        _collection.InsertOneAsync(document);
    }
}