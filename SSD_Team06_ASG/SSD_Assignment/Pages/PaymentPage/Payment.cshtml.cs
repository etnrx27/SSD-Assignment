using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSD_Assignment.Models;

namespace SSD_Assignment.Pages.PaymentPage
{
    public class PaymentModel : PageModel
    {
        private readonly SSD_Assignment.Data.SSD_AssignmentContext _context;

        public PaymentModel(SSD_Assignment.Data.SSD_AssignmentContext context)
        {
            _context = context;
        }
       [BindProperty]
        public Payment Payment { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Payment.Add(Payment);
            await _context.SaveChangesAsync();
            return RedirectToPage("./PaymentSuccess");
        }
    }
}
