using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class SettlementBankAccount
{
    public long Id { get; set; }

    public string OwnerId { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string BankCode { get; set; } = null!;

    public string? Status { get; set; }

    public string? AccountNumber { get; set; }

    public string? AccountName { get; set; }

    public DateTimeOffset? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? BankName { get; set; }

    public string? WalletAddress { get; set; }
}
