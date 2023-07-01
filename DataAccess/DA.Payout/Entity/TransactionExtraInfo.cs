using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class TransactionExtraInfo
{
    public long Id { get; set; }

    public long PayoutTransactionId { get; set; }

    public string? ActualBeneficiaryName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? BankScanServerName { get; set; }

    public string? BankScanServerIp { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
