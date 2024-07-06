using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;

namespace FStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMemberRepo _memberRepo;

        public IndexModel(IMemberRepo repo)
        {
            _memberRepo = repo;
        }

        public void OnGet()
        {
            HttpContext.Session.GetString("Email");
        }
    }
}