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
    public class DetailsModel : PageModel
    {
        private readonly FizzBuzz_WebApp.Data.FBContext _context;

        public DetailsModel(FizzBuzz_WebApp.Data.FBContext context)
        {
            _context = context;
        }

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
    }
}
