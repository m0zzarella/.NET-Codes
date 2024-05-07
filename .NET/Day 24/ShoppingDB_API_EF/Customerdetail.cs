using System;
using System.Collections.Generic;

namespace ShoppingDB_API_EF;

public partial class Customerdetail
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? CCity { get; set; }

    public decimal? CWalletBalance { get; set; }

    public string? CEmail { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();
}
