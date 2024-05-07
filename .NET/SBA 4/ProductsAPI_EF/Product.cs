using System;
using System.Collections.Generic;

namespace ProductsAPI_EF;

public partial class Product
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public decimal? PPrice { get; set; }

    public int? PAvailableQty { get; set; }

    public string? PDescription { get; set; }

    public bool? PIsInStock { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
