using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class Bank
{
    public long Id { get; set; }

    public string BankCode { get; set; } = null!;

    public string MainCurrency { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? Abbreviation { get; set; }

    public bool? IsSupported { get; set; }

    public string? Version { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
