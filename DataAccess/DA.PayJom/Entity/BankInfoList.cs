using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankInfoList
{
    public long Id { get; set; }

    public string SenderBankCode { get; set; } = null!;

    public string SenderAccount { get; set; } = null!;

    public string? SenderUsername { get; set; }

    public string? SenderPassword { get; set; }

    public string SenderMobile { get; set; } = null!;

    public string? TransactionPin { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public long? BankAccountListId { get; set; }

    public string? OtpApiurl { get; set; }

    public string? Qrcodeurl { get; set; }

    public int? ScanType { get; set; }

    public string? QrcodeContent { get; set; }

    public string? ClientId { get; set; }

    public string? ClientApikey { get; set; }

    public string? ProductId { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantApiurl { get; set; }

    public string? CertificatePath { get; set; }
}
