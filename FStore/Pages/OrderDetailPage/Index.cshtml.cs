using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.DataAccess;
using BusinessObject.Models;

namespace FStore.Pages.OrderDetailPage
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.DataAccess.Ass01Context _context;

        public IndexModel(BusinessObject.DataAccess.Ass01Context context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.OrderDetails != null)
            {
                OrderDetail = await _context.OrderDetails
                .Include(o => o.Oder)
                .Include(o => o.Product).ToListAsync();
            }
        }
    }
}
