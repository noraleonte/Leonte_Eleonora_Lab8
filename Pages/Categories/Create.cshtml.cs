using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Leonte_Eleonora_Lab8.Data;
using Leonte_Eleonora_Lab8.Models;

namespace Leonte_Eleonora_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Leonte_Eleonora_Lab8.Data.Leonte_Eleonora_Lab8Context _context;

        public CreateModel(Leonte_Eleonora_Lab8.Data.Leonte_Eleonora_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookID"] = new SelectList(_context.Book, "ID", "ID");
        ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public BookCategory BookCategory { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookCategory.Add(BookCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
