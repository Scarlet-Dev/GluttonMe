using GluttonMe.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Interfaces
{
    public interface IProviderRepository<P> : IRepositoryBase<P>
    {
        public IList<P> searchOrder(int id);
    }
}
