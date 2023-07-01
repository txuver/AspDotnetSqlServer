using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankStatementsAdjustment
{
    public long Id { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public DateTime? AdjustmentDateTime { get; set; }

    public decimal? AdjustmentAmount { get; set; }

    public string? Remark { get; set; }

    public string? MerchantCode { get; set; }

    public string BankCode { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
