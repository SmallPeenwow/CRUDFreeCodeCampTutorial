using CRUDFreeCodeCampTutorial.Data;
using CRUDFreeCodeCampTutorial.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDFreeCodeCampTutorial.Pages.Categories
{
    // [BindProperties] Top Level binding
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                // Binds to property that matches key name
                ModelState.AddModelError("Category.Name", "The Display Order cannot exactly match the Name.");
            }

            if (ModelState.IsValid)
            {
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();

                TempData["success"] = "Category created successfully";

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
