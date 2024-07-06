using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject.DataAccess;
using BusinessObject.Models;
using Repository;

namespace FStore.Pages.ProductPage
{
    public class CreateModel : PageModel
    {
        private readonly IProductRepo _repo;

        public CreateModel(IProductRepo _context)
        {
            _repo = _context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || Product == null)
            {
                return Page();
            }

            _repo.AddProduct(Product);

            return RedirectToPage("./Index");
        }
    }
}
