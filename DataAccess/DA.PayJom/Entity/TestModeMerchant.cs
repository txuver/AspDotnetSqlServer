using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TestModeMerchant
{
    public int Id { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string Product { get; set; } = null!;

    public bool IsEnable { get; set; }

    public DateTime UpdatedDateMy { get; set; }
}
