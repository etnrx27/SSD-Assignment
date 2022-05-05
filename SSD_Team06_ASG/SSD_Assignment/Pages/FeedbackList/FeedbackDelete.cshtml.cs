using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SSD_Assignment.Data;
using SSD_Assignment.Models;
using Microsoft.AspNetCore.Authorization;

namespace RazorPagesBook.Pages.FeedbackList
{
    [Authorize(Roles = "Admin,FeedbackAdmin")]
    public class DeleteModel : PageModel
    {
        private readonly SSD_Assignment.Data.SSD_AssignmentContext _context;

        public DeleteModel(SSD_Assignment.Data.SSD_AssignmentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Feedback Feedback { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Feedback = await _context.Feedback.FirstOrDefaultAsync(m => m.ID == id);

            if (Feedback == null)
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

            Feedback = await _context.Feedback.FindAsync(id);

            if (Feedback != null)
            {
                _context.Feedback.Remove(Feedback);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Feedback");
        }
    }   
}
