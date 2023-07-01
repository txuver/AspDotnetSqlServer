using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankConfigSettingsProxySetting
{
    public long Id { get; set; }

    public string BankCode { get; set; } = null!;

    public int TxnType { get; set; }

    public string Environment { get; set; } = null!;

    public string? LuminatiConn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }
}
