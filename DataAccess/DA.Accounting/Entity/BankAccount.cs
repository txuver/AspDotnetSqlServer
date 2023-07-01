using System;
using System.Collections.Generic;

namespace DA.Accounting;

public partial class BankAccount
{
    public long Id { get; set; }

    public long MemberId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Bank { get; set; } = null!;

    public int Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public DateTime? LastFetchedDate { get; set; }

    public int? ServiceType { get; set; }

    public string? Currency { get; set; }

    public long? BankAccountListId { get; set; }

    public bool? IsTerminated { get; set; }

    public bool? IsEnterprise { get; set; }

    public string? CompanyId { get; set; }

    public int? BankType { get; set; }

    public string? SecureQuestion1 { get; set; }

    public string? SecureAns1 { get; set; }

    public string? SecureQuestion2 { get; set; }

    public string? SecureAns2 { get; set; }

    public string? SecureQuestion3 { get; set; }

    public string? SecureAns3 { get; set; }

    public string? AccountName { get; set; }

    public string? PhoneNumber { get; set; }
}
