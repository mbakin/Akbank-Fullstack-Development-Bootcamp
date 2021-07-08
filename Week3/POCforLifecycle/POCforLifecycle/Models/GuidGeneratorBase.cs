using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCforLifecycle.Models
{
    public abstract class GuidGeneratorBase : IGuidGenerator
    {
        public Guid GeneratedGuid { get ; set ; }

        public GuidGeneratorBase()
        {
            GeneratedGuid = Guid.NewGuid();
        }

    }
}
