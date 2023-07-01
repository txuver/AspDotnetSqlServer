using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class CaptchaTransaction
{
    public long Id { get; set; }

    public string? CaptchaText { get; set; }

    public string? FileName { get; set; }

    public string? QueueName { get; set; }

    public int? IsExist { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
