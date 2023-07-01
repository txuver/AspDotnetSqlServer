using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankInfoListInr
{
    public long Id { get; set; }

    public long BankAccountListId { get; set; }

    public string? LoginUsername { get; set; }

    public string? LoginPassword { get; set; }

    public string? PayeeName { get; set; }

    public string? PayeeAddress { get; set; }

    public int? ScanType { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
