using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class AutoCountDeposit
{
    public long Id { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal OriginalAmount { get; set; }

    public int NumberCount { get; set; }

    public decimal LatestAmount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string? BeneficiaryBankCode { get; set; }

    public string? BeneficiaryAccountNumber { get; set; }
}
