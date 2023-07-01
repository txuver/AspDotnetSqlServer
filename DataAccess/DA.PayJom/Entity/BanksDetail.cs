using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BanksDetail
{
    public long Id { get; set; }

    public string BankCode { get; set; } = null!;

    public bool? PayinSender { get; set; }

    public bool? PayinReceiver { get; set; }

    public bool? PayoutSender { get; set; }

    public bool? Upireceiver { get; set; }

    public bool? PromptPayReceiver { get; set; }

    public bool? ManualPayinReceiver { get; set; }

    public bool? AutobotReceiver { get; set; }

    public bool? DuitNowReceiver { get; set; }

    public string? BankLogoUrl { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public bool? Dobwreceiver { get; set; }
}
