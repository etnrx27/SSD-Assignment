using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSD_Assignment.Models;
using Microsoft.AspNetCore.Authorization;

namespace SSD_Assignment.Pages.FeedbackList
{
    public class FeedbackThankYouModel : PageModel
    {
        private readonly SSD_Assignment.Data.SSD_AssignmentContext _context;

        public FeedbackThankYouModel(SSD_Assignment.Data.SSD_AssignmentContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Feedback Feedback { get; set; }
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
            Feedback.Date = DateTime.Now;
            _context.Feedback.Add(Feedback);
            await _context.SaveChangesAsync();
            return RedirectToPage("./FeedbackThankYou");
        }
    }
}
