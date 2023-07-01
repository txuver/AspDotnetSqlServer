using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class AutomatorDynamicSetupVariable
{
    public long Id { get; set; }

    public int TxnType { get; set; }

    public string BankCode { get; set; } = null!;

    public string VariableName { get; set; } = null!;

    public long VariableTypeId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;
}
