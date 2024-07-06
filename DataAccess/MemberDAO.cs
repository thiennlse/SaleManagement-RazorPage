using BusinessObject.DataAccess;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private readonly Ass01Context _context;

        private static MemberDAO _instance;
        public MemberDAO() 
        {
            _context = new Ass01Context();  
        }

        public static MemberDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MemberDAO();
                }
                return _instance;
            }
        }

        public Member GetMember(string email,string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            return _context.Members.FirstOrDefault(n => n.Email.Equals(email));
        }

        public void AddMember(Member member)
        {
                _context.Members.Add(member);
                _context.SaveChanges();
        }
    }
}
