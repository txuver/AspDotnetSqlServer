using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankStatementDetail
{
    public long Id { get; set; }

    public DateTime BankStatementDate { get; set; }

    public string? BankCode { get; set; }

    public string? AccountNumber { get; set; }

    public decimal? Amount { get; set; }

    public string Type { get; set; } = null!;

    public string? CurrencyCode { get; set; }

    public string? InvoiceNo { get; set; }

    public string? ItemId { get; set; }

    public string? MerchantCode { get; set; }

    public string? RefId { get; set; }

    public long? DetailId { get; set; }

    public DateTime CreatedDate { get; set; }
}
