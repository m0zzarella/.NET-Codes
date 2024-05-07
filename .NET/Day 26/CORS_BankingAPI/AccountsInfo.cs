using System;
using System.Collections.Generic;

namespace CORS_BankingAPI;

public partial class AccountsInfo
{
    public int AccNo { get; set; }

    public string? AccName { get; set; }

    public string? AccType { get; set; }

    public long? AccBalance { get; set; }

    public bool? AccIsActive { get; set; }

    public int? AccBranch { get; set; }

    public virtual BranchInfo? AccBranchNavigation { get; set; }
}
