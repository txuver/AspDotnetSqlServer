using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class InvoiceNo
{
    public long Id { get; set; }

    public int NumberPre { get; set; }

    public int NumberDay { get; set; }

    public int NumberYear { get; set; }

    public int NumberPost { get; set; }
}
