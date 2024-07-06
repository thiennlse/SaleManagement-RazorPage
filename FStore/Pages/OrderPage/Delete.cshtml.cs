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
    public class DeleteModel : PageModel
    {
        private readonly IOrderRepo _repo;
        public DeleteModel(IOrderRepo _context)
        {
            _repo = _context;
        }

        [BindProperty]
      public Order Order { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _repo.GetOrders == null)
            {
                return NotFound();
            }

            var order = _repo.getOrder(id);

            if (order == null)
            {
                return NotFound();
            }
            else 
            {
                Order = order;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (id == null || _repo.GetOrders == null)
            {
                return NotFound();
            }

            _repo.DeleteOrder(id);
            return RedirectToPage("./Index");
        }
    }
}
