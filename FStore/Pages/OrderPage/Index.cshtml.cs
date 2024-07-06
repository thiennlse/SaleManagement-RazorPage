using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.DataAccess;
using BusinessObject.Models;
using Repository;

namespace FStore.Pages.OrderPage
{
    public class IndexModel : PageModel
    {
        private readonly IOrderRepo _repo;
        private readonly IMemberRepo _memberRepo;

        public IndexModel(IOrderRepo _context)
        {
            _repo = _context;
        }

        public List<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if(_repo.GetOrders != null)
            {
                Order = _repo.GetOrders();
            }
        }
    }
}
