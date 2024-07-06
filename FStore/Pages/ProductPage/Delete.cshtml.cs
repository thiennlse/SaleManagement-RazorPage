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

namespace FStore.Pages.ProductPage
{
    public class DeleteModel : PageModel
    {
        private readonly IProductRepo _repo;

        public DeleteModel(IProductRepo _context)
        {
            _repo = _context;
        }

        [BindProperty]
      public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _repo.GetProducts == null)
            {
                return NotFound();
            }

            var product = _repo.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (id == null || _repo.GetProduct(id) == null)
            {
                return NotFound();
            }
            var product = _repo.GetProduct(id);

            if (product != null)
            {
                Product = product;
                _repo.DeleteProduct(id);
            }

            return RedirectToPage("./Index");
        }
    }
}
