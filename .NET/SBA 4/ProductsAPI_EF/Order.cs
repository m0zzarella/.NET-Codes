using System;
using System.Collections.Generic;

namespace ProductsAPI_EF;

public partial class Order
{
    public int OId { get; set; }

    public int? CId { get; set; }

    public int? PId { get; set; }

    public string? OStatus { get; set; }

    public virtual Customer? CIdNavigation { get; set; }

    public virtual Product? PIdNavigation { get; set; }
}
