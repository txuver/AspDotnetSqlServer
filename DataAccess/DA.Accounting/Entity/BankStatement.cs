using System;
using System.Collections.Generic;

namespace DA.Accounting;

public partial class BankStatement
{
    public long Id { get; set; }

    public string BankCode { get; set; } = null!;

    public string LoginUsername { get; set; } = null!;

    public long AgentId { get; set; }

    public string BankAccountNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string Description { get; set; } = null!;

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public decimal Balance { get; set; }

    public DateTime RetrieveTime { get; set; }

    public string RedisKey { get; set; } = null!;

    public long? BankAccountId { get; set; }

    public string? InvoiceNo { get; set; }
}
