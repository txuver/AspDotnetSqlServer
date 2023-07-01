using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class UserLogo
{
    public long UserId { get; set; }

    public string? LogoUrl { get; set; }

    public string? DomainUrl { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedIp { get; set; } = null!;

    public string? FooterLogoUrl { get; set; }
}
