using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankGroupMaster
{
    public long Id { get; set; }

    public long MasterApdefaultSettingId { get; set; }

    public long BankGroupId { get; set; }

    public long? Priority { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
