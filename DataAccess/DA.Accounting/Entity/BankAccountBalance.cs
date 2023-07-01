using System;
using System.Collections.Generic;

namespace DA.Accounting;

public partial class BankAccountBalance
{
    public long Id { get; set; }

    public long BankAccountId { get; set; }

    public string AccountNo { get; set; } = null!;

    public decimal Balance { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public long? PjbankId { get; set; }
}
