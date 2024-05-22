using System;
using System.Collections.Generic;

namespace InsuranceAPI.DB;

public partial class UsersInfo
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public string? UserEmail { get; set; }

    public string? MobileNumber { get; set; }

    public decimal? WalletBalance { get; set; }
}
