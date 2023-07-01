using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankConfigSettingsAllBankUrl
{
    public long Id { get; set; }

    public string BankCode { get; set; } = null!;

    public string SiteVersion { get; set; } = null!;

    public int LoginType { get; set; }

    public string BankUrl { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }
}
