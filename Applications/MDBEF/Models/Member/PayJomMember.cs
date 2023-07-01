namespace MDBEF.Models.Member
{
    public class PayJomMember
    {
        public long MemberLoginId { get; set; }

        public string? UserId { get; set; }

        public DateTime? LoginTime { get; set; }

        public string? LoginIp { get; set; }

        public long? MemberId { get; set; }

        public bool? IsSubAccoun { get; set; }

        public string? SessionId { get; set; }
    }
}
