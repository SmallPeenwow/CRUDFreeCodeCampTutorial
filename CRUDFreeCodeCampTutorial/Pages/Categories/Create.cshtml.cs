using CRUDFreeCodeCampTutorial.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDFreeCodeCampTutorial.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }

        public void OnGet()
        {
        }
    }
}
