using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DA.PayJom;

public partial class PayJomDbContext : DbContext
{
    public PayJomDbContext()
    {
    }

    public PayJomDbContext(DbContextOptions<PayJomDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessRight> AccessRights { get; set; }

    public virtual DbSet<AccountProvidersType> AccountProvidersTypes { get; set; }

    public virtual DbSet<AppScanPhoneList> AppScanPhoneLists { get; set; }

    public virtual DbSet<AppScanPhoneSupportedApp> AppScanPhoneSupportedApps { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<AuditTrail> AuditTrails { get; set; }

    public virtual DbSet<AutomatorDynamicSetup> AutomatorDynamicSetups { get; set; }

    public virtual DbSet<AutomatorDynamicSetupVariable> AutomatorDynamicSetupVariables { get; set; }

    public virtual DbSet<AutomatorDynamicSetupVariableType> AutomatorDynamicSetupVariableTypes { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankAccountBlock> BankAccountBlocks { get; set; }

    public virtual DbSet<BankAccountList> BankAccountLists { get; set; }

    public virtual DbSet<BankAccountList20200115> BankAccountList20200115s { get; set; }

    public virtual DbSet<BankAccountListBk> BankAccountListBks { get; set; }

    public virtual DbSet<BankAccountServer> BankAccountServers { get; set; }

    public virtual DbSet<BankBotPauseList> BankBotPauseLists { get; set; }

    public virtual DbSet<BankConfigSetting> BankConfigSettings { get; set; }

    public virtual DbSet<BankConfigSettingsAllBankUrl> BankConfigSettingsAllBankUrls { get; set; }

    public virtual DbSet<BankConfigSettingsAllConnection> BankConfigSettingsAllConnections { get; set; }

    public virtual DbSet<BankConfigSettingsAutomated> BankConfigSettingsAutomateds { get; set; }

    public virtual DbSet<BankConfigSettingsProxySetting> BankConfigSettingsProxySettings { get; set; }

    public virtual DbSet<BankErrorMessageList> BankErrorMessageLists { get; set; }

    public virtual DbSet<BankGroup> BankGroups { get; set; }

    public virtual DbSet<BankGroupDetail> BankGroupDetails { get; set; }

    public virtual DbSet<BankGroupMaster> BankGroupMasters { get; set; }

    public virtual DbSet<BankGroupMerchant> BankGroupMerchants { get; set; }

    public virtual DbSet<BankInfoList> BankInfoLists { get; set; }

    public virtual DbSet<BankInfoListInr> BankInfoListInrs { get; set; }

    public virtual DbSet<BankInfoListThb> BankInfoListThbs { get; set; }

    public virtual DbSet<BankMaintenance> BankMaintenances { get; set; }

    public virtual DbSet<BankMaintenanceSchedule> BankMaintenanceSchedules { get; set; }

    public virtual DbSet<BankStatement> BankStatements { get; set; }

    public virtual DbSet<BankStatementDetail> BankStatementDetails { get; set; }

    public virtual DbSet<BankStatementsAdjustment> BankStatementsAdjustments { get; set; }

    public virtual DbSet<BanksDetail> BanksDetails { get; set; }

    public virtual DbSet<BouserSetting> BouserSettings { get; set; }

    public virtual DbSet<CaptchaTransaction> CaptchaTransactions { get; set; }

    public virtual DbSet<CurrencyRate> CurrencyRates { get; set; }

    public virtual DbSet<DuitNowMerchant> DuitNowMerchants { get; set; }

    public virtual DbSet<DuitNowMerchantsReport> DuitNowMerchantsReports { get; set; }

    public virtual DbSet<InterbankSetting> InterbankSettings { get; set; }

    public virtual DbSet<ManualTransaction> ManualTransactions { get; set; }

    public virtual DbSet<ManualTransactionPending> ManualTransactionPendings { get; set; }

    public virtual DbSet<ManualTransactionStatus> ManualTransactionStatuses { get; set; }

    public virtual DbSet<MasterApdefaultSetting> MasterApdefaultSettings { get; set; }

    public virtual DbSet<MasterMdrdefaultSetting> MasterMdrdefaultSettings { get; set; }

    public virtual DbSet<MasterTierLog> MasterTierLogs { get; set; }

    public virtual DbSet<MastersType> MastersTypes { get; set; }

    public virtual DbSet<Mdrinfo> Mdrinfos { get; set; }

    public virtual DbSet<MdrinfoDetail> MdrinfoDetails { get; set; }

    public virtual DbSet<MdrtierSetting> MdrtierSettings { get; set; }

    public virtual DbSet<MemberLogin> MemberLogins { get; set; }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<MerchantApikey> MerchantApikeys { get; set; }

    public virtual DbSet<MerchantCustomTierSetting> MerchantCustomTierSettings { get; set; }

    public virtual DbSet<MerchantMdrsetting> MerchantMdrsettings { get; set; }

    public virtual DbSet<MerchantTierLog> MerchantTierLogs { get; set; }

    public virtual DbSet<MerchantType> MerchantTypes { get; set; }

    public virtual DbSet<MerchantsAccountProvider> MerchantsAccountProviders { get; set; }

    public virtual DbSet<MerchantsAccountProvidersHistory> MerchantsAccountProvidersHistories { get; set; }

    public virtual DbSet<MerchantsAccountProvidersPayout> MerchantsAccountProvidersPayouts { get; set; }

    public virtual DbSet<MerchantsAccountProvidersPayoutHistory> MerchantsAccountProvidersPayoutHistories { get; set; }

    public virtual DbSet<MerchantsFundActivity> MerchantsFundActivities { get; set; }

    public virtual DbSet<MerchantsFundActivityLogProdBk20220721> MerchantsFundActivityLogProdBk20220721s { get; set; }

    public virtual DbSet<MerchantsFundActivityProdBk20220721> MerchantsFundActivityProdBk20220721s { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<PayDirectCallbackLog> PayDirectCallbackLogs { get; set; }

    public virtual DbSet<PayDirectLog> PayDirectLogs { get; set; }

    public virtual DbSet<PayinCimbBrowser> PayinCimbBrowsers { get; set; }

    public virtual DbSet<PayinFpxinvoiceNo> PayinFpxinvoiceNos { get; set; }

    public virtual DbSet<PayinFpxtransaction> PayinFpxtransactions { get; set; }

    public virtual DbSet<PayinFpxtransactionStatus> PayinFpxtransactionStatuses { get; set; }

    public virtual DbSet<PayinInvoiceNo> PayinInvoiceNos { get; set; }

    public virtual DbSet<PayinIpwhiteList> PayinIpwhiteLists { get; set; }

    public virtual DbSet<PayinTraceLog> PayinTraceLogs { get; set; }

    public virtual DbSet<PayinTransaction> PayinTransactions { get; set; }

    public virtual DbSet<PayinTransactionEnter> PayinTransactionEnters { get; set; }

    public virtual DbSet<PayinTransactionEnterDetail> PayinTransactionEnterDetails { get; set; }

    public virtual DbSet<PayinTransactionEnterExtraInfo> PayinTransactionEnterExtraInfos { get; set; }

    public virtual DbSet<PayinTransactionExtraInfo> PayinTransactionExtraInfos { get; set; }

    public virtual DbSet<PayinTransactionStatus> PayinTransactionStatuses { get; set; }

    public virtual DbSet<PayoutBankAccountBlock> PayoutBankAccountBlocks { get; set; }

    public virtual DbSet<PayoutIpwhiteList> PayoutIpwhiteLists { get; set; }

    public virtual DbSet<PendingCount> PendingCounts { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<RebateRequest> RebateRequests { get; set; }

    public virtual DbSet<RebateRequestTier> RebateRequestTiers { get; set; }

    public virtual DbSet<RebateUserTier> RebateUserTiers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleList> RoleLists { get; set; }

    public virtual DbSet<RoleModuleAccessRight> RoleModuleAccessRights { get; set; }

    public virtual DbSet<SenderBankInfo> SenderBankInfos { get; set; }

    public virtual DbSet<SettlementBankAccount> SettlementBankAccounts { get; set; }

    public virtual DbSet<SettlementFeeSetting> SettlementFeeSettings { get; set; }

    public virtual DbSet<SettlementRequest> SettlementRequests { get; set; }

    public virtual DbSet<SettlementSetting> SettlementSettings { get; set; }

    public virtual DbSet<SmsforwardBankInfo> SmsforwardBankInfos { get; set; }

    public virtual DbSet<SubAccount> SubAccounts { get; set; }

    public virtual DbSet<SubAccountAccessRight> SubAccountAccessRights { get; set; }

    public virtual DbSet<TableA> TableAs { get; set; }

    public virtual DbSet<TableB> TableBs { get; set; }

    public virtual DbSet<TempInUsedPhone> TempInUsedPhones { get; set; }

    public virtual DbSet<TempTransactionPatch> TempTransactionPatches { get; set; }

    public virtual DbSet<TestModeMerchant> TestModeMerchants { get; set; }

    public virtual DbSet<TestSample> TestSamples { get; set; }

    public virtual DbSet<TestSpDateRange> TestSpDateRanges { get; set; }

    public virtual DbSet<TierSetting> TierSettings { get; set; }

    public virtual DbSet<TraceLog> TraceLogs { get; set; }

    public virtual DbSet<TransactionOverrideLog> TransactionOverrideLogs { get; set; }

    public virtual DbSet<TransactionSummary> TransactionSummaries { get; set; }

    public virtual DbSet<TransactionSummaryAll> TransactionSummaryAlls { get; set; }

    public virtual DbSet<TransactionSummaryAllSetting> TransactionSummaryAllSettings { get; set; }

    public virtual DbSet<TransactionSummaryDetail> TransactionSummaryDetails { get; set; }

    public virtual DbSet<TransactionSummaryJob> TransactionSummaryJobs { get; set; }

    public virtual DbSet<TransactionSummaryJobAll> TransactionSummaryJobAlls { get; set; }

    public virtual DbSet<TransactionSummaryNew> TransactionSummaryNews { get; set; }

    public virtual DbSet<TransactionSummaryNewDetail> TransactionSummaryNewDetails { get; set; }

    public virtual DbSet<TransactionSummaryNewSubDetail> TransactionSummaryNewSubDetails { get; set; }

    public virtual DbSet<TransactionSummarySetting> TransactionSummarySettings { get; set; }

    public virtual DbSet<TransactionSummarySettingNew> TransactionSummarySettingNews { get; set; }

    public virtual DbSet<TransactionSummaryV2> TransactionSummaryV2s { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User2Fa> User2Fas { get; set; }

    public virtual DbSet<UserCommisionInfoPayOut> UserCommisionInfoPayOuts { get; set; }

    public virtual DbSet<UserCurrency> UserCurrencies { get; set; }

    public virtual DbSet<UserIdBlock> UserIdBlocks { get; set; }

    public virtual DbSet<UserList> UserLists { get; set; }

    public virtual DbSet<UserLogo> UserLogos { get; set; }

    public virtual DbSet<UserMdrinfo> UserMdrinfos { get; set; }

    public virtual DbSet<UserMdrinfo20200115> UserMdrinfo20200115s { get; set; }

    public virtual DbSet<UserMdrinfoBk> UserMdrinfoBks { get; set; }

    public virtual DbSet<UserMdrinfoPayOut> UserMdrinfoPayOuts { get; set; }

    public virtual DbSet<UserSiteConfig> UserSiteConfigs { get; set; }

    public virtual DbSet<UserTelegramGroup> UserTelegramGroups { get; set; }

    public virtual DbSet<UserTransactionLimit> UserTransactionLimits { get; set; }

    public virtual DbSet<VinDeadlock> VinDeadlocks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessRight>(entity =>
        {
            entity.Property(e => e.AccessRightName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<AccountProvidersType>(entity =>
        {
            entity
                .ToTable("AccountProvidersType")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("AccountProvidersTypeLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.IsUpi).HasColumnName("IsUPI");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<AppScanPhoneList>(entity =>
        {
            entity
                .ToTable("AppScanPhoneList")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("AppScanPhoneListLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.DeviceName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.RunningApp).HasMaxLength(100);
            entity.Property(e => e.ServerIp).HasMaxLength(20);
            entity.Property(e => e.Udid)
                .HasMaxLength(20)
                .HasColumnName("udid");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<AppScanPhoneSupportedApp>(entity =>
        {
            entity
                .ToTable("AppScanPhoneSupportedApp")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("AppScanPhoneSupportedAppLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AppApproveOnly).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__Applicat__C93A4C99BB1F5D2D");

            entity.Property(e => e.ApplicationId).ValueGeneratedNever();
            entity.Property(e => e.ApplicationName).HasMaxLength(235);
            entity.Property(e => e.Description).HasMaxLength(256);
        });

        modelBuilder.Entity<AuditTrail>(entity =>
        {
            entity.ToTable("AuditTrail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.Remark2).HasMaxLength(100);
            entity.Property(e => e.UserIp)
                .HasMaxLength(100)
                .HasColumnName("UserIP");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<AutomatorDynamicSetup>(entity =>
        {
            entity.ToTable("AutomatorDynamicSetup");

            entity.Property(e => e.ActionNotFound).HasColumnName("Action_NotFound");
            entity.Property(e => e.BankCode).HasMaxLength(4);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.ElementAttr)
                .HasMaxLength(20)
                .HasColumnName("Element_Attr");
            entity.Property(e => e.ElementIsEnabled).HasColumnName("Element_isEnabled");
            entity.Property(e => e.ElementIsVisible).HasColumnName("Element_isVisible");
            entity.Property(e => e.ElementTag)
                .HasMaxLength(20)
                .HasColumnName("Element_Tag");
            entity.Property(e => e.ElementVal)
                .HasMaxLength(100)
                .HasColumnName("Element_Val");
            entity.Property(e => e.ElementXpath)
                .HasMaxLength(200)
                .HasColumnName("Element_XPath");
            entity.Property(e => e.SendKeyVarId).HasColumnName("SendKeyVar_Id");
            entity.Property(e => e.SubCodeSection).HasColumnName("Sub_CodeSection");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.WaitIntervalMilliSec).HasColumnName("WaitInterval_MilliSec");
        });

        modelBuilder.Entity<AutomatorDynamicSetupVariable>(entity =>
        {
            entity.ToTable("AutomatorDynamicSetup_Variable");

            entity.Property(e => e.BankCode).HasMaxLength(4);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.VariableName).HasMaxLength(30);
        });

        modelBuilder.Entity<AutomatorDynamicSetupVariableType>(entity =>
        {
            entity.ToTable("AutomatorDynamicSetup_VariableType");

            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.VariableType).HasMaxLength(50);
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BanksLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BankCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.MainCurrency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.Version).HasMaxLength(20);
        });

        modelBuilder.Entity<BankAccountBlock>(entity =>
        {
            entity
                .ToTable("BankAccountBlock")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankAccountBlockLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.BankCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Comment).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<BankAccountList>(entity =>
        {
            entity
                .ToTable("BankAccountList")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankAccountListLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountName).HasMaxLength(255);
            entity.Property(e => e.AccountNumber).HasMaxLength(255);
            entity.Property(e => e.AccountType).HasMaxLength(10);
            entity.Property(e => e.ActionStatus).HasMaxLength(20);
            entity.Property(e => e.AssignedUserId).HasMaxLength(20);
            entity.Property(e => e.BankCode).HasMaxLength(4);
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.BeneficiaryAddress).HasMaxLength(255);
            entity.Property(e => e.BeneficiaryEmail).HasMaxLength(255);
            entity.Property(e => e.BeneficiaryMobile).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasMaxLength(50);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DailyLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DailyTxnLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Ifsc)
                .HasMaxLength(20)
                .HasColumnName("IFSC");
            entity.Property(e => e.LoginType).HasMaxLength(10);
            entity.Property(e => e.MaxLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MinLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Nickname).HasMaxLength(50);
            entity.Property(e => e.OwnerId).HasMaxLength(20);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SecureAns1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecureAns2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecureAns3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecureQuestion1).HasMaxLength(150);
            entity.Property(e => e.SecureQuestion2).HasMaxLength(150);
            entity.Property(e => e.SecureQuestion3).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.TransactionPassword).HasMaxLength(50);
            entity.Property(e => e.TxnLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankAccountList20200115>(entity =>
        {
            entity
                .ToTable("BankAccountList_20200115")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankAccountListLog_20200115", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountName).HasMaxLength(255);
            entity.Property(e => e.AccountNumber).HasMaxLength(255);
            entity.Property(e => e.AssignedUserId).HasMaxLength(20);
            entity.Property(e => e.BankCode).HasMaxLength(4);
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DailyLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MaxLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MinLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.OwnerId).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BankAccountListBk>(entity =>
        {
            entity.ToTable("BankAccountList_BK");

            entity.Property(e => e.AccountName).HasMaxLength(255);
            entity.Property(e => e.AccountNumber).HasMaxLength(255);
            entity.Property(e => e.AssignedUserId).HasMaxLength(20);
            entity.Property(e => e.BankCode).HasMaxLength(4);
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DailyLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MaxLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MinLimit).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.OwnerId).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BankAccountServer>(entity =>
        {
            entity
                .ToTable("BankAccountServer")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankAccountServerLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedIP");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ServerIP");
            entity.Property(e => e.ServerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankBotPauseList>(entity =>
        {
            entity
                .ToTable("BankBotPauseList")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankBotPauseListLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountNo).HasMaxLength(150);
            entity.Property(e => e.BankCode).HasMaxLength(4);
            entity.Property(e => e.IsPause).HasColumnName("isPause");
            entity.Property(e => e.PauseReason).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BankConfigSetting>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AppLaunchActivity).HasMaxLength(255);
            entity.Property(e => e.AppPackage).HasMaxLength(255);
            entity.Property(e => e.BankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BankUrl).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.LoginType)
                .HasMaxLength(10)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.MainDir).HasMaxLength(255);
            entity.Property(e => e.MaxTacreceiveFailed)
                .HasDefaultValueSql("((3))")
                .HasColumnName("MaxTACReceiveFailed");
            entity.Property(e => e.NameVerifyLen).HasDefaultValueSql("((20))");
            entity.Property(e => e.ReadDbinterval).HasColumnName("ReadDBInterval");
            entity.Property(e => e.ScanType).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<BankConfigSettingsAllBankUrl>(entity =>
        {
            entity.ToTable("BankConfigSettings_AllBankURL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BankUrl).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.SiteVersion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<BankConfigSettingsAllConnection>(entity =>
        {
            entity.ToTable("BankConfigSettings_AllConnections");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountingDbconnection)
                .HasMaxLength(255)
                .HasColumnName("AccountingDBConnection");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Environment)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ExeRunningHost).HasMaxLength(20);
            entity.Property(e => e.LogDbconnection)
                .HasMaxLength(255)
                .HasColumnName("LogDBConnection");
            entity.Property(e => e.Mqhost)
                .HasMaxLength(20)
                .HasColumnName("MQHost");
            entity.Property(e => e.Mqpassword)
                .HasMaxLength(50)
                .HasColumnName("MQPassword");
            entity.Property(e => e.Mqusername)
                .HasMaxLength(50)
                .HasColumnName("MQUsername");
            entity.Property(e => e.PayJomDbconnection)
                .HasMaxLength(255)
                .HasColumnName("PayJomDBConnection");
            entity.Property(e => e.PayoutDbconnection)
                .HasMaxLength(255)
                .HasColumnName("PayoutDBConnection");
            entity.Property(e => e.RedisConnection).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BankConfigSettingsAutomated>(entity =>
        {
            entity.ToTable("BankConfigSettings_Automated");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Environment)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ExeVersion).HasMaxLength(10);
            entity.Property(e => e.MainDir).HasMaxLength(50);
            entity.Property(e => e.NlogMainDir)
                .HasMaxLength(255)
                .HasColumnName("NLogMainDir");
            entity.Property(e => e.ReadDbinterval).HasColumnName("ReadDBInterval");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BankConfigSettingsProxySetting>(entity =>
        {
            entity.ToTable("BankConfigSettings_ProxySetting");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Environment)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.LuminatiConn).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BankErrorMessageList>(entity =>
        {
            entity.ToTable("BankErrorMessageList");

            entity.Property(e => e.ActualError).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.ErrorCode).HasMaxLength(6);
            entity.Property(e => e.ReturnError).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BankGroup>(entity =>
        {
            entity
                .ToTable("BankGroup")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankGroupLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupName).HasMaxLength(100);
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankGroupDetail>(entity =>
        {
            entity
                .ToTable("BankGroupDetail")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankGroupDetailLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankGroupMaster>(entity =>
        {
            entity
                .ToTable("BankGroupMaster")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankGroupMasterLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MasterApdefaultSettingId).HasColumnName("MasterAPDefaultSettingId");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankGroupMerchant>(entity =>
        {
            entity
                .ToTable("BankGroupMerchant")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankGroupMerchantLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankInfoList>(entity =>
        {
            entity
                .ToTable("BankInfoList")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankInfoListLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CertificatePath).HasMaxLength(255);
            entity.Property(e => e.ClientApikey)
                .HasMaxLength(50)
                .HasColumnName("ClientAPIKey");
            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .HasColumnName("ClientID");
            entity.Property(e => e.MerchantApiurl)
                .HasMaxLength(255)
                .HasColumnName("MerchantAPIUrl");
            entity.Property(e => e.MerchantId)
                .HasMaxLength(50)
                .HasColumnName("MerchantID");
            entity.Property(e => e.OtpApiurl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OtpAPIUrl");
            entity.Property(e => e.ProductId)
                .HasMaxLength(50)
                .HasColumnName("ProductID");
            entity.Property(e => e.QrcodeContent)
                .HasMaxLength(500)
                .HasColumnName("QRCodeContent");
            entity.Property(e => e.Qrcodeurl).HasColumnName("QRCodeurl");
            entity.Property(e => e.SenderAccount)
                .HasMaxLength(50)
                .HasColumnName("sender_account");
            entity.Property(e => e.SenderBankCode)
                .HasMaxLength(10)
                .HasColumnName("sender_bank_code");
            entity.Property(e => e.SenderMobile)
                .HasMaxLength(50)
                .HasColumnName("sender_mobile");
            entity.Property(e => e.SenderPassword)
                .HasMaxLength(50)
                .HasColumnName("sender_password");
            entity.Property(e => e.SenderUsername)
                .HasMaxLength(50)
                .HasColumnName("sender_username");
            entity.Property(e => e.TransactionPin)
                .HasMaxLength(50)
                .HasColumnName("transaction_pin");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankInfoListInr>(entity =>
        {
            entity
                .ToTable("BankInfoListINR")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankInfoListINRLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.LoginPassword).HasMaxLength(50);
            entity.Property(e => e.LoginUsername).HasMaxLength(50);
            entity.Property(e => e.PayeeAddress).HasMaxLength(150);
            entity.Property(e => e.PayeeName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankInfoListThb>(entity =>
        {
            entity
                .ToTable("BankInfoListTHB")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankInfoListTHBLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.LoginPassword).HasMaxLength(50);
            entity.Property(e => e.LoginUsername).HasMaxLength(50);
            entity.Property(e => e.PromptPayId).HasMaxLength(20);
            entity.Property(e => e.Qrcode)
                .HasMaxLength(150)
                .HasColumnName("QRCode");
            entity.Property(e => e.Qrpath)
                .HasMaxLength(150)
                .HasColumnName("QRPath");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankMaintenance>(entity =>
        {
            entity
                .ToTable("BankMaintenance")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankMaintenanceLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.BankCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TimeZone).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankMaintenanceSchedule>(entity =>
        {
            entity
                .ToTable("BankMaintenanceSchedule")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankMaintenanceScheduleLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.BankCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BankMaintenanceType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ReceiverBankCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RepeatType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SenderBankCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TimeZone).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BankStatement>(entity =>
        {
            entity.ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankStatementsLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountNumber).HasMaxLength(100);
            entity.Property(e => e.BankCode).HasMaxLength(10);
            entity.Property(e => e.BankStatementDate).HasColumnType("date");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Credit).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Debit).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Payin).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Qr)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("QR");
            entity.Property(e => e.TotalAmountAdjustment).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<BankStatementDetail>(entity =>
        {
            entity.Property(e => e.AccountNumber).HasMaxLength(100);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.BankCode).HasMaxLength(10);
            entity.Property(e => e.BankStatementDate).HasColumnType("date");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.ItemId).HasMaxLength(255);
            entity.Property(e => e.MerchantCode).HasMaxLength(20);
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Type).HasMaxLength(10);
        });

        modelBuilder.Entity<BankStatementsAdjustment>(entity =>
        {
            entity
                .ToTable("BankStatementsAdjustment")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BankStatementsAdjustmentLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountNumber).HasMaxLength(100);
            entity.Property(e => e.AdjustmentAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.BankCode).HasMaxLength(10);
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MerchantCode).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<BanksDetail>(entity =>
        {
            entity
                .ToTable("BanksDetail")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("BanksDetailLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.BankCode).HasMaxLength(4);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Dobwreceiver).HasColumnName("DOBWReceiver");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.Upireceiver).HasColumnName("UPIReceiver");
        });

        modelBuilder.Entity<BouserSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOUserSettings");

            entity.Property(e => e.BankLimitNotificationSetting).HasDefaultValueSql("('FALSE')");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<CaptchaTransaction>(entity =>
        {
            entity.ToTable("CaptchaTransaction");

            entity.Property(e => e.CaptchaText).HasMaxLength(20);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FileName).HasMaxLength(150);
            entity.Property(e => e.QueueName).HasMaxLength(20);
        });

        modelBuilder.Entity<CurrencyRate>(entity =>
        {
            entity
                .ToTable("CurrencyRate")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("CurrencyRateLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.CurrencyFrom)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyTo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("decimal(9, 5)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<DuitNowMerchant>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MerchantName).HasMaxLength(50);
        });

        modelBuilder.Entity<DuitNowMerchantsReport>(entity =>
        {
            entity.ToTable("DuitNowMerchantsReport");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MerchantName).HasMaxLength(50);
        });

        modelBuilder.Entity<InterbankSetting>(entity =>
        {
            entity
                .ToTable("InterbankSetting")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("InterbankSettingLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.BankFrom)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BankTo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<ManualTransaction>(entity =>
        {
            entity.ToTable("ManualTransaction");

            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ApcommisionRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("APCommisionRate");
            entity.Property(e => e.Apfees)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("APFees");
            entity.Property(e => e.BalanceAfterCredit).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MasterFees).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MasterMdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MasterMDRRate");
            entity.Property(e => e.MerchantAccount).HasMaxLength(200);
            entity.Property(e => e.MerchantAccountName).HasMaxLength(200);
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
            entity.Property(e => e.RawSenderAccount).HasMaxLength(200);
            entity.Property(e => e.ReceiverReference).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SenderAccount).HasMaxLength(200);
            entity.Property(e => e.SenderAccountName).HasMaxLength(200);
            entity.Property(e => e.SenderBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TimeZone).HasColumnType("decimal(6, 2)");
        });

        modelBuilder.Entity<ManualTransactionPending>(entity =>
        {
            entity.ToTable("ManualTransactionPending");

            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.BalanceAfterCredit).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.MerchantAccount).HasMaxLength(200);
            entity.Property(e => e.MerchantAccountName).HasMaxLength(200);
            entity.Property(e => e.MerchantBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RawSenderAccount).HasMaxLength(200);
            entity.Property(e => e.ReceiverReference).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SenderAccount).HasMaxLength(200);
            entity.Property(e => e.SenderAccountName).HasMaxLength(200);
            entity.Property(e => e.SenderBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TimeZone).HasColumnType("decimal(6, 2)");
        });

        modelBuilder.Entity<ManualTransactionStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransactionStatus");

            entity
                .ToTable("ManualTransactionStatus")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("ManualTransactionStatusLog", "dbo");
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
            entity.Property(e => e.PlayerId).HasMaxLength(20);
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.ResponseMessage).HasMaxLength(255);
            entity.Property(e => e.SenderReference).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<MasterApdefaultSetting>(entity =>
        {
            entity
                .ToTable("MasterAPDefaultSetting")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MasterAPDefaultSettingLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MasterMdrdefaultSetting>(entity =>
        {
            entity
                .ToTable("MasterMDRDefaultSetting")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MasterMDRDefaultSettingLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MasterMdrsettingId).HasColumnName("MasterMDRSettingId");
            entity.Property(e => e.MerchantMdrsettingId).HasColumnName("MerchantMDRSettingId");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MasterTierLog>(entity =>
        {
            entity
                .ToTable("MasterTierLog")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MasterTierLogLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CurrentVolume).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastInvoiceNo).HasMaxLength(25);
            entity.Property(e => e.Mdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MDRRate");
            entity.Property(e => e.TransAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MastersType>(entity =>
        {
            entity
                .ToTable("MastersType")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MastersTypeLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.IsEnableUpi).HasColumnName("IsEnableUPI");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<Mdrinfo>(entity =>
        {
            entity
                .ToTable("MDRInfo")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MDRInfoLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PlatformName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<MdrinfoDetail>(entity =>
        {
            entity
                .ToTable("MDRInfoDetail")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MDRInfoDetailLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.MdrinfoId).HasColumnName("MDRInfoId");
            entity.Property(e => e.Mdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MDRRate");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MdrtierSetting>(entity =>
        {
            entity
                .ToTable("MDRTierSetting")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MDRTierSettingLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Platform)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MemberLogin>(entity =>
        {
            entity.ToTable("MemberLogin");

            entity.Property(e => e.LoginIp)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LoginIP");
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.SessionId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Membership>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Membersh__1788CC4CBE66E15D");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasMaxLength(256);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowsStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);

            entity.HasOne(d => d.Application).WithMany(p => p.Memberships)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MembershipEntity_Application");

            entity.HasOne(d => d.User).WithOne(p => p.Membership)
                .HasForeignKey<Membership>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MembershipEntity_User");
        });

        modelBuilder.Entity<MerchantApikey>(entity =>
        {
            entity
                .ToTable("MerchantAPIKey")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MerchantAPIKeyLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Apikey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APIKey");
            entity.Property(e => e.CallbackUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.DuitNowPayinCallbackUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PayinCallbackUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.QrpayinCallbackUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("QRPayinCallbackUrl");
            entity.Property(e => e.UpipayinCallbackUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UPIPayinCallbackUrl");
        });

        modelBuilder.Entity<MerchantCustomTierSetting>(entity =>
        {
            entity.ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MerchantCustomTierSettingsLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.From).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MdrtierSettingId).HasColumnName("MDRTierSettingId");
            entity.Property(e => e.Rate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.To).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MerchantMdrsetting>(entity =>
        {
            entity
                .ToTable("MerchantMDRSetting")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MerchantMDRSettingLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MdrsettingId).HasColumnName("MDRSettingId");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MerchantTierLog>(entity =>
        {
            entity
                .ToTable("MerchantTierLog")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MerchantTierLogLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CurrentVolume).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Mdrrate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MDRRate");
            entity.Property(e => e.TransAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MerchantType>(entity =>
        {
            entity
                .ToTable("MerchantType")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MerchantTypeLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.IsEnableUpi).HasColumnName("IsEnableUPI");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MerchantsAccountProvider>(entity =>
        {
            entity.ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MerchantsAccountProvidersLog", "dbo");
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
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MerchantsAccountProvidersHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.CreatedDate, e.UpdatedDate }).HasName("PK__Merchant__680B5DE162FC9126");

            entity.ToTable("MerchantsAccountProvidersHistory");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MerchantsAccountProvidersPayout>(entity =>
        {
            entity
                .ToTable("MerchantsAccountProviders_Payout")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MerchantsAccountProviders_PayoutLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MerchantsAccountProvidersPayoutHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.CreatedDate, e.UpdatedDate }).HasName("PK__Merchant__680B5DE1821E337E");

            entity.ToTable("MerchantsAccountProviders_PayoutHistory");

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MerchantsFundActivity>(entity =>
        {
            entity
                .ToTable("MerchantsFundActivity")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("MerchantsFundActivityLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MerchantName).HasMaxLength(20);
            entity.Property(e => e.PayinBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.RefId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remark1).HasMaxLength(4000);
            entity.Property(e => e.Remark2).HasMaxLength(4000);
            entity.Property(e => e.RequestedDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.TxnType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MerchantsFundActivityLogProdBk20220721>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MerchantsFundActivityLog_ProdBK_20220721");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Attachment).HasMaxLength(4000);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MerchantName).HasMaxLength(20);
            entity.Property(e => e.PayinBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.RefId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remark1).HasMaxLength(4000);
            entity.Property(e => e.Remark2).HasMaxLength(4000);
            entity.Property(e => e.TxnType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<MerchantsFundActivityProdBk20220721>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MerchantsFundActivity_20220721");

            entity.ToTable("MerchantsFundActivity_ProdBK_20220721");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Attachment).HasMaxLength(4000);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MerchantName).HasMaxLength(20);
            entity.Property(e => e.PayinBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.RefId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remark1).HasMaxLength(4000);
            entity.Property(e => e.Remark2).HasMaxLength(4000);
            entity.Property(e => e.TxnType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.MainModuleName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ModuleName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayDirectCallbackLog>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("PayDirectCallbackLog");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Parameter).HasMaxLength(4000);
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.RequestUrl)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Response).HasMaxLength(4000);
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayDirectLog>(entity =>
        {
            entity.ToTable("PayDirectLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.ClientName).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo).HasMaxLength(100);
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(25, 6)");
            entity.Property(e => e.MerchantId).HasColumnName("MerchantID");
            entity.Property(e => e.MerchantName).HasMaxLength(250);
            entity.Property(e => e.PostData).HasMaxLength(1000);
            entity.Property(e => e.PostUrl)
                .HasMaxLength(100)
                .HasColumnName("PostURL");
            entity.Property(e => e.Response).HasMaxLength(4000);
            entity.Property(e => e.Status).HasMaxLength(30);
            entity.Property(e => e.Token)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TranInfo).HasMaxLength(3000);
            entity.Property(e => e.TransType).HasMaxLength(20);
        });

        modelBuilder.Entity<PayinCimbBrowser>(entity =>
        {
            entity.ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("PayinCimbBrowsersLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.BrowserId).HasMaxLength(100);
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.ProxyIp).HasMaxLength(20);
        });

        modelBuilder.Entity<PayinFpxinvoiceNo>(entity =>
        {
            entity.ToTable("PayinFPXInvoiceNo");
        });

        modelBuilder.Entity<PayinFpxtransaction>(entity =>
        {
            entity.ToTable("PayinFPXTransaction");

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
            entity.Property(e => e.BeneficiaryAccountName).HasMaxLength(100);
            entity.Property(e => e.BeneficiaryBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryBankHash).HasMaxLength(8);
            entity.Property(e => e.ClientEmail).HasMaxLength(100);
            entity.Property(e => e.ClientName).HasMaxLength(100);
            entity.Property(e => e.ClientPhone).HasMaxLength(50);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CreatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedIP");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.EndToEndId).HasMaxLength(50);
            entity.Property(e => e.FailedReturnUrl).HasMaxLength(250);
            entity.Property(e => e.HttppostUrl)
                .HasMaxLength(255)
                .HasColumnName("HTTPPostUrl");
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
            entity.Property(e => e.MessageId).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ReturnUrl)
                .HasMaxLength(250)
                .HasColumnName("ReturnURL");
            entity.Property(e => e.SenderBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.StatementDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Token)
                .HasMaxLength(300)
                .HasColumnName("TOKEN");
            entity.Property(e => e.TransactionId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.UserCoordination).HasMaxLength(150);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayinFpxtransactionStatus>(entity =>
        {
            entity
                .ToTable("PayinFPXTransactionStatus")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("PayinFPXTransactionStatusLog", "dbo");
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
            entity.Property(e => e.PayinFpxtransactionId).HasColumnName("PayinFPXTransactionId");
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusMessage).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<PayinInvoiceNo>(entity =>
        {
            entity.ToTable("PayinInvoiceNo");
        });

        modelBuilder.Entity<PayinIpwhiteList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PayinIPWhiteList");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<PayinTraceLog>(entity =>
        {
            entity.ToTable("PayinTraceLog");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedDateUtc).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Data).HasMaxLength(4000);
            entity.Property(e => e.Fi)
                .HasMaxLength(50)
                .HasColumnName("FI");
            entity.Property(e => e.Field).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.PayeeId)
                .HasMaxLength(50)
                .HasColumnName("PayeeID");
        });

        modelBuilder.Entity<PayinTransaction>(entity =>
        {
            entity.ToTable("PayinTransaction");

            entity.HasIndex(e => new { e.CurrencyCode, e.MerchantId }, "IX_PayInTransaction_MerchantID");

            entity.HasIndex(e => new { e.AccountProviderId, e.CurrencyCode }, "IX_PayinTransaction_AccountProviderId");

            entity.HasIndex(e => new { e.CurrencyCode, e.AccountProviderId }, "IX_PayinTransaction_AccountProviderId_CurrencyCode");

            entity.HasIndex(e => e.CreatedDate, "IX_PayinTransaction_CreatedDate");

            entity.HasIndex(e => new { e.CurrencyCode, e.MasterId }, "IX_PayinTransaction_CurrencyCode_MasterId");

            entity.HasIndex(e => e.ItemId, "IX_PayinTransaction_ItemID");

            entity.HasIndex(e => e.MasterId, "IX_PayinTransaction_MasterId");

            entity.HasIndex(e => new { e.ReceiverAccount, e.CreatedDate }, "IX_PayinTransaction_ReceiverAccountCreatedDate");

            entity.HasIndex(e => e.StatementDate, "IX_PayinTransaction_StatementDate");

            entity.HasIndex(e => e.InvoiceNo, "UIX_PayinTransaction_InvoiceNo").IsUnique();

            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Apcommision)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("APCommision");
            entity.Property(e => e.ApcommisionRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("APCommisionRate");
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.ClientEmail).HasMaxLength(50);
            entity.Property(e => e.ClientName).HasMaxLength(255);
            entity.Property(e => e.ClientPhone).HasMaxLength(50);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.ComCommision).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ComCommisionRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.HttppostUrl)
                .HasMaxLength(255)
                .HasColumnName("HTTPPostURL");
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.IpAddress).HasMaxLength(250);
            entity.Property(e => e.ItemDescription).HasMaxLength(255);
            entity.Property(e => e.ItemId).HasMaxLength(255);
            entity.Property(e => e.Key).HasMaxLength(20);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MasterCommision).HasColumnType("decimal(12, 4)");
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
            entity.Property(e => e.ReceiverAccount).HasMaxLength(200);
            entity.Property(e => e.ReceiverAccountName).HasMaxLength(200);
            entity.Property(e => e.ReceiverBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.SenderAccount).HasMaxLength(200);
            entity.Property(e => e.SenderAccountName).HasMaxLength(200);
            entity.Property(e => e.SenderBankCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.StatementDate).HasColumnType("date");
        });

        modelBuilder.Entity<PayinTransactionEnter>(entity =>
        {
            entity.ToTable("PayinTransactionEnter");

            entity.HasIndex(e => new { e.CreatedDate, e.CurrencyCode }, "IX_PayInTransactionEnter_CreatedDate_CurrencyCode");

            entity.HasIndex(e => new { e.ItemId, e.MerchantCode }, "IX_PayinTransactionEnter_ItemID_MerchantCode");

            entity.HasIndex(e => new { e.Status, e.TransserverName }, "IX_PayinTransactionEnter_StatusTransserverName");

            entity.HasIndex(e => e.InvoiceNo, "UIX_PayinTransactionEnter_InvoiceNo").IsUnique();

            entity.HasIndex(e => e.Token2, "UIX_PayinTransactionEnter_TOKEN2")
                .IsUnique()
                .HasFilter("([TOKEN2] IS NOT NULL)");

            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ClientFullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.FailedReturnUrl)
                .HasMaxLength(250)
                .HasColumnName("FailedReturnURL");
            entity.Property(e => e.HttppostUrl)
                .HasMaxLength(255)
                .HasColumnName("HTTPPostURL");
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.IpAddress).HasMaxLength(250);
            entity.Property(e => e.ItemDescription).HasMaxLength(255);
            entity.Property(e => e.ItemId).HasMaxLength(255);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReturnUrl)
                .HasMaxLength(250)
                .HasColumnName("ReturnURL");
            entity.Property(e => e.SelectedBank).HasMaxLength(4);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Token)
                .HasMaxLength(300)
                .HasColumnName("TOKEN");
            entity.Property(e => e.Token2)
                .HasMaxLength(300)
                .HasColumnName("TOKEN2");
            entity.Property(e => e.TransserverIp)
                .HasMaxLength(100)
                .HasColumnName("TransserverIP");
            entity.Property(e => e.TransserverName).HasMaxLength(100);
        });

        modelBuilder.Entity<PayinTransactionEnterDetail>(entity =>
        {
            entity.ToTable("PayinTransactionEnter_Details");

            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.PayinTransactionEnter).WithMany(p => p.PayinTransactionEnterDetails)
                .HasForeignKey(d => d.PayinTransactionEnterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PayinTran__Payin__2B960C00");
        });

        modelBuilder.Entity<PayinTransactionEnterExtraInfo>(entity =>
        {
            entity.ToTable("PayinTransactionEnterExtraInfo");

            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.BankHash).HasMaxLength(8);
            entity.Property(e => e.ComCode).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayinTransactionExtraInfo>(entity =>
        {
            entity.ToTable("PayinTransactionExtraInfo");

            entity.Property(e => e.ActualSenderName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);

            entity.HasOne(d => d.PayinTransaction).WithMany(p => p.PayinTransactionExtraInfos)
                .HasForeignKey(d => d.PayinTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PayinTran__Payin__0AF43244");
        });

        modelBuilder.Entity<PayinTransactionStatus>(entity =>
        {
            entity
                .ToTable("PayinTransactionStatus")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("PayinTransactionStatusLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.HasIndex(e => e.PayinTransactionId, "IX_PayinTransactionStatus_PayinTransactionId").IsUnique();

            entity.HasIndex(e => e.StatusMessage, "IX_PayinTransactionStatus_StatusMessage");

            entity.HasIndex(e => e.TransactionStatus, "IX_PayinTransactionStatus_TransactionStatus");

            entity.Property(e => e.BankReference).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.StatusMessage).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<PayoutBankAccountBlock>(entity =>
        {
            entity
                .ToTable("PayoutBankAccountBlock")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("PayoutBankAccountBlockLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountNumber).HasMaxLength(255);
            entity.Property(e => e.BankCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Comment).HasMaxLength(250);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<PayoutIpwhiteList>(entity =>
        {
            entity.ToTable("PayoutIPWhiteList");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<PendingCount>(entity =>
        {
            entity.ToTable("PendingCount");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Product)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Profiles__1788CC4C88213E84");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithOne(p => p.Profile)
                .HasForeignKey<Profile>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ProfileEntity_User");
        });

        modelBuilder.Entity<RebateRequest>(entity =>
        {
            entity
                .ToTable("RebateRequest")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("RebateRequestLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedIp)
                .HasMaxLength(50)
                .HasColumnName("CreatedIP");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PayinRebateAmount).HasMaxLength(100);
            entity.Property(e => e.PayinRebateRate).HasMaxLength(30);
            entity.Property(e => e.PayinRebateTier).HasMaxLength(5);
            entity.Property(e => e.PayinVolume).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutRebateAmount).HasMaxLength(100);
            entity.Property(e => e.PayoutRebateRate).HasMaxLength(30);
            entity.Property(e => e.PayoutRebateTier).HasMaxLength(5);
            entity.Property(e => e.PayoutVolume).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.QrrebateAmount)
                .HasMaxLength(100)
                .HasColumnName("QRRebateAmount");
            entity.Property(e => e.QrrebateRate)
                .HasMaxLength(30)
                .HasColumnName("QRRebateRate");
            entity.Property(e => e.QrrebateTier)
                .HasMaxLength(5)
                .HasColumnName("QRRebateTier");
            entity.Property(e => e.Qrvolume)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("QRVolume");
            entity.Property(e => e.RefId)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.TotalRebateAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<RebateRequestTier>(entity =>
        {
            entity
                .ToTable("RebateRequestTier")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("RebateRequestTierLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedIp)
                .HasMaxLength(50)
                .HasColumnName("CreatedIP");
            entity.Property(e => e.PayinRate).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutRate).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Qrrate)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("QRRate");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.VolumeFrom).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.VolumeTo).HasColumnType("decimal(19, 2)");
        });

        modelBuilder.Entity<RebateUserTier>(entity =>
        {
            entity
                .ToTable("RebateUserTier")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("RebateUserTierLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountLevel).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedIp)
                .HasMaxLength(50)
                .HasColumnName("CreatedIP");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.Mdrrate)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("MDRRate");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.VolumeFrom).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.VolumeTo).HasColumnType("decimal(19, 2)");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1AB6FAAFAB");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.Roles)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RoleEntity_Application");
        });

        modelBuilder.Entity<RoleList>(entity =>
        {
            entity
                .ToTable("RoleList")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("RoleListLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.RoleName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<RoleModuleAccessRight>(entity =>
        {
            entity
                .ToTable("RoleModuleAccessRight")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("RoleModuleAccessRightLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<SenderBankInfo>(entity =>
        {
            entity
                .ToTable("SenderBankInfo")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("SenderBankInfoLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.SenderBankCode).HasMaxLength(10);
            entity.Property(e => e.SenderCode).HasMaxLength(20);
            entity.Property(e => e.SenderMobile).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<SettlementBankAccount>(entity =>
        {
            entity.ToTable("SettlementBankAccount");

            entity.Property(e => e.AccountName).HasMaxLength(255);
            entity.Property(e => e.AccountNumber).HasMaxLength(255);
            entity.Property(e => e.BankCode).HasMaxLength(4);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OwnerId).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.WalletAddress).HasMaxLength(100);
        });

        modelBuilder.Entity<SettlementFeeSetting>(entity =>
        {
            entity
                .ToTable("SettlementFeeSetting")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("SettlementFeeSettingtLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.AccountProviderCode).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.SettlementFeePercent).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.SettlementFeeType).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<SettlementRequest>(entity =>
        {
            entity
                .ToTable("SettlementRequest")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("SettlementRequestLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.HasIndex(e => e.DsMasterId, "IX_SettlementRequest_DS_MasterId");

            entity.HasIndex(e => e.OwnerId, "IX_SettlementRequest_OwnerId");

            entity.HasIndex(e => e.RequestedTo, "IX_SettlementRequest_RequestedTo");

            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DsMasterId).HasColumnName("DS_MasterId");
            entity.Property(e => e.IpAddress).HasMaxLength(500);
            entity.Property(e => e.OriAvailableBalance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.OwnerName).HasMaxLength(50);
            entity.Property(e => e.RefId)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.RequestedAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.SettlementFee).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.StatementRemark).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(5);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIpAddress).HasMaxLength(500);
        });

        modelBuilder.Entity<SettlementSetting>(entity =>
        {
            entity.ToTable("SettlementSetting");

            entity.Property(e => e.SettlementFeeInr)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("SettlementFeeINR");
            entity.Property(e => e.SettlementFeeMyr)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("SettlementFeeMYR");
            entity.Property(e => e.SettlementFeeThb)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("SettlementFeeTHB");
            entity.Property(e => e.SettlementFeeVnd)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("SettlementFeeVND");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<SmsforwardBankInfo>(entity =>
        {
            entity.ToTable("SMSForwardBankInfo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Command).HasMaxLength(1000);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubAccount>(entity =>
        {
            entity.ToTable("SubAccount");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedIP");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.LastLoginIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastLoginIP");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.ParentUsername).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<SubAccountAccessRight>(entity =>
        {
            entity
                .ToTable("SubAccountAccessRight")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("SubAccountAccessRightLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<TableA>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TableB>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableB");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TempInUsedPhone>(entity =>
        {
            entity.ToTable("TempInUsedPhone");

            entity.Property(e => e.BankAccount).HasMaxLength(250);
            entity.Property(e => e.BankScanServerIp)
                .HasMaxLength(250)
                .HasColumnName("BankScanServerIP");
            entity.Property(e => e.BankScanServerName).HasMaxLength(250);
            entity.Property(e => e.CreatedDateMy)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("CreatedDateMY");
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.ManualEnabledAp)
                .HasMaxLength(3)
                .HasColumnName("ManualEnabledAP");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Product).HasMaxLength(25);
            entity.Property(e => e.RetryCount).HasMaxLength(3);
            entity.Property(e => e.RetrySame).HasMaxLength(3);
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

        modelBuilder.Entity<TestModeMerchant>(entity =>
        {
            entity.ToTable("TestModeMerchant");

            entity.Property(e => e.MerchantCode).HasMaxLength(20);
            entity.Property(e => e.Product).HasMaxLength(20);
            entity.Property(e => e.UpdatedDateMy)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("UpdatedDateMY");
        });

        modelBuilder.Entity<TestSample>(entity =>
        {
            entity.ToTable("TestSample");

            entity.Property(e => e.Test)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestSpDateRange>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Test_SP_DateRange");

            entity.Property(e => e.FromDate).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Spname)
                .HasMaxLength(200)
                .HasColumnName("SPName");
            entity.Property(e => e.ToDate).HasMaxLength(50);
        });

        modelBuilder.Entity<TierSetting>(entity =>
        {
            entity
                .ToTable("TierSetting")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("TierSettingLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.From).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MdrtierSettingId).HasColumnName("MDRTierSettingId");
            entity.Property(e => e.Rate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.To).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<TraceLog>(entity =>
        {
            entity.HasKey(e => e.Index);

            entity.ToTable("TraceLog");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Fi)
                .HasMaxLength(50)
                .HasColumnName("FI");
            entity.Property(e => e.Field).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.PayeeId)
                .HasMaxLength(50)
                .HasColumnName("PayeeID");
        });

        modelBuilder.Entity<TransactionOverrideLog>(entity =>
        {
            entity.ToTable("TransactionOverrideLog");

            entity.Property(e => e.Action).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedIP");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.InvoiveNo).HasMaxLength(25);
            entity.Property(e => e.Message).HasMaxLength(255);
        });

        modelBuilder.Entity<TransactionSummary>(entity =>
        {
            entity.ToTable("TransactionSummary");

            entity.Property(e => e.Balance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayinTotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayinTotalFee).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutTotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutTotalFee).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.QrtotalAmount)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("QRTotalAmount");
            entity.Property(e => e.QrtotalFee)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("QRTotalFee");
        });

        modelBuilder.Entity<TransactionSummaryAll>(entity =>
        {
            entity.ToTable("TransactionSummaryAll");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TotalFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TranDate).HasColumnType("date");
            entity.Property(e => e.Username).HasMaxLength(20);
        });

        modelBuilder.Entity<TransactionSummaryAllSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransactionSummarySettingV2");

            entity.ToTable("TransactionSummaryAllSetting");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastRunDate).HasColumnType("date");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<TransactionSummaryDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransactionSummaryDetailsV2");

            entity.HasIndex(e => e.AccountLevel, "TransactionSummaryDetails_AccountLevel");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TotalFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Username).HasMaxLength(20);
        });

        modelBuilder.Entity<TransactionSummaryJob>(entity =>
        {
            entity.ToTable("TransactionSummaryJob");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.MerchantCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RerunSummaryDate).HasColumnType("date");
        });

        modelBuilder.Entity<TransactionSummaryJobAll>(entity =>
        {
            entity.ToTable("TransactionSummaryJobAll");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.IsUpdate).HasColumnName("isUpdate");
            entity.Property(e => e.RerunSummaryDate).HasColumnType("date");
            entity.Property(e => e.Username).HasMaxLength(20);
        });

        modelBuilder.Entity<TransactionSummaryNew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC079E00CA7D");

            entity.ToTable("TransactionSummaryNew");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Comcode)
                .HasMaxLength(20)
                .HasColumnName("COMCode");
            entity.Property(e => e.Comid).HasColumnName("COMId");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MasterFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Product)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TransDate).HasColumnType("date");
        });

        modelBuilder.Entity<TransactionSummaryNewDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC0790056537");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MasterCode).HasMaxLength(20);
            entity.Property(e => e.MerchantFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Product)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TransDate).HasColumnType("date");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransactionSummaryNewSubDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC078F1DA578");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Apfees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("APFees");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TransDate).HasColumnType("date");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransactionSummarySetting>(entity =>
        {
            entity.ToTable("TransactionSummarySetting");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<TransactionSummarySettingNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransactionSummarySettingNew");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastRunDate).HasColumnType("date");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransactionSummaryV2>(entity =>
        {
            entity.ToTable("TransactionSummaryV2");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountProviderCode).HasMaxLength(20);
            entity.Property(e => e.Aprate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("APRate");
            entity.Property(e => e.Balance).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ComRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DuitNowApcode)
                .HasMaxLength(20)
                .HasColumnName("DuitNowAPCode");
            entity.Property(e => e.DuitNowTotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.DuitNowTotalApfees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("DuitNowTotalAPFees");
            entity.Property(e => e.DuitNowTotalComFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.DuitNowTotalMasterFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.DuitNowTotalMerchantFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ManualApcode)
                .HasMaxLength(20)
                .HasColumnName("ManualAPCode");
            entity.Property(e => e.ManualPayinAprate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("ManualPayinAPRate");
            entity.Property(e => e.ManualPayinComRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ManualPayinMasterRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ManualPayinMerchantRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ManualPayinTotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ManualPayinTotalApfees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("ManualPayinTotalAPFees");
            entity.Property(e => e.ManualPayinTotalComFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ManualPayinTotalMasterFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ManualPayinTotalMerchantFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.MasterRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.MerchantRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.PayinApcode)
                .HasMaxLength(20)
                .HasColumnName("PayinAPCode");
            entity.Property(e => e.PayinAprate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("PayinAPRate");
            entity.Property(e => e.PayinComRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.PayinMasterRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.PayinMerchantRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.PayinTotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayinTotalApfees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PayinTotalAPFees");
            entity.Property(e => e.PayinTotalComFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayinTotalMasterFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayinTotalMerchantFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutApcode)
                .HasMaxLength(20)
                .HasColumnName("PayoutAPCode");
            entity.Property(e => e.PayoutAprate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("PayoutAPRate");
            entity.Property(e => e.PayoutComRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.PayoutMasterRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.PayoutMerchantRate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.PayoutTotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutTotalApfees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PayoutTotalAPFees");
            entity.Property(e => e.PayoutTotalComFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutTotalMasterFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PayoutTotalMerchantFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Platform).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.PromptPayApcode)
                .HasMaxLength(20)
                .HasColumnName("PromptPayAPCode");
            entity.Property(e => e.PromptPayTotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PromptPayTotalApfees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PromptPayTotalAPFees");
            entity.Property(e => e.PromptPayTotalComFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PromptPayTotalMasterFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.PromptPayTotalMerchantFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Qraprate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("QRAPRate");
            entity.Property(e => e.QrcomRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("QRComRate");
            entity.Property(e => e.QrmasterRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("QRMasterRate");
            entity.Property(e => e.QrmerchantRate)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("QRMerchantRate");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TotalApfees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("TotalAPFees");
            entity.Property(e => e.TotalComFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TotalMasterFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TotalMerchantFees).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Upiapcode)
                .HasMaxLength(20)
                .HasColumnName("UPIAPCode");
            entity.Property(e => e.UpitotalAmount)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("UPITotalAmount");
            entity.Property(e => e.UpitotalApfees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("UPITotalAPFees");
            entity.Property(e => e.UpitotalComFees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("UPITotalComFees");
            entity.Property(e => e.UpitotalMasterFees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("UPITotalMasterFees");
            entity.Property(e => e.UpitotalMerchantFees)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("UPITotalMerchantFees");
            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.Utcdate).HasColumnName("UTCDate");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C139E301B");

            entity.HasIndex(e => e.UserName, "IDX_UserName");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.Application).WithMany(p => p.Users)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("User_Application");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UsersInRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("UsersInRole_Role"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("UsersInRole_User"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__UsersInR__AF2760AD58F33E13");
                        j.ToTable("UsersInRoles");
                    });
        });

        modelBuilder.Entity<User2Fa>(entity =>
        {
            entity
                .ToTable("User2FA")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("User2FALog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.IsEnable2Fa).HasColumnName("IsEnable2FA");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<UserCommisionInfoPayOut>(entity =>
        {
            entity
                .ToTable("UserCommisionInfo_PayOut")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("UserCommisionInfo_PayOutLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Commision).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<UserCurrency>(entity =>
        {
            entity
                .ToTable("UserCurrency")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("UserCurrencyLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TimeZoneHour).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<UserIdBlock>(entity =>
        {
            entity
                .ToTable("UserIdBlock")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("UserIdBlockLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Comment).HasMaxLength(250);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.MerchantName).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<UserList>(entity =>
        {
            entity.ToTable("UserList");

            entity.Property(e => e.AccountLevel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.ConfigMdr).HasColumnName("ConfigMDR");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CreatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedIP");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.Platform)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
            entity.Property(e => e.UserStatus)
                .HasDefaultValueSql("((1))")
                .HasComment("0 = Inactive, 1 = Active, 2 = Suspended");
            entity.Property(e => e.Username).HasMaxLength(20);
        });

        modelBuilder.Entity<UserLogo>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_UserLogo_1");

            entity.ToTable("UserLogo");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.DomainUrl).HasMaxLength(250);
            entity.Property(e => e.FooterLogoUrl).HasMaxLength(250);
            entity.Property(e => e.LogoUrl).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<UserMdrinfo>(entity =>
        {
            entity
                .ToTable("UserMDRInfo")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("UserMDRInfoLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Mdr)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MDR");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<UserMdrinfo20200115>(entity =>
        {
            entity
                .ToTable("UserMDRInfo_20200115")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("UserMDRInfoLog_20200115", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Mdr)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MDR");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<UserMdrinfoBk>(entity =>
        {
            entity.ToTable("UserMDRInfo_BK");

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Mdr)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MDR");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<UserMdrinfoPayOut>(entity =>
        {
            entity
                .ToTable("UserMDRInfo_PayOut")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("UserMDRInfo_PayOutLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Mdr)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("MDR");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UpdatedIP");
        });

        modelBuilder.Entity<UserSiteConfig>(entity =>
        {
            entity.ToTable("UserSiteConfig");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(250);
            entity.Property(e => e.Data).HasMaxLength(255);
            entity.Property(e => e.Help).HasMaxLength(250);
            entity.Property(e => e.LastUpdated)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(20);
            entity.Property(e => e.Public).HasMaxLength(1);
            entity.Property(e => e.SubType).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<UserTelegramGroup>(entity =>
        {
            entity.HasKey(e => e.Username);

            entity.ToTable("UserTelegramGroup");

            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.AccountLevel).HasMaxLength(10);
            entity.Property(e => e.TelegramGroupId).HasMaxLength(50);
        });

        modelBuilder.Entity<UserTransactionLimit>(entity =>
        {
            entity
                .ToTable("UserTransactionLimit")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("UserTransactionLimitLog", "dbo");
                        ttb
                            .HasPeriodStart("CreatedDate")
                            .HasColumnName("CreatedDate");
                        ttb
                            .HasPeriodEnd("UpdatedDate")
                            .HasColumnName("UpdatedDate");
                    }));

            entity.HasIndex(e => e.UserId, "idx_UserId");

            entity.Property(e => e.BeneficiaryLimit).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MaxTransaction).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.MinTransaction).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<VinDeadlock>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vin_deadlock");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
