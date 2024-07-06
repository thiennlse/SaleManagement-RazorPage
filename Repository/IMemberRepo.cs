using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IMemberRepo
    {
        public Member GetMember(string email , string password);

        public void AddMember(Member member);
    }
}
