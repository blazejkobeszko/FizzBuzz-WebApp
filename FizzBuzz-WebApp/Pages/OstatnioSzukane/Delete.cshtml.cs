using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FizzBuzz_WebApp.Data;
using FizzBuzz_WebApp.Models;

namespace FizzBuzz_WebApp.Pages.OstatnioSzukane
{
    public class DeleteModel : PageModel
    {
        private readonly FizzBuzz_WebApp.Data.FBContext _context;

        public DeleteModel(FizzBuzz_WebApp.Data.FBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Main Main { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Main = await _context.FizzBuzzTable.FirstOrDefaultAsync(m => m.Id == id);

            if (Main == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Main = await _context.FizzBuzzTable.FindAsync(id);

            if (Main != null)
            {
                _context.FizzBuzzTable.Remove(Main);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
