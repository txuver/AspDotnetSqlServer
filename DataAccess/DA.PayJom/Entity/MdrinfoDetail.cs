using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MdrinfoDetail
{
    public long Id { get; set; }

    public long MdrinfoId { get; set; }

    public int Product { get; set; }

    public decimal Mdrrate { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
