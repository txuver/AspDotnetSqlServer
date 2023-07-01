using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class AppScanPhoneList
{
    public long Id { get; set; }

    public string Udid { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? DeviceName { get; set; }

    public string? RunningApp { get; set; }

    public long? BankAccountId { get; set; }

    public long? BankAccountListId { get; set; }

    public int Status { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public int IsWireless { get; set; }

    public bool IsEmulator { get; set; }

    public string? ServerIp { get; set; }
}
