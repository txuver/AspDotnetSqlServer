using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class AutomatorDynamicSetupVariableType
{
    public long Id { get; set; }

    public string VariableType { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;
}
