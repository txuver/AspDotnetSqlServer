using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class ManualTransactionStatus
{
    public int Id { get; set; }

    public int ManualTransactionId { get; set; }

    public int? TransactionStatus { get; set; }

    public int? ResponseCode { get; set; }

    public string? ResponseMessage { get; set; }

    public string? PlayerId { get; set; }

    public string? Remark { get; set; }

    public string? SenderReference { get; set; }

    public string? ClientIp { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;
}
