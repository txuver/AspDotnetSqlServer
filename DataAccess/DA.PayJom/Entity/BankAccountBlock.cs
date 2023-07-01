using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankAccountBlock
{
    public long Id { get; set; }

    public string BankCode { get; set; } = null!;

    public string Username { get; set; } = null!;

    public bool Blocked { get; set; }

    public string? Comment { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
