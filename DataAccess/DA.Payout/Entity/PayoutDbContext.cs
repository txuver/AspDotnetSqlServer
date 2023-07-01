using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DA.Payout;

public partial class PayoutDbContext : DbContext
{
    public PayoutDbContext()
    {
    }

    public PayoutDbContext(DbContextOptions<PayoutDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AutoCountDeposit> AutoCountDeposits { get; set; }

    public virtual DbSet<BeneficiaryDailyLimit> BeneficiaryDailyLimits { get; set; }

    public virtual DbSet<CountryNo> CountryNos { get; set; }

    public virtual DbSet<DuitNowTransactionBk> DuitNowTransactionBks { get; set; }

    public virtual DbSet<DuitNowTransactionStatusBk> DuitNowTransactionStatusBks { get; set; }

    public virtual DbSet<InvoiceNo> InvoiceNos { get; set; }

    public virtual DbSet<ManualPayoutConfig> ManualPayoutConfigs { get; set; }

    public virtual DbSet<MerchantWallet> MerchantWallets { get; set; }

    public virtual DbSet<MqlistenerConfig> MqlistenerConfigs { get; set; }

    public virtual DbSet<OtpbankCode> OtpbankCodes { get; set; }

    public virtual DbSet<PayoutTransactionEnter> PayoutTransactionEnters { get; set; }

    public virtual DbSet<PromptPayTransactionBk> PromptPayTransactionBks { get; set; }

    public virtual DbSet<PromptPayTransactionStatusBk> PromptPayTransactionStatusBks { get; set; }

    public virtual DbSet<SperrorLog> SperrorLogs { get; set; }

    public virtual DbSet<TempTransactionPatch> TempTransactionPatches { get; set; }

    public virtual DbSet<TempTransactionPatching> TempTransactionPatchings { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionExtraInfo> TransactionExtraInfos { get; set; }

    public virtual DbSet<TransactionStatus> TransactionStatuses { get; set; }

    public virtual DbSet<UpitransactionBk> UpitransactionBks { get; set; }

    public virtual DbSet<UpitransactionStatusBk> UpitransactionStatusBks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AutoCountDeposit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserTransactionLimit");

            entity
                .ToTable("AutoCountDeposit")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("AutoCountDepositLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.BeneficiaryAccountNumber).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryBankCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.LatestAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.OriginalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BeneficiaryDailyLimit>(entity =>
        {
            entity
                .ToTable("BeneficiaryDailyLimit")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BeneficiaryDailyLimitLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.HasIndex(e => new { e.BankCode, e.BeneficiaryAccount }, "idx_BankCode_BenAcc");

            entity.Property(e => e.BankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.DailyLimit).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<CountryNo>(entity =>
        {
            entity.ToTable("CountryNo");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DuitNowTransactionBk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DuitNowTransaction");

            entity.ToTable("DuitNowTransaction_BK");

            entity.HasIndex(e => e.AccountProviderCode, "IX_DuitNowTransaction_AccountProviderCode");

            entity.HasIndex(e => e.CreatedDate, "IX_DuitNowTransaction_CreatedDate");

            entity.HasIndex(e => e.MasterCode, "IX_DuitNowTransaction_MasterCode");

            entity.HasIndex(e => e.MerchantId, "IX_DuitNowTransaction_MerchantId");

            entity.HasIndex(e => e.InvoiceNo, "UIX_DuitNowTransaction_InvoiceNo").IsUnique();

            entity.HasIndex(e => e.RefId, "uidx_refid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ApcommisionRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("APCommisionRate");
            entity.Property(e => e.Apfees)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("APFees");
            entity.Property(e => e.BeneficiaryAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryBankHash).HasMaxLength(8);
            entity.Property(e => e.BeneficiaryMobile).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(100);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MasterFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MasterMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MasterMDRRate");
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MerchantFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MerchantMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MerchantMDRRate");
            entity.Property(e => e.Qrcode)
                .HasMaxLength(150)
                .HasColumnName("QRCode");
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.SenderAddress).HasMaxLength(255);
            entity.Property(e => e.SenderMobile).HasMaxLength(50);
            entity.Property(e => e.SenderName).HasMaxLength(255);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(40);
        });

        modelBuilder.Entity<DuitNowTransactionStatusBk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DuitNowTransactionStatus");

            entity
                .ToTable("DuitNowTransactionStatus_BK")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("DuitNowTransactionStatusLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.ErrorMessage).HasMaxLength(100);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.ReferenceType).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<InvoiceNo>(entity =>
        {
            entity.ToTable("InvoiceNo");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ManualPayoutConfig>(entity =>
        {
            entity
                .ToTable("ManualPayoutConfig")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("ManualPayoutConfigLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountLevel).HasMaxLength(10);
            entity.Property(e => e.ParentUsername).HasMaxLength(30);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.Username).HasMaxLength(30);
        });

        modelBuilder.Entity<MerchantWallet>(entity =>
        {
            entity.ToTable("MerchantWallet");

            entity.HasIndex(e => e.MerchantCode, "idx_MerchantCode");

            entity.HasIndex(e => new { e.MerchantCode, e.CurrencyCode }, "idx_MerchantCode_CurrCode");

            entity.HasIndex(e => new { e.TxnType, e.InvoiceNo }, "idx_TxnType_InvNo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remark1)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Remark2)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Remark3)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RunningBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TxnAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TxnType)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MqlistenerConfig>(entity =>
        {
            entity
                .ToTable("MQListenerConfig")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MQListenerConfigLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.ParamKey).HasMaxLength(50);
            entity.Property(e => e.ParamValue).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<OtpbankCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTPBankCode");

            entity.Property(e => e.Bank).HasMaxLength(200);
            entity.Property(e => e.BankCode).HasMaxLength(20);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PayoutTransactionEnter>(entity =>
        {
            entity.ToTable("PayoutTransactionEnter");

            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.BeneficiaryAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(100);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(40);
        });

        modelBuilder.Entity<PromptPayTransactionBk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PromptPayTransaction");

            entity.ToTable("PromptPayTransaction_BK");

            entity.HasIndex(e => e.AccountProviderCode, "IX_PromptPayTransaction_AccountProviderCode");

            entity.HasIndex(e => e.CreatedDate, "IX_PromptPayTransaction_CreatedDate");

            entity.HasIndex(e => e.MasterCode, "IX_PromptPayTransaction_MasterCode");

            entity.HasIndex(e => e.MerchantId, "IX_PromptPayTransaction_MerchantId");

            entity.HasIndex(e => e.InvoiceNo, "UIX_PromptPayTransaction_InvoiceNo").IsUnique();

            entity.HasIndex(e => e.RefId, "uidx_refid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ApcommisionRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("APCommisionRate");
            entity.Property(e => e.Apfees)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("APFees");
            entity.Property(e => e.BeneficiaryAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryBankHash).HasMaxLength(8);
            entity.Property(e => e.BeneficiaryMobile).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(100);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MasterFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MasterMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MasterMDRRate");
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MerchantFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MerchantMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MerchantMDRRate");
            entity.Property(e => e.OriginalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PromptPayId).HasMaxLength(20);
            entity.Property(e => e.Qrcode)
                .HasMaxLength(150)
                .HasColumnName("QRCode");
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.SenderMobile).HasMaxLength(50);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(40);
        });

        modelBuilder.Entity<PromptPayTransactionStatusBk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PromptPayTransactionStatus");

            entity
                .ToTable("PromptPayTransactionStatus_BK")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("PromptPayTransactionStatusLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.ErrorMessage).HasMaxLength(100);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.ReferenceType).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<SperrorLog>(entity =>
        {
            entity.ToTable("SPErrorLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ErrorMessage).HasMaxLength(200);
            entity.Property(e => e.ErrorProcedure).HasMaxLength(200);
            entity.Property(e => e.StoredProcedureName).HasMaxLength(150);
        });

        modelBuilder.Entity<TempTransactionPatch>(entity =>
        {
            entity.HasKey(e => e.RunId);

            entity.ToTable("TempTransactionPatch");

            entity.Property(e => e.RunId).HasColumnName("RunID");
            entity.Property(e => e.ErrorMessage).HasMaxLength(100);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.ReferenceType).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.TransactionStatusId).HasColumnName("TransactionStatusID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<TempTransactionPatching>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempTransactionPatching");

            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Apfees)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("APFees");
            entity.Property(e => e.BankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.BeneficiaryAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(100);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MerchantFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.OriginalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.RunId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RunID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("Transaction");

            entity.HasIndex(e => e.CreatedDate, "IX_Transaction_CreatedDate");

            entity.HasIndex(e => new { e.CurrencyCode, e.TxnType, e.MerchantAccount }, "IX_Transaction_CurrencyCodeTxnType");

            entity.HasIndex(e => new { e.CurrencyCode, e.MasterId, e.TxnType }, "IX_Transaction_CurrencyCode_MasterId_TxnType");

            entity.HasIndex(e => new { e.MasterCode, e.TxnType }, "IX_Transaction_MasterCode_TxnType");

            entity.HasIndex(e => new { e.CurrencyCode, e.MerchantId, e.TxnType }, "IX_Transaction_MerchantId_TxnType");

            entity.HasIndex(e => e.TxnType, "IX_Transaction_TxnType");

            entity.HasIndex(e => new { e.TxnType, e.CreatedDate }, "IX_Transaction_TxnType_CreatedDate");

            entity.HasIndex(e => e.InvoiceNo, "UIX_Transaction_InvoiceNo").IsUnique();

            entity.HasIndex(e => e.RefId, "uidx_refid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ApcommisionRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("APCommisionRate");
            entity.Property(e => e.Apfees)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("APFees");
            entity.Property(e => e.BankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.BeneficiaryAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(100);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Ifsc)
                .HasMaxLength(20)
                .HasColumnName("IFSC");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MasterFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MasterMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MasterMDRRate");
            entity.Property(e => e.MerchantAccount).HasMaxLength(200);
            entity.Property(e => e.MerchantBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MerchantFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MerchantMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MerchantMDRRate");
            entity.Property(e => e.Mobile).HasMaxLength(100);
            entity.Property(e => e.OriginalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PromptPayId).HasMaxLength(20);
            entity.Property(e => e.Qrcode)
                .HasMaxLength(150)
                .HasColumnName("QRCode");
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.SenderAddress).HasMaxLength(255);
            entity.Property(e => e.SenderMobile).HasMaxLength(50);
            entity.Property(e => e.SenderName).HasMaxLength(255);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(40);
        });

        modelBuilder.Entity<TransactionExtraInfo>(entity =>
        {
            entity.ToTable("TransactionExtraInfo");

            entity.Property(e => e.ActualBeneficiaryName).HasMaxLength(100);
            entity.Property(e => e.BankScanServerIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BankScanServerIP");
            entity.Property(e => e.BankScanServerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<TransactionStatus>(entity =>
        {
            entity
                .ToTable("TransactionStatus")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("TransactionStatusLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.HasIndex(e => e.Reference, "IX_TransactionStatus_Reference");

            entity.HasIndex(e => e.TransactionStatus1, "IX_TransactionStatus_TransactionStatus");

            entity.HasIndex(e => e.PayoutTransactionId, "idx-PayoutTransactionId").IsUnique();

            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.ErrorMessage).HasMaxLength(100);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.ReferenceType).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.TransactionStatus1).HasColumnName("TransactionStatus");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<UpitransactionBk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UPITransaction");

            entity.ToTable("UPITransaction_BK");

            entity.HasIndex(e => e.AccountProviderCode, "IX_UPITransaction_AccountProviderCode");

            entity.HasIndex(e => e.CreatedDate, "IX_UPITransaction_CreatedDate");

            entity.HasIndex(e => e.MasterCode, "IX_UPITransaction_MasterCode_TxnType");

            entity.HasIndex(e => e.MerchantId, "IX_UPITransaction_MerchantId_TxnType");

            entity.HasIndex(e => e.InvoiceNo, "UIX_UPITransaction_InvoiceNo").IsUnique();

            entity.HasIndex(e => e.RefId, "uidx_refid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ApcommisionRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("APCommisionRate");
            entity.Property(e => e.Apfees)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("APFees");
            entity.Property(e => e.BeneficiaryAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryBankHash).HasMaxLength(8);
            entity.Property(e => e.BeneficiaryMobile).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(100);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MasterFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MasterMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MasterMDRRate");
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MerchantFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MerchantMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MerchantMDRRate");
            entity.Property(e => e.OriginalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Qrcode)
                .HasMaxLength(150)
                .HasColumnName("QRCode");
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.SenderAddress).HasMaxLength(255);
            entity.Property(e => e.SenderMobile).HasMaxLength(50);
            entity.Property(e => e.SenderName).HasMaxLength(255);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(40);
        });

        modelBuilder.Entity<UpitransactionStatusBk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UPITransactionStatus");

            entity
                .ToTable("UPITransactionStatus_BK")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("UPITransactionStatusLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.ErrorMessage).HasMaxLength(100);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.ReferenceType).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpitransactionId).HasColumnName("UPITransactionId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
