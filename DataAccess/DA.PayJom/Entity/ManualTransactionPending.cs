using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class ManualTransactionPending
{
    public int Id { get; set; }

    public string? MerchantCode { get; set; }

    public string? MerchantBankCode { get; set; }

    public string? MerchantAccount { get; set; }

    public string? MerchantAccountName { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime BankStatementDate { get; set; }

    public decimal? TimeZone { get; set; }

    public string RefId { get; set; } = null!;

    public string? Description { get; set; }

    public string? ReceiverReference { get; set; }

    public decimal Amount { get; set; }

    public decimal? BalanceAfterCredit { get; set; }

    public string? SenderBankCode { get; set; }

    public string? SenderAccount { get; set; }

    public string? SenderAccountName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? RawSenderAccount { get; set; }
}
