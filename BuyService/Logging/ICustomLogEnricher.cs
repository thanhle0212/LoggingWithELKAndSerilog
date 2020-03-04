using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyService.Logging
{
    public interface ICustomLogEnricher
    {
        string CorrelationId { get; set; }
    }
}
