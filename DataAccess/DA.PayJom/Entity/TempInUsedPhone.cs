using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TempInUsedPhone
{
    public long Id { get; set; }

    public string Phone { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string? BankAccount { get; set; }

    public string? Product { get; set; }

    public string? RetryCount { get; set; }

    public string? RetrySame { get; set; }

    public string? ManualEnabledAp { get; set; }

    public DateTime CreatedDateMy { get; set; }

    public string? BankScanServerIp { get; set; }

    public string? BankScanServerName { get; set; }
}
