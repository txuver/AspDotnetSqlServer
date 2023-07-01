using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantsAccountProvidersHistory
{
    public long Id { get; set; }

    public long MerchantUserId { get; set; }

    public long AccountProviderUserId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public string? ClientIp { get; set; }

    public string? Currency { get; set; }

    public bool? IsDeleted { get; set; }

    public byte? Priority { get; set; }
}
