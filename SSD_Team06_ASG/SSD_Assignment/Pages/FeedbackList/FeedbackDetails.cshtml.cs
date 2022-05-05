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
    public class FeedbackDetailsModel : PageModel
    {
        private readonly SSD_Assignment.Data.SSD_AssignmentContext _context;

        public FeedbackDetailsModel(SSD_Assignment.Data.SSD_AssignmentContext context)
        {
            _context = context;
        }

        public Feedback Feedback { get; set; }
        public IList<Feedback> FeedbackList { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var feedback = from f in _context.Feedback select f;
            FeedbackList = await feedback.ToListAsync();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            return Redirect("./Feedback");
        }
    }
}
