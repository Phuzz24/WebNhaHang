using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebNhaHang.Models;
using System.Data;

namespace WebNhaHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBNhaHangContext _database;

        public HomeController(DBNhaHangContext database)
        {
            _database = database;
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult TrangChu()
        {
            var gaMenu = _database.Menus
     .Where(p => p.Brand_ID == 1 && p.DishName != null && p.DishImage != null)
     .ToList();

            var boMenu = _database.Menus
                .Where(p => p.Brand_ID == 2 && p.DishName != null && p.DishImage != null)
                .ToList();

            var heoMenu = _database.Menus
                .Where(p => p.Brand_ID == 3 && p.DishName != null && p.DishImage != null)
                .ToList();

            var haisanMenu = _database.Menus
                .Where(p => p.Brand_ID == 4 && p.DishName != null && p.DishImage != null)
                .ToList();


            // Tạo danh sách các MenuBrandViewModel để truyền vào View
            var viewModel = new List<MenuBrandViewModel>
    {
        new MenuBrandViewModel
        {
            BrandName = "Món gà",
            Menus = gaMenu
        },
        new MenuBrandViewModel
        {
            BrandName = "Món bò",
            Menus = boMenu
        },
        new MenuBrandViewModel
        {
            BrandName = "Món heo",
            Menus = heoMenu
        },
        new MenuBrandViewModel
        {
            BrandName = "Hải sản",
            Menus = haisanMenu
        }

    };

            return View(viewModel);
        }


        public IActionResult ChiTietSanPham(int id)
        {
            var menu = _database.Menus.FirstOrDefault(p => p.Dish_ID == id);
            if (menu == null)
            {
                return NotFound();
            }
            return View(menu);
        }
    }
}
