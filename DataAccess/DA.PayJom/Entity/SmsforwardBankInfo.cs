using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class SmsforwardBankInfo
{
    public long Id { get; set; }

    public long BankInfoListId { get; set; }

    public string? MerchantCode { get; set; }

    public int? IsSms { get; set; }

    public int? IsEmail { get; set; }

    public int? IsApi { get; set; }

    public int? IsTelegram { get; set; }

    public string? Command { get; set; }
}
