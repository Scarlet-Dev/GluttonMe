using GluttonMe.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Models
{
    public class GluttonMeDatabaseSettings : IGluttonMeDatabaseSettings
    {
        public GluttonMeDatabaseSettings()
        {
        }

        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string[] CollectionNames { get; set; }
    }
}
