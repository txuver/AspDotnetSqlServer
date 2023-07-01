using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummary
{
    public long Id { get; set; }

    public DateTime TranDate { get; set; }

    public long UserId { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal? PayinTotalAmount { get; set; }

    public decimal? PayinTotalFee { get; set; }

    public decimal? PayoutTotalAmount { get; set; }

    public decimal? PayoutTotalFee { get; set; }

    public decimal? QrtotalAmount { get; set; }

    public decimal? QrtotalFee { get; set; }

    public decimal? Balance { get; set; }

    public DateTime CreatedDate { get; set; }
}
