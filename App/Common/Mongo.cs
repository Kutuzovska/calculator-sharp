using MongoDB.Driver;

namespace App
{
    public class Mongo
    {
        private static IMongoDatabase? database;

        public static IMongoDatabase Db()
        {
            if (database == null)
            {
                MongoClient client = new MongoClient("mongodb://root:root@localhost:27017");
                database = client.GetDatabase("ccalc");
            }

            return database;
        }
    }
}