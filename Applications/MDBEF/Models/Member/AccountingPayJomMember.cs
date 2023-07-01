namespace MDBEF.Models.Member
{
    public class AccountingPayJomMember
    {

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Phone { get; set; }

        public int Status { get; set; }
        public long MemberLoginId { get; set; }

        public string? UserId { get; set; }

        public DateTime? LoginTime { get; set; }

        public string? LoginIp { get; set; }

        public long? MemberId { get; set; }

        public bool? IsSubAccoun { get; set; }

        public string? SessionId { get; set; }
    }
}
