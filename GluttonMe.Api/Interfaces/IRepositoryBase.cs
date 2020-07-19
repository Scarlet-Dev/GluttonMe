using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Interfaces
{
    public interface IRepositoryBase<F>
    {
        public List<F> Get();

        public List<F> Get(int id);

        public F Create(F model);

        public void Update(int id, F model);

        public void Remove(F model);

        public void Remove(int id);
    }
}
