using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankGroupMerchant
{
    public long Id { get; set; }

    public long MerchantsAccountProvidersId { get; set; }

    public int Type { get; set; }

    public long BankGroupId { get; set; }

    public long? Priority { get; set; }

    public int Status { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
