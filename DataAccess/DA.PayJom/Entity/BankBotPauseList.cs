using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankBotPauseList
{
    public long Id { get; set; }

    public long BankAccountListId { get; set; }

    public string BankCode { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public int? TxnType { get; set; }

    public bool IsPause { get; set; }

    public string? UpdatedBy { get; set; }

    public string? PauseReason { get; set; }
}
