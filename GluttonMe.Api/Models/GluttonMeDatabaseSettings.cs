using GluttonMe.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Models
{
    public class GluttonMeDatabaseSettings : IGluttonMeDatabaseSettings
    {
        public string DatabaseName { get; }
        public string ConnectionString { get;}
        public string[] CollectionNames { get; }

        public GluttonMeDatabaseSettings()
        {
        }

        public GluttonMeDatabaseSettings(string databaseName, string connectionName, string[] collectionNames)
        {
            DatabaseName = databaseName;
            ConnectionString = connectionName;
            CollectionNames = collectionNames;
        }

        
    }
}
