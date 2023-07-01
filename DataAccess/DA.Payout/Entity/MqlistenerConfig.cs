using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class MqlistenerConfig
{
    public long Id { get; set; }

    public int TxnType { get; set; }

    public int ListenerType { get; set; }

    public string ParamKey { get; set; } = null!;

    public string ParamValue { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;
}
