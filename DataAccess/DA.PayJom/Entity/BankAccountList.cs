using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankAccountList
{
    public long Id { get; set; }

    public string OwnerId { get; set; } = null!;

    public string? AssignedUserId { get; set; }

    public string Currency { get; set; } = null!;

    public string BankCode { get; set; } = null!;

    public string? Status { get; set; }

    public string? AccountNumber { get; set; }

    public string? AccountName { get; set; }

    public int? Priority { get; set; }

    public decimal? MinLimit { get; set; }

    public decimal? MaxLimit { get; set; }

    public decimal? DailyLimit { get; set; }

    public string? UpdatedBy { get; set; }

    public string? BankHash { get; set; }

    public string? UpdatedIp { get; set; }

    public string? Nickname { get; set; }

    public string? AccountType { get; set; }

    public string? Ifsc { get; set; }

    public string? BeneficiaryAddress { get; set; }

    public string? BeneficiaryEmail { get; set; }

    public string? BeneficiaryMobile { get; set; }

    public string? TransactionPassword { get; set; }

    public int? TxnType { get; set; }

    public bool? IsEnableBankBot { get; set; }

    public string? PhoneNumber { get; set; }

    public string? LoginType { get; set; }

    public string? SecureQuestion1 { get; set; }

    public string? SecureAns1 { get; set; }

    public string? SecureQuestion2 { get; set; }

    public string? SecureAns2 { get; set; }

    public string? SecureQuestion3 { get; set; }

    public string? SecureAns3 { get; set; }

    public bool? IsEnterprise { get; set; }

    public string? CompanyId { get; set; }

    public bool? IsManualPayout { get; set; }

    public string? ActionStatus { get; set; }

    public decimal TxnLimit { get; set; }

    public decimal DailyTxnLimit { get; set; }

    public bool? IsSuspended { get; set; }
}
