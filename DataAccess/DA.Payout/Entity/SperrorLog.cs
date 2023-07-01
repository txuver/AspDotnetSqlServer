using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class SperrorLog
{
    public long Id { get; set; }

    public string? StoredProcedureName { get; set; }

    public int? ErrorNumber { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorState { get; set; }

    public string? ErrorProcedure { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? CreatedDate { get; set; }
}
