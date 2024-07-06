using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject.DataAccess;
using BusinessObject.Models;

namespace FStore.Pages.OrderDetailPage
{
    public class CreateModel : PageModel
    {
        private readonly BusinessObject.DataAccess.Ass01Context _context;

        public CreateModel(BusinessObject.DataAccess.Ass01Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OderId"] = new SelectList(_context.Orders, "OrderId", "OrderId");
        ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName");
            return Page();
        }

        [BindProperty]
        public OrderDetail OrderDetail { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.OrderDetails == null || OrderDetail == null)
            {
                return Page();
            }

            _context.OrderDetails.Add(OrderDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
