using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class UserList
{
    public long Id { get; set; }

    public long ParentId { get; set; }

    public string Username { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public string? FullName { get; set; }

    public string? CompanyName { get; set; }

    public string? Email { get; set; }

    /// <summary>
    /// 0 = Inactive, 1 = Active, 2 = Suspended
    /// </summary>
    public byte UserStatus { get; set; }

    public string CreatedIp { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset CreatedDate { get; set; }

    public string? UpdatedIp { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTimeOffset? UpdatedDate { get; set; }

    public string? Platform { get; set; }

    public bool? ConfigMdr { get; set; }
}
