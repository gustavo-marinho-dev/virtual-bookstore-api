using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookstore.Domain.Enums
{
    public enum Backing
    {
        [Description("Capa Dura")]
        Hardback,
        [Description("Capa Mole")]
        Paperback,
        [Description("Usado")]
        Used,
        [Description("Áudio")]
        Audio,
        [Description("Edição Limitada")]
        LimitedEdition
    }
}