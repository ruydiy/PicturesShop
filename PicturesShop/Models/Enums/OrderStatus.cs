namespace PicturesShop.Models.Enums
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Threading.Tasks;

    public enum OrderStatus
    {
        [Description("Sent")]
        SENT,

        [Description("Processing")]
        PROCESSING,

        [Description("Cancelled")]
        CANCELLED,

        [Description("Delivered")]
        DELIVERED
    }
}
