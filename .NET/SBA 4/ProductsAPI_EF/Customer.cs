using System;
using System.Collections.Generic;

namespace ProductsAPI_EF;

public partial class Customer
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? CAddress { get; set; }

    public decimal? CWalletBalance { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
