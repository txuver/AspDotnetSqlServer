using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinTransactionEnterExtraInfo
{
    public long Id { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public long PayinTransactionEnterId { get; set; }

    public string? BankHash { get; set; }

    public string MerchantCode { get; set; } = null!;

    public long MerchantId { get; set; }

    public string? MasterCode { get; set; }

    public long? MasterId { get; set; }

    public string? AccountProviderCode { get; set; }

    public long? AccountProviderId { get; set; }

    public string? ComCode { get; set; }

    public long? ComId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int? TxnType { get; set; }
}
