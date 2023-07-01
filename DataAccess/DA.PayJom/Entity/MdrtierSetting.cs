using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MdrtierSetting
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Name { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public byte Type { get; set; }

    public bool Default { get; set; }

    public string Currency { get; set; } = null!;

    public string Platform { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
