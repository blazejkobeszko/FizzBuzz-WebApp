using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz_WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FizzBuzz_WebApp.Pages
{
    public class OstatnioSzukaneModel : PageModel
    {
        public Main Info_sesji { get; set; }
        public void OnGet()
        {

            var Session = HttpContext.Session.GetString("SessionAddress");
            if (Session != null)
                Info_sesji = JsonConvert.DeserializeObject<Main>(Session);
        }
    }
}
