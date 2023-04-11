using CodeFirstProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstProject.Pages.Employees
{
    public class ReadModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;
        public List<Employee> Employees { get; set; }


        public ReadModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet()
        {
            Employees = this.dbContext.Employees.ToList();
        }
    }
}
