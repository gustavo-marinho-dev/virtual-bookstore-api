using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookstore.Domain.Enums
{
    public enum OrderState
    {
        [Description("Novo")]
        NEW,

        [Description("Aguardando Pagamento")]
        PENDING_ACKNOWLEDGMENT_PAYMENT,

        [Description("Pago")]
        PAID_OUT,

        [Description("Exceção de Pagamento")]
        PAYMENT_EXCEPTION,

        [Description("Enviado")]
        SHIPPED,

        [Description("Cancelado")]
        CANCELLED,

        [Description("Entregue")]
        DELIVERED
    }

}
