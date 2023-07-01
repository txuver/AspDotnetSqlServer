using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankInfoListThb
{
    public long Id { get; set; }

    public long BankAccountListId { get; set; }

    public string? PromptPayId { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public bool? IsAutoBot { get; set; }

    public string? LoginUsername { get; set; }

    public string? LoginPassword { get; set; }

    public string? Qrpath { get; set; }

    public string? Qrcode { get; set; }

    public int? ScanType { get; set; }
}
