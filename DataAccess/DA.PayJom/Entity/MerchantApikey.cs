using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantApikey
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string? Apikey { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ClientIp { get; set; }

    public string? CallbackUrl { get; set; }

    public string? PayinCallbackUrl { get; set; }

    public bool? IsAutoBot { get; set; }

    public string? QrpayinCallbackUrl { get; set; }

    public string? UpipayinCallbackUrl { get; set; }

    public string? DuitNowPayinCallbackUrl { get; set; }
}
