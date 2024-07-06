using BusinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;

namespace FStore.Pages
{
    public class LoginPageModel : PageModel
    {
        private readonly IMemberRepo _memberRepo;

        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }  

        public LoginPageModel(IMemberRepo memberRepo)
        {
            _memberRepo = memberRepo;
        }

        public void OnGet()
        {
        }

        public void OnPost() 
        {
            
            Member member = _memberRepo.GetMember(Email, Password);
            if (member != null)
            {
                HttpContext.Session.SetString("Email", Email);
                HttpContext.Session.SetInt32("MemberId", member.MemberId);
                Response.Redirect("Index");
            }
        }

    }
}
