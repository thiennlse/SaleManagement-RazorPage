using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MemberRepo : IMemberRepo
    {
        public void AddMember(Member member) => MemberDAO.Instance.AddMember(member);

        public Member GetMember(string email, string password) => MemberDAO.Instance.GetMember(email, password);
    }
}
