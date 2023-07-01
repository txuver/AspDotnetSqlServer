using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankConfigSettingsAllConnection
{
    public long Id { get; set; }

    public int TxnType { get; set; }

    public string Environment { get; set; } = null!;

    public string ExeRunningHost { get; set; } = null!;

    public string PayJomDbconnection { get; set; } = null!;

    public string? PayoutDbconnection { get; set; }

    public string? AccountingDbconnection { get; set; }

    public string? LogDbconnection { get; set; }

    public string RedisConnection { get; set; } = null!;

    public string Mqhost { get; set; } = null!;

    public string Mqusername { get; set; } = null!;

    public string Mqpassword { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }
}
