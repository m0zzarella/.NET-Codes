using System;
using System.Collections.Generic;

namespace CORS_BankingAPI;

public partial class BranchInfo
{
    public int BranchNo { get; set; }

    public string? BranchName { get; set; }

    public string? BranchLocation { get; set; }

    public string? BranchEmail { get; set; }

    public virtual ICollection<AccountsInfo> AccountsInfos { get; set; } = new List<AccountsInfo>();

    public virtual ICollection<TransactionInfo> TransactionInfoFromAccNoNavigations { get; set; } = new List<TransactionInfo>();

    public virtual ICollection<TransactionInfo> TransactionInfoToAccNoNavigations { get; set; } = new List<TransactionInfo>();
}
