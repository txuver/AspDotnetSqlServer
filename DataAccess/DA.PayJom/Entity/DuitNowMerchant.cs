using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class DuitNowMerchant
{
    public long Id { get; set; }

    public string MerchantName { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
