namespace FirstWebMVC.Controllers
{
    using FirstWebMvc.Data;
    using FirstWebMVC.Models.Entities;
    using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
    using SQLitePCL;

    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context)
        {
           _context=context ;
        }


        public  async Task <IActionResult> Index()
        {
            return View(await _context.Person.ToListAsync());
        }
         public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.FullName == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        public IActionResult Create()
        {
            return View();
        }
[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,Adress")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
        
    }
}