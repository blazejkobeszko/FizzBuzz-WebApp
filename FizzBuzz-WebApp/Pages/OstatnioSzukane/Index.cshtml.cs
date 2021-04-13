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
    public class IndexModel : PageModel
    {
        private readonly FizzBuzz_WebApp.Data.FBContext _context;

        public IndexModel(FizzBuzz_WebApp.Data.FBContext context)
        {
            _context = context;
        }

        public IList<Main> Main { get;set; }

        public async Task OnGetAsync()
        {
            Main = await _context.FizzBuzzTable.OrderByDescending(x=>x.Data).Take(10).ToListAsync();
        }
    }
}
