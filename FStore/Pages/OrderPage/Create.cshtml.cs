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
using Microsoft.EntityFrameworkCore;

namespace FStore.Pages.OrderPage
{
    public class CreateModel : PageModel
    {
        private readonly IOrderRepo _repo;
        private readonly IProductRepo _productRepo;
        private readonly IMemberRepo _memberRepo;
        public CreateModel(IOrderRepo _context, IProductRepo productRepo, IMemberRepo memberRepo)
        {
            _repo = _context;
            _productRepo = productRepo;
            _memberRepo = memberRepo;
        }

        public IActionResult OnGet()
        {
            int? id = HttpContext.Session.GetInt32("MemberId");

            
            return Page();

            
        }

        [BindProperty]
        public Order Order { get; set; } = default!; 



        public async Task<IActionResult> OnPostAsync()
        {

          if ( Order == null)
            {
                return Page();
            }

            _repo.AddOrder(Order);  
            return RedirectToPage("./Index");
        }
    }
}
