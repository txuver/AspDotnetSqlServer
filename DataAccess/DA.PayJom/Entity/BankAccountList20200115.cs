using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankAccountList20200115
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
}
