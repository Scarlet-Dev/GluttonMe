using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Interfaces
{
    public interface IGluttonMeDatabaseSettings
    {
        string DatabaseName { get; }
        string[] CollectionNames { get; }
        string ConnectionString { get; }
    }
}
