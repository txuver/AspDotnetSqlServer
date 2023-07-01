using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DA.Accounting;

public partial class AccountingDbContext : DbContext
{
    public AccountingDbContext()
    {
    }

    public AccountingDbContext(DbContextOptions<AccountingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<BankAccountBalance> BankAccountBalances { get; set; }

    public virtual DbSet<BankStatement> BankStatements { get; set; }

    public virtual DbSet<BankStatementRemark> BankStatementRemarks { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<PagePermission> PagePermissions { get; set; }

    public virtual DbSet<UserActionLog> UserActionLogs { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.ToTable("BankAccount");

            entity.Property(e => e.AccountName).HasMaxLength(225);
            entity.Property(e => e.Bank).HasMaxLength(255);
            entity.Property(e => e.BankType).HasDefaultValueSql("((1))");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.IsEnterprise).HasDefaultValueSql("((0))");
            entity.Property(e => e.Password).HasMaxLength(255);
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
            entity.Property(e => e.SecureQuestion1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecureQuestion2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecureQuestion3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<BankAccountBalance>(entity =>
        {
            entity.ToTable("BankAccountBalance");

            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.PjbankId).HasColumnName("PJBankID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<BankStatement>(entity =>
        {
            entity.ToTable("BankStatement");

            entity.HasIndex(e => e.TransactionDate, "IX_BankStatement_TransactionDate");

            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankAccountNo).HasMaxLength(20);
            entity.Property(e => e.BankCode).HasMaxLength(10);
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.InvoiceNo).HasMaxLength(25);
            entity.Property(e => e.LoginUsername).HasMaxLength(20);
            entity.Property(e => e.RedisKey).HasMaxLength(150);
        });

        modelBuilder.Entity<BankStatementRemark>(entity =>
        {
            entity.ToTable("BankStatementRemark");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable("Group");

            entity.Property(e => e.GroupDesc).HasMaxLength(500);
            entity.Property(e => e.GroupName).HasMaxLength(500);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserList");

            entity.ToTable("Member");

            entity.Property(e => e.BankServiceType).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Currency).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Lang).HasMaxLength(50);
            entity.Property(e => e.LastLoginIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastLoginIP");
            entity.Property(e => e.MemberRole).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.SafeCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<PagePermission>(entity =>
        {
            entity.ToTable("PagePermission");

            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.PageCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
        });

        modelBuilder.Entity<UserActionLog>(entity =>
        {
            entity.ToTable("UserActionLog");

            entity.Property(e => e.FromUser).HasMaxLength(50);
            entity.Property(e => e.Ip).HasMaxLength(255);
            entity.Property(e => e.ToUser).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
