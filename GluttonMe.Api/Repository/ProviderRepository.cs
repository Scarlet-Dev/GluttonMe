using GluttonMe.Api.Interfaces;
using GluttonMe.Api.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Repository
{
    public class ProviderRepository : IProviderRepository<Provider>
    {
        private readonly IMongoCollection<Provider> _providers;

        public ProviderRepository(GluttonMeDatabaseInitializer service, 
            GluttonMeDatabaseSettings settings)
        {
            var db = service.GetMongoDatabase();
            var collectionName = settings.CollectionNames.Where(col =>
                col.Contains("Provider")).First();

            _providers = db.GetCollection<Provider>(collectionName);
        }

        public Provider Create(Provider model)
        {
            throw new NotImplementedException();
        }

        public List<Provider> Get()
        {
            //TODO Add Find full list
            List<Provider> providersList = new List<Provider>();

            //Idea to have while loop to wait until all providers are found
            //Then add to providersList
            //And finally return that list
            return providersList;
        }

        public List<Provider> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Provider model)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Provider> searchOrder(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Provider model)
        {
            throw new NotImplementedException();
        }
    }
}
