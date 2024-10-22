using Microsoft.AspNetCore.Mvc;
using WebNhaHang.Models;

namespace WebNhaHang.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DBNhaHangContext _context;
        public CustomerController(DBNhaHangContext context)
        {
            _context = context;
        }

        //Danh sách khách hàng
        public IActionResult ListCustomer(string searchString)
        {
            var customers = from c in _context.Customers select c;

            //Search khách hàng
            if (!string.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(c => c.FullName.Contains(searchString));
            }
            return View(customers.ToList());
        }

        //Thêm khách hàng
        public IActionResult Create()
        {
            return View();
        }

        //Thêm khách hàng mới
        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListCustomer));
            }
            return View(customer);
        }

        //Edit
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound("Không tìm thấy khách hàng");
            }
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        //Edit
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Customer customer)
        {
            if (id != customer.Customer_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListCustomer));
            }
            return View(customer);
        }

        //Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // Xóa khách hàng khỏi cơ sở dữ liệu
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListCustomer));

        }
    }
}
