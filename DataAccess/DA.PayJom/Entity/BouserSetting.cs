using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BouserSetting
{
    public string UserName { get; set; } = null!;

    public string? UpdatedIp { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTimeOffset? UpdatedDate { get; set; }

    public bool? BankLimitNotificationSetting { get; set; }
}
