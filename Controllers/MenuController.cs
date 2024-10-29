using Microsoft.AspNetCore.Mvc;
using WebNhaHang.Models;

namespace WebNhaHang.Controllers
{
    public class MenuController : Controller
    {
        private readonly DBNhaHangContext _context;
        public MenuController(DBNhaHangContext context)
        {
            _context = context;
        }

        public IActionResult Menu()
        {
            var menu = _context.Menus.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(menu);
        }
        public IActionResult ChiTietSanPham(int id)
        {
            var menu = _context.Menus.FirstOrDefault(p => p.Dish_ID == id);
            if (menu == null)
            {
                return NotFound();
            }
            return View(menu);
        }
    }
}
