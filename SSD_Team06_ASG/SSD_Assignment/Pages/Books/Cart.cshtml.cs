using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace SSD_Assignment.Pages.Books
{
    public class CartModel : PageModel
    {
        private readonly SSD_Assignment.Data.SSD_AssignmentContext _context;

        public CartModel(SSD_Assignment.Data.SSD_AssignmentContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
    }
}
