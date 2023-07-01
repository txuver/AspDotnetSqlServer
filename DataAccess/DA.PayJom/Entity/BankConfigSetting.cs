using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankConfigSetting
{
    public long Id { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string BankCode { get; set; } = null!;

    public int TxnType { get; set; }

    public int MaxRetry { get; set; }

    public string MainDir { get; set; } = null!;

    public int ReadDbinterval { get; set; }

    public int ReloginInterval { get; set; }

    public int MaxLoginFailed { get; set; }

    public string? BankUrl { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int NameVerifyLen { get; set; }

    public int? ScanType { get; set; }

    public string? AppPackage { get; set; }

    public string? AppLaunchActivity { get; set; }

    public int? ScanInterval { get; set; }

    public string LoginType { get; set; } = null!;

    public int MaxTacreceiveFailed { get; set; }
}
