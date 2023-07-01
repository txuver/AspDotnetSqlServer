using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class BeneficiaryDailyLimit
{
    public long Id { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string? RefId { get; set; }

    public string BankCode { get; set; } = null!;

    public string BeneficiaryAccount { get; set; } = null!;

    public string StatementDate { get; set; } = null!;

    public decimal? DailyLimit { get; set; }

    public int? DailyCount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }
}
