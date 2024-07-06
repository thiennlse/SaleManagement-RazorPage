using BusinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace FStore.Pages
{
    public class RegisterPageModel : PageModel
    {
        private readonly IMemberRepo _memberRepo;

        public RegisterPageModel(IMemberRepo memberRepo)
        {
            _memberRepo = memberRepo;
        }

        [BindProperty]
        public Member Member { get; set; } = default!;

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || Member == null)
            {
                return Page();
            }

            _memberRepo.AddMember(Member);

            return RedirectToPage("LoginPage");
        }
    }
}
