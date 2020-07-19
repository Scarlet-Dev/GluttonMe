using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Interfaces
{
    public interface IGluttonMeDatabaseSettings
    {
        string DatabaseName { get; set; }
        string[] CollectionNames { get; set; }
        string ConnectionString { get; set; }
    }
}
