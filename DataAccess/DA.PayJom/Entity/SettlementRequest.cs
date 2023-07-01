using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class SettlementRequest
{
    public int Id { get; set; }

    public string? RefId { get; set; }

    public long OwnerId { get; set; }

    public string OwnerName { get; set; } = null!;

    public long SettlementBankId { get; set; }

    public string Currency { get; set; } = null!;

    public long RequestedTo { get; set; }

    public decimal OriAvailableBalance { get; set; }

    public decimal RequestedAmount { get; set; }

    public string? StatementRemark { get; set; }

    public decimal SettlementFee { get; set; }

    public string? Remark { get; set; }

    public string Status { get; set; } = null!;

    public string? BankSlips { get; set; }

    public string IpAddress { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string UpdatedIpAddress { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public long? PreSettlementId { get; set; }

    public long? DsMasterId { get; set; }

    public int? SettlementVersion { get; set; }
}
