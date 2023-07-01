using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayoutBankAccountBlock
{
    public long Id { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string BankCode { get; set; } = null!;

    public string? AccountNumber { get; set; }

    public bool Blocked { get; set; }

    public string? Comment { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
