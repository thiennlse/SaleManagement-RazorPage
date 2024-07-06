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
    public class DetailsModel : PageModel
    {
        private readonly IOrderRepo _repo;

        private readonly IOrderDetailRepo _detailRepo;

        public DetailsModel(IOrderRepo _context, IOrderDetailRepo _detail)
        {
            _repo = _context;
            _detailRepo = _detail;
        }

      public OrderDetail OrderDetail { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _detailRepo.GetOrderDetail(id) == null)
            {
                return NotFound();
            }

            var order = _detailRepo.GetOrderDetail(id);
            if (order == null)
            {
                return NotFound();
            }
            else 
            {
                OrderDetail = order;
            }
            return Page();
        }
    }
}
