using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayDirectLog
{
    public long Id { get; set; }

    public long MerchantId { get; set; }

    public string? MerchantName { get; set; }

    public string ClientName { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal ItemPrice { get; set; }

    public string? InvoiceNo { get; set; }

    public string? PostUrl { get; set; }

    public string? PostData { get; set; }

    public string? Status { get; set; }

    public string? BankName { get; set; }

    public string? TranInfo { get; set; }

    public string? Token { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? TransType { get; set; }

    public string? Response { get; set; }
}
