using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankAccountServer
{
    public long Id { get; set; }

    public long BankAccountListId { get; set; }

    public string? ServerName { get; set; }

    public string ServerIp { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? CreatedIp { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
