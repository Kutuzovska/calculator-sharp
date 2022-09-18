using MongoDB.Driver;

namespace ccalc.Common;

public class Mongo
{
    private IMongoDatabase? _database;

    public IMongoDatabase Db()
    {
        if (_database != null) return _database;

        var client = new MongoClient("mongodb://root:root@localhost:27017");
        _database = client.GetDatabase("ccalc");

        return _database;
    }
}