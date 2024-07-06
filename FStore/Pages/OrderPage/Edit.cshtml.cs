using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.DataAccess;
using BusinessObject.Models;
using Repository;

namespace FStore.Pages.OrderPage
{
    public class EditModel : PageModel
    {
        private readonly IOrderDetailRepo _repo;

        public EditModel(IOrderDetailRepo _context)
        {
            _repo = _context;
        }

        [BindProperty]
        public OrderDetail OrderDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _repo.GetOrderDetail(id) == null)
            {
                return NotFound();
            }

            var order =  _repo.GetOrderDetail(id);
            if (order == null)
            {
                return NotFound();
            }
            OrderDetail = order;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _repo.UpdateOrderDetail(OrderDetail.OderId, OrderDetail);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return RedirectToPage("./Index");
        }

    }
}
