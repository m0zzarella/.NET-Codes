using System;
using System.Collections.Generic;

namespace ShoppingDB_API_EF;

public partial class Orderdetail
{
    public int OId { get; set; }

    public int? OProductId { get; set; }

    public int? CId { get; set; }

    public decimal? OrderTotal { get; set; }

    public virtual Customerdetail? CIdNavigation { get; set; }

    public virtual Product? OProduct { get; set; }
}
