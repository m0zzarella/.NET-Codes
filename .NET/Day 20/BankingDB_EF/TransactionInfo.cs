using System;
using System.Collections.Generic;

namespace BankingDB_EF;

public partial class TransactionInfo
{
    public int TrNo { get; set; }

    public int? FromAccNo { get; set; }

    public int? ToAccNo { get; set; }

    public int? Amount { get; set; }

    public DateTime? Datetime1 { get; set; }

    public virtual BranchInfo? FromAccNoNavigation { get; set; }

    public virtual BranchInfo? ToAccNoNavigation { get; set; }
}
