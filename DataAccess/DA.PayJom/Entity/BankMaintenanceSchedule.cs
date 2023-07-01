using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankMaintenanceSchedule
{
    public long Id { get; set; }

    public int TxnType { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal TimeZone { get; set; }

    public string ScheduleType { get; set; } = null!;

    public DateTime? OneTimeFromDate { get; set; }

    public DateTime? OneTimeToDate { get; set; }

    public string? RepeatType { get; set; }

    public TimeSpan? RepeatFromTime { get; set; }

    public TimeSpan? RepeatToTime { get; set; }

    public string BankMaintenanceType { get; set; } = null!;

    public string? BankCode { get; set; }

    public string? SenderBankCode { get; set; }

    public string? ReceiverBankCode { get; set; }

    public bool IsActive { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}
