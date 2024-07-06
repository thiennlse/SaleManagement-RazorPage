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
    public class IndexModel : PageModel
    {
        private readonly IProductRepo _repo;

        public IndexModel(IProductRepo _context)
        {
            _repo = _context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_repo.GetProducts != null)
            {
                Product = _repo.GetProducts();
            }
        }
    }
}
