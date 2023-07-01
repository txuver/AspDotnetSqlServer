using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class UserTransactionLimit
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public byte LimitBetType { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal MinTransaction { get; set; }

    public decimal MaxTransaction { get; set; }

    public decimal BeneficiaryLimit { get; set; }

    public int BeneficiaryCount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string? ClientIp { get; set; }
}
