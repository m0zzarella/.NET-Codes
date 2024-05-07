using System;
using System.Collections.Generic;

namespace ShoppingDB_API_EF;

public partial class Product
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public decimal? PPrice { get; set; }

    public int? PAvailableQty { get; set; }

    public bool? PIsInStock { get; set; }

    public decimal? PDiscountPercentage { get; set; }

    public string? POfferCode { get; set; }

    public decimal? POfferCodePercentage { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();
}
