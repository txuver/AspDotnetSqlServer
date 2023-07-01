using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankMaintenance
{
    public long Id { get; set; }

    public int TxnType { get; set; }

    public string BankCode { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal TimeZone { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public bool IsActive { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
