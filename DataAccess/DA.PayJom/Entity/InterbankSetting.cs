using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class InterbankSetting
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string BankFrom { get; set; } = null!;

    public string BankTo { get; set; } = null!;

    public long AccountId { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
