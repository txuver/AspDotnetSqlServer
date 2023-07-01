using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankErrorMessageList
{
    public long Id { get; set; }

    public string ErrorCode { get; set; } = null!;

    public string ActualError { get; set; } = null!;

    public string? ReturnError { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;
}
