using GluttonMe.Api.Interfaces;
using GluttonMe.Api.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api
{
    public class GluttonMeDatabaseInitializer
    {
        private MongoClient _mainClient;
        public static IMongoDatabase _mainDatabase;

        private GluttonMeDatabaseInitializer(IGluttonMeDatabaseSettings settings)
        {
            _mainClient = new MongoClient(settings.ConnectionString);
            _mainDatabase = _mainClient.GetDatabase(settings.DatabaseName);
        }

        private static readonly GluttonMeDatabaseInitializer _instance =
            new GluttonMeDatabaseInitializer(new GluttonMeDatabaseSettings());

        public static GluttonMeDatabaseInitializer Instance => _instance;

        public IMongoDatabase GetMongoDatabase()
        {
            return _mainDatabase;
        }
    }
}
