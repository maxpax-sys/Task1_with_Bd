using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task1_withBd.Models; 
namespace Task1_withBd.Controllers
{
    public class HomeController : Controller
    {
        private AppoContext db;
        public HomeController(AppoContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Guests.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Guest guest)
        {
            db.Guests.Add(guest);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}