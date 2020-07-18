using GluttonMe.Api.Interfaces;
using GluttonMe.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Repository
{
    public class ProviderRepository : IProviderRepository<Provider>
    {
        public ProviderRepository()
        {

        }

        public Task<Provider> create(Provider model)
        {
            throw new NotImplementedException();
        }

        public Task<Provider> delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Provider> get()
        {
            throw new NotImplementedException();
        }

        public Task<Provider> get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Provider> searchOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Provider> update(int id, Provider model)
        {
            throw new NotImplementedException();
        }
    }
}
