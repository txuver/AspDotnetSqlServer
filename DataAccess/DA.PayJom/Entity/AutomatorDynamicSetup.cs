using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class AutomatorDynamicSetup
{
    public long Id { get; set; }

    public int TxnType { get; set; }

    public string BankCode { get; set; } = null!;

    public int ElementType { get; set; }

    public int CodeType { get; set; }

    public int PageNum { get; set; }

    public int SubPage { get; set; }

    public int CodeSection { get; set; }

    public int SubCodeSection { get; set; }

    public int Sequence { get; set; }

    public string? ElementXpath { get; set; }

    public string? ElementTag { get; set; }

    public string? ElementAttr { get; set; }

    public string? ElementVal { get; set; }

    public int? ElementIsVisible { get; set; }

    public int? ElementIsEnabled { get; set; }

    public int? Action { get; set; }

    public int? ActionNotFound { get; set; }

    public long? SendKeyVarId { get; set; }

    public int? WaitIntervalMilliSec { get; set; }

    public long? ErrorId { get; set; }

    public int? Retry { get; set; }

    public int? Relogin { get; set; }

    public int? InactiveAccount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;
}
