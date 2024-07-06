using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.DataAccess;
using BusinessObject.Models;

namespace FStore.Pages.MemberPage
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.DataAccess.Ass01Context _context;

        public IndexModel(BusinessObject.DataAccess.Ass01Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Members != null)
            {
                Member = await _context.Members.ToListAsync();
            }
        }
    }
}
