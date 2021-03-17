using EMF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMF.Controllers
{
    public class VersesController : Controller
    {      
        public async Task<IActionResult> Index(IFormCollection fc)
        {

            string sd = fc["StartDate"];
            string nv = fc["NumVerses"];

            ViewData["verseDate"] = formatDate(sd); 

            var verseModel = new VerseModel();
      
            var verses = await verseModel.GetVersesAsync(sd, nv);

            return View(verses);
        }



        private string formatDate(string d)
        {
            var sb = new StringBuilder();

            var parts = d.Split("-");
            sb.Append(parts[1]);
            sb.Append("-");
            sb.Append(parts[2]);
            sb.Append("-");
            sb.Append(parts[0]);

            return sb.ToString();       
        }
    }
}
