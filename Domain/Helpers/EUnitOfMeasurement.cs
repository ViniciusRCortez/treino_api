using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest.Domain.Helpers
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("UN")]
        Unity = 1,
        
        [Description("MG")]
        Miligram = 2,

        [Description("G")]
        Gram = 3,

        [Description("KG")]
        Kilogram = 4,

        [Description("L")]
        Litter = 5
    }
}