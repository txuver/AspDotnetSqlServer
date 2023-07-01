using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantCustomTierSetting
{
    public long Id { get; set; }

    public long MdrtierSettingId { get; set; }

    public long MerchantUserId { get; set; }

    public byte Tier { get; set; }

    public decimal From { get; set; }

    public decimal To { get; set; }

    public decimal Rate { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
