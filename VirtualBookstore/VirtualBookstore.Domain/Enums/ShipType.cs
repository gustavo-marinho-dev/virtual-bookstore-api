using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookstore.Domain.Enums
{
    public enum ShipType
    {
        [Description("Padrão")]
        Standard,

        [Description("Express")]
        Express,

        [Description("Entrega no próximo dia")]
        NextDay,

        [Description("Frete grátis")]
        FreeShipping
    }
}
