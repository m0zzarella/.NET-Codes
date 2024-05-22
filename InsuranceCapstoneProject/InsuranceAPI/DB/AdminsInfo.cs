using System;
using System.Collections.Generic;

namespace InsuranceAPI.DB;

public partial class AdminsInfo
{
    public int AdminId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
