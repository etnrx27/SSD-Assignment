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

namespace SSD_Assignment.Pages.Audit
{
    [Authorize(Roles="Admin,AuditAdmin")]
    public class DetailsModel : PageModel
    {
        private readonly SSD_Assignment.Data.SSD_AssignmentContext _context;

        public DetailsModel(SSD_Assignment.Data.SSD_AssignmentContext context)
        {
            _context = context;
        }

        public AuditRecord AuditRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AuditRecord = await _context.AuditRecords.FirstOrDefaultAsync(m => m.Audit_ID == id);

            if (AuditRecord == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
