using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankStatement
{
    public long Id { get; set; }

    public DateTime? BankStatementDate { get; set; }

    public string BankCode { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public decimal? Credit { get; set; }

    public decimal? Debit { get; set; }

    public decimal? TotalAmountAdjustment { get; set; }

    public decimal? ClosingBalance { get; set; }

    public string? UpdatedBy { get; set; }

    public decimal? Payin { get; set; }

    public decimal? Qr { get; set; }
}
