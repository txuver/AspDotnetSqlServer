using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinTransactionEnter
{
    public long Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string ItemId { get; set; } = null!;

    public decimal Amount { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? ClientName { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public string? Status { get; set; }

    public string? HttppostUrl { get; set; }

    public string? FailedReturnUrl { get; set; }

    public string? ReturnUrl { get; set; }

    public string? Token { get; set; }

    public string? Token2 { get; set; }

    public string? IpAddress { get; set; }

    public string? SelectedBank { get; set; }

    public string? TransserverName { get; set; }

    public string? TransserverIp { get; set; }

    public string? ClientFullName { get; set; }

    public bool? SenderVerification { get; set; }

    public virtual ICollection<PayinTransactionEnterDetail> PayinTransactionEnterDetails { get; set; } = new List<PayinTransactionEnterDetail>();
}
