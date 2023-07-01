using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DA.Qr;

public partial class QrDbContext : DbContext
{
    public QrDbContext()
    {
    }

    public QrDbContext(DbContextOptions<QrDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AutoCountDeposit> AutoCountDeposits { get; set; }

    public virtual DbSet<DuitNowTransaction> DuitNowTransactions { get; set; }

    public virtual DbSet<DuitNowTransactionStatus> DuitNowTransactionStatuses { get; set; }

    public virtual DbSet<PromptPayTransaction> PromptPayTransactions { get; set; }

    public virtual DbSet<PromptPayTransactionStatus> PromptPayTransactionStatuses { get; set; }

    public virtual DbSet<Upitransaction> Upitransactions { get; set; }

    public virtual DbSet<UpitransactionStatus> UpitransactionStatuses { get; set; }

    public virtual DbSet<ViewTransaction> ViewTransactions { get; set; }

    public virtual DbSet<ViewTransactionSelInvoiceNo> ViewTransactionSelInvoiceNos { get; set; }

    public virtual DbSet<ViewTransactionTransactionStatus> ViewTransactionTransactionStatuses { get; set; }

    public virtual DbSet<ViewTransactionTransactionStatusJoin> ViewTransactionTransactionStatusJoins { get; set; }

    public virtual DbSet<ViewTransactionTransactionStatusUat> ViewTransactionTransactionStatusUats { get; set; }

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

        modelBuilder.Entity<DuitNowTransaction>(entity =>
        {
            entity.ToTable("DuitNowTransaction");

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
                .HasMaxLength(200)
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

        modelBuilder.Entity<DuitNowTransactionStatus>(entity =>
        {
            entity
                .ToTable("DuitNowTransactionStatus")
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

            entity.HasIndex(e => e.Reference, "IX_DuitNow_Reference");

            entity.HasIndex(e => e.TransactionStatus, "IX_DuitNow_TransactionStatus");

            entity.HasIndex(e => e.DuitNowTransactionId, "uidx-DuitNowTransactionId")
                .IsUnique()
                .IsDescending();

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

        modelBuilder.Entity<PromptPayTransaction>(entity =>
        {
            entity.ToTable("PromptPayTransaction");

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

        modelBuilder.Entity<PromptPayTransactionStatus>(entity =>
        {
            entity
                .ToTable("PromptPayTransactionStatus")
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

            entity.HasIndex(e => e.Reference, "IX_PromptPay_Reference");

            entity.HasIndex(e => e.TransactionStatus, "IX_PromptPay_TransactionStatus");

            entity.HasIndex(e => e.PromptPayTransactionId, "uidx-PromptPayTransactionId")
                .IsUnique()
                .IsDescending();

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

        modelBuilder.Entity<Upitransaction>(entity =>
        {
            entity.ToTable("UPITransaction");

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

        modelBuilder.Entity<UpitransactionStatus>(entity =>
        {
            entity
                .ToTable("UPITransactionStatus")
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

            entity.HasIndex(e => e.Reference, "IX_UPI_Reference");

            entity.HasIndex(e => e.TransactionStatus, "IX_UPI_TransactionStatus");

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

        modelBuilder.Entity<ViewTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Transaction");

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
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
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
                .HasMaxLength(200)
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
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewTransactionSelInvoiceNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Transaction_SelInvoiceNo");

            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewTransactionTransactionStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Transaction_TransactionStatus");

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
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.ErrorMessage).HasMaxLength(100);
            entity.Property(e => e.Id).HasColumnName("ID");
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
                .HasMaxLength(200)
                .HasColumnName("QRCode");
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceType).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SenderAddress).HasMaxLength(255);
            entity.Property(e => e.SenderMobile).HasMaxLength(50);
            entity.Property(e => e.SenderName).HasMaxLength(255);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.TransactionCreatedBy)
                .HasMaxLength(20)
                .HasColumnName("Transaction_CreatedBy");
            entity.Property(e => e.TransactionCreatedDate).HasColumnName("Transaction_CreatedDate");
            entity.Property(e => e.TransactionReference)
                .HasMaxLength(50)
                .HasColumnName("Transaction_Reference");
            entity.Property(e => e.TransactionStatusCreatedBy)
                .HasMaxLength(20)
                .HasColumnName("TransactionStatus_CreatedBy");
            entity.Property(e => e.TransactionStatusCreatedDate).HasColumnName("TransactionStatus_CreatedDate");
            entity.Property(e => e.TransactionStatusId).HasColumnName("TransactionStatus_Id");
            entity.Property(e => e.TransactionStatusReference)
                .HasMaxLength(50)
                .HasColumnName("TransactionStatus_Reference");
            entity.Property(e => e.TransactionStatusUpdatedBy)
                .HasMaxLength(20)
                .HasColumnName("TransactionStatus_UpdatedBy");
            entity.Property(e => e.TransactionStatusUpdatedDate).HasColumnName("TransactionStatus_UpdatedDate");
            entity.Property(e => e.TransactionUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("Transaction_UpdatedBy");
            entity.Property(e => e.TransactionUpdatedDate).HasColumnName("Transaction_UpdatedDate");
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewTransactionTransactionStatusJoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Transaction_TransactionStatus_JOIN");

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
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.ErrorMessage).HasMaxLength(100);
            entity.Property(e => e.Id).HasColumnName("ID");
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
                .HasMaxLength(200)
                .HasColumnName("QRCode");
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceType).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SenderAddress).HasMaxLength(255);
            entity.Property(e => e.SenderMobile).HasMaxLength(50);
            entity.Property(e => e.SenderName).HasMaxLength(255);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.TransactionCreatedBy)
                .HasMaxLength(20)
                .HasColumnName("Transaction_CreatedBy");
            entity.Property(e => e.TransactionCreatedDate).HasColumnName("Transaction_CreatedDate");
            entity.Property(e => e.TransactionReference)
                .HasMaxLength(50)
                .HasColumnName("Transaction_Reference");
            entity.Property(e => e.TransactionStatusCreatedBy)
                .HasMaxLength(20)
                .HasColumnName("TransactionStatus_CreatedBy");
            entity.Property(e => e.TransactionStatusCreatedDate).HasColumnName("TransactionStatus_CreatedDate");
            entity.Property(e => e.TransactionStatusId).HasColumnName("TransactionStatus_Id");
            entity.Property(e => e.TransactionStatusReference)
                .HasMaxLength(50)
                .HasColumnName("TransactionStatus_Reference");
            entity.Property(e => e.TransactionStatusUpdatedBy)
                .HasMaxLength(20)
                .HasColumnName("TransactionStatus_UpdatedBy");
            entity.Property(e => e.TransactionStatusUpdatedDate).HasColumnName("TransactionStatus_UpdatedDate");
            entity.Property(e => e.TransactionUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("Transaction_UpdatedBy");
            entity.Property(e => e.TransactionUpdatedDate).HasColumnName("Transaction_UpdatedDate");
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(40);
        });

        modelBuilder.Entity<ViewTransactionTransactionStatusUat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Transaction_TransactionStatus_UAT");

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
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.ErrorMessage).HasMaxLength(100);
            entity.Property(e => e.Id).HasColumnName("ID");
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
                .HasMaxLength(200)
                .HasColumnName("QRCode");
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceType).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SenderAddress).HasMaxLength(255);
            entity.Property(e => e.SenderMobile).HasMaxLength(50);
            entity.Property(e => e.SenderName).HasMaxLength(255);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.TransactionCreatedBy)
                .HasMaxLength(20)
                .HasColumnName("Transaction_CreatedBy");
            entity.Property(e => e.TransactionCreatedDate).HasColumnName("Transaction_CreatedDate");
            entity.Property(e => e.TransactionReference)
                .HasMaxLength(50)
                .HasColumnName("Transaction_Reference");
            entity.Property(e => e.TransactionStatusCreatedBy)
                .HasMaxLength(20)
                .HasColumnName("TransactionStatus_CreatedBy");
            entity.Property(e => e.TransactionStatusCreatedDate).HasColumnName("TransactionStatus_CreatedDate");
            entity.Property(e => e.TransactionStatusId).HasColumnName("TransactionStatus_Id");
            entity.Property(e => e.TransactionStatusReference)
                .HasMaxLength(50)
                .HasColumnName("TransactionStatus_Reference");
            entity.Property(e => e.TransactionStatusUpdatedBy)
                .HasMaxLength(20)
                .HasColumnName("TransactionStatus_UpdatedBy");
            entity.Property(e => e.TransactionStatusUpdatedDate).HasColumnName("TransactionStatus_UpdatedDate");
            entity.Property(e => e.TransactionUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("Transaction_UpdatedBy");
            entity.Property(e => e.TransactionUpdatedDate).HasColumnName("Transaction_UpdatedDate");
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(40);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
