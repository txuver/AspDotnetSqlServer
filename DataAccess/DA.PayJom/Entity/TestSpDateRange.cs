using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TestSpDateRange
{
    public long Id { get; set; }

    public string Spname { get; set; } = null!;

    public string FromDate { get; set; } = null!;

    public string ToDate { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
