using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCforLifecycle.Models
{
    public class CustomService
    {
        public CustomService(IScopedGenerator scopedGenerator, ISingletonGenerator singletonGenerator, ITransientGenerator transientGenerator)
        {
            ScopedGuid = scopedGenerator.GeneratedGuid;
            SingletonGuid = singletonGenerator.GeneratedGuid;
            TransientGuid = transientGenerator.GeneratedGuid;
        }

        public Guid ScopedGuid { get; set; }
        public Guid SingletonGuid { get; set; }
        public Guid TransientGuid { get; set; }
    }
}
