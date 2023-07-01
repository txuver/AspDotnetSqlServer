using DA.Accounting;
using DA.PayJom;
using MDBEF.Models.Member;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Numerics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MDBEF.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly ILogger<MemberController> _logger;
        private readonly AccountingDbContext _accountingDbContext;
        private readonly PayJomDbContext _payJomDbContext;

        public MemberController(ILogger<MemberController> logger, AccountingDbContext accountingDbContext, PayJomDbContext payJomDbContext)
        {
            _logger = logger;
            _accountingDbContext = accountingDbContext;
            _payJomDbContext = payJomDbContext;
        }

        [HttpPost]
        public async Task<AccountingMember?> GetAccountingMember(MemberRequest request)
        {
            var query = await _accountingDbContext.Members.Where(acc => acc.Username == request.Username).FirstOrDefaultAsync();
            if (query == null)
            {
                return null;
            }

            var result = new AccountingMember()
            {
                Id = query.Id,
                Username = query.Username,
                Password = query.Password,
                Email = query.Email,
                Phone = query.Phone,
                Status = query.Status,
                CreatedBy = query.CreatedBy,
                CreatedDate = query.CreatedDate,
                UpdatedBy = query.UpdatedBy,
                UpdatedDate = query.UpdatedDate
            };
            return result;
        }

        [HttpPost]
        public async Task<IEnumerable<AccountingMember>> GetAccountingMembers()
        {
            var result = new List<AccountingMember>();
            var query = await _accountingDbContext.Members.ToListAsync();
            foreach (var item in query)
            {
                result.Add(new AccountingMember()
                {
                    Id = item.Id,
                    Username = item.Username,
                    Password = item.Password,
                    Email = item.Email,
                    Phone = item.Phone,
                    Status = item.Status,
                    CreatedBy = item.CreatedBy,
                    CreatedDate = item.CreatedDate,
                    UpdatedBy = item.UpdatedBy,
                    UpdatedDate = item.UpdatedDate
                });
            }
            return result;
        }

        [HttpPost]
        public async Task<IEnumerable<PayJomMember>> GetPayJomMemberLogin()
        {
            var result = new List<PayJomMember>();
            var query = await _payJomDbContext.MemberLogins.ToListAsync();
            foreach (var item in query)
            {
                result.Add(new PayJomMember()
                {
                    MemberLoginId = item.MemberLoginId,
                    UserId = item.UserId,
                    LoginTime = item.LoginTime,
                    LoginIp = item.LoginIp,
                    MemberId = item.MemberId,
                    IsSubAccoun = item.IsSubAccoun,
                    SessionId = item.SessionId
                });
            }
            return result;
        }

        [HttpPost]
        public async Task<IEnumerable<AccountingPayJomMember>> GetAccoutingPayJomMemberLogin(MemberRequest request)
        {
            var result = new List<AccountingPayJomMember>();
            // Cannot use multiple context instances within a single query execution. Ensure the query uses a single context instance.
            var query = _payJomDbContext.MemberLogins.ToList()
                .Join(_accountingDbContext.Members.ToList(), payJom => payJom.UserId, acc => acc.Username,
                    (payJom, acc) => new AccountingPayJomMember()
                    {
                        UserId = payJom.UserId,
                        LoginTime = payJom.LoginTime,
                        LoginIp = payJom.LoginIp,
                        MemberId = payJom.MemberId,
                        IsSubAccoun = payJom.IsSubAccoun,
                        SessionId = payJom.SessionId,
                        Username = acc.Username,
                        Password = acc.Password,
                        Email = acc.Email,
                        Phone = acc.Phone,
                        Status = acc.Status,
                        MemberLoginId = payJom.MemberLoginId,
                    });

            // filter by username
            if(!string.IsNullOrEmpty(request?.Username))
            {
                query = query.Where(q => q.Username == request?.Username);
            }

            foreach (var item in query)
            {
                result.Add(new AccountingPayJomMember()
                {
                    Username = item.Username,
                    Password = item.Password,
                    Email = item.Email,
                    Phone = item.Phone,
                    Status = item.Status,
                    MemberLoginId = item.MemberLoginId,
                    UserId = item.UserId,
                    LoginTime = item.LoginTime,
                    LoginIp = item.LoginIp,
                    MemberId = item.MemberId,
                    IsSubAccoun = item.IsSubAccoun,
                    SessionId = item.SessionId
                });
            }

            return result;
        }

        [HttpPost]
        public async Task<bool> UpdateAccountingMember(AccountingMember request)
        {
            var member = await _accountingDbContext.Members.FindAsync(request.Id);
            if(member == null)
            {
                return false;
            }

            member.Id = request.Id;
            member.Username = request.Username;
            member.Email = request.Email;
            member.Phone = request.Phone;
            member.Status = request.Status;
            member.CreatedBy = request.CreatedBy;
            member.CreatedDate = request.CreatedDate;
            member.UpdatedBy = request.UpdatedBy;
            member.UpdatedDate = request.UpdatedDate;

            await _accountingDbContext.SaveChangesAsync();

            return true;
        }
    }
}
