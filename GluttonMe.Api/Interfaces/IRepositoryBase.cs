using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Interfaces
{
    public interface IRepositoryBase<F>
    {
        public Task<F> get();

        public Task<F> get(int id);

        public Task<F> create(F model);

        public Task<F> update(int id, F model);

        public Task<F> delete(int id);
    }
}
