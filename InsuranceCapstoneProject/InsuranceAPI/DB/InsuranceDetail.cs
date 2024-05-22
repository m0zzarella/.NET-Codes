using System;
using System.Collections.Generic;

namespace InsuranceAPI.DB;

public partial class InsuranceDetail
{
    public int InsuranceId { get; set; }

    public string? InsuranceBrand { get; set; }

    public string? InsuranceCategory { get; set; }

    public string? InsuranceDescription { get; set; }

    public decimal? InsurancePrice { get; set; }

    public int? InsuranceAgeRequirement { get; set; }
}
