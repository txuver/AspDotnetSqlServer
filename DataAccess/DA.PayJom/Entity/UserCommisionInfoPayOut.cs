using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class UserCommisionInfoPayOut
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Currency { get; set; } = null!;

    public decimal Commision { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
