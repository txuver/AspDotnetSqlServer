using System;
using System.Collections.Generic;

namespace DA.Accounting;

public partial class BankStatementRemark
{
    public long Id { get; set; }

    public long GroupId { get; set; }

    public long BankStatementId { get; set; }

    public string? Remark { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
