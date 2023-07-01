using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class AppScanPhoneSupportedApp
{
    public long Id { get; set; }

    public long PhoneId { get; set; }

    public long BankId { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public int? AppApproveOnly { get; set; }
}
