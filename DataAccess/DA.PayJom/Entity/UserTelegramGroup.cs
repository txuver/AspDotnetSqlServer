using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class UserTelegramGroup
{
    public string Username { get; set; } = null!;

    public string TelegramGroupId { get; set; } = null!;

    public string? AccountLevel { get; set; }
}
