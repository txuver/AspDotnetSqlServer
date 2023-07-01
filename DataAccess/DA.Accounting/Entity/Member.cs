using System;
using System.Collections.Generic;

namespace DA.Accounting;

public partial class Member
{
    public long Id { get; set; }

    public long UplinkId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool EnableSafeCode { get; set; }

    public string? SafeCode { get; set; }

    public DateTime? SafeCodeGeneratedDate { get; set; }

    public string Email { get; set; } = null!;

    public string LastLoginIp { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public string MemberRole { get; set; } = null!;

    public int Status { get; set; }

    public int? BankLimit { get; set; }

    public string? Phone { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int? LoginFailedCount { get; set; }

    public DateTime? LoginBlockedDate { get; set; }

    public DateTime? LastLoginAttempDate { get; set; }

    public bool? IsLimitReadTransaction { get; set; }

    public string? SessionId { get; set; }

    public string? Currency { get; set; }

    public int? ReadLimitType { get; set; }

    public string? BankServiceType { get; set; }
}
