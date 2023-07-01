using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantsFundActivity
{
    public long Id { get; set; }

    public string RefId { get; set; } = null!;

    public long MerchantId { get; set; }

    public string MerchantName { get; set; } = null!;

    public string TxnType { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public decimal? PayoutBalance { get; set; }

    public decimal? PayinBalance { get; set; }

    public decimal Amount { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Attachment { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public string? AccountLevel { get; set; }

    public DateTime? RequestedDate { get; set; }
}
