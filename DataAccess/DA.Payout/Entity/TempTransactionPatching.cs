using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class TempTransactionPatching
{
    public long RunId { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public string BeneficiaryAccount { get; set; } = null!;

    public string? BeneficiaryName { get; set; }

    public string BankCode { get; set; } = null!;

    public decimal? Amount { get; set; }

    public decimal? MerchantFees { get; set; }

    public decimal? MasterFees { get; set; }

    public decimal? Apfees { get; set; }

    public string? BankHash { get; set; }

    public decimal? ComCommision { get; set; }

    public decimal? OriginalAmount { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
