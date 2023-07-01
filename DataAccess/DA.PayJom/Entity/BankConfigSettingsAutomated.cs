using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankConfigSettingsAutomated
{
    public long Id { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string BankCode { get; set; } = null!;

    public int TxnType { get; set; }

    public string? ExeVersion { get; set; }

    public string Environment { get; set; } = null!;

    public int MaxRetry { get; set; }

    public string MainDir { get; set; } = null!;

    public string? NlogMainDir { get; set; }

    public int ReadDbinterval { get; set; }

    public int ReloginInterval { get; set; }

    public int MaxLoginFailed { get; set; }

    public long AllConnectionId { get; set; }

    public long? ProxySettingId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }
}
