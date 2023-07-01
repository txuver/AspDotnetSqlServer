using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class OtpbankCode
{
    public long Id { get; set; }

    public string? Bank { get; set; }

    public string? BankCode { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
