using System;
using System.Collections.Generic;

namespace productsAPI_EF;

public partial class CustomerDetail
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? CCity { get; set; }

    public int? CWalletBalance { get; set; }

    public bool? CIsActive { get; set; }
}
