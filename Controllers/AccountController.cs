using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebNhaHang.Models;

namespace WebNhaHang.Controllers
{
    public class AccountController : Controller
    {
        private readonly DBNhaHangContext _context;

        public AccountController(DBNhaHangContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterPost()
        {
            try
            {
                // Lấy dữ liệu từ form
                string username = Request.Form["Username"];
                string email = Request.Form["Email"];
                string password = Request.Form["Password"];
                string confirmPassword = Request.Form["ConfirmPassword"];

                // Kiểm tra tính hợp lệ
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    ViewBag.Error = "Vui lòng nhập đầy đủ các thông tin!";
                    return View("Register");
                }

                if (password.Length < 6)
                {
                    ViewBag.Error = "Mật khẩu phải có ít nhất 6 ký tự!";
                    return View("Register");
                }

                if (password != confirmPassword)
                {
                    ViewBag.Error = "Mật khẩu và xác nhận mật khẩu không khớp!";
                    return View("Register");
                }

                // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
                if (existingUser != null)
                {
                    ViewBag.Error = "Tên đăng nhập đã tồn tại.";
                    return View("Register");
                }

                // Kiểm tra xem email đã tồn tại chưa
                var existingEmail = await _context.Customers.FirstOrDefaultAsync(c => c.Email == email);
                if (existingEmail != null)
                {
                    ViewBag.Error = "Email đã tồn tại.";
                    return View("Register");
                }

                // Tạo người dùng mới
                var user = new User
                {
                    Username = username,
                    Password = password,  // Không mã hóa mật khẩu
                    Role = "Khách hàng"
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                // Tạo bản ghi Customer
                var customer = new Customer
                {
                    User_ID = user.User_ID,
                    FullName = "Khách hàng chưa cập nhật", // Giá trị mặc định
                    Address = "Chưa có địa chỉ",       // Giá trị mặc định
                    PhoneNumber = "0000000000",              // Giá trị mặc định
                    Email = email                      // Sử dụng email từ form đăng ký
                };

                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Đăng ký thành công!";
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);  // Ghi log chi tiết lỗi ra console
                ViewBag.Error = $"Lỗi xảy ra: {ex.Message}";
                return View("Register");  // Trả lại view nếu có lỗi
            }


        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string Username, string Password)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ViewBag.Error = "Vui lòng nhập đầy đủ thông tin!";
                return View();
            }

            var user = _context.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);
            if (user != null)
            {
                // Lưu trạng thái đăng nhập vào Session
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetInt32("UserID", user.User_ID);

                // Chuyển hướng về trang chủ sau khi đăng nhập thành công
                return RedirectToAction("TrangChu", "Home");
            }
            else
            {
                ViewBag.Error = "Tên đăng nhập hoặc mật khẩu không chính xác.";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
        [HttpGet]
        public IActionResult EditInfo()
        {
            // Kiểm tra xem session có Username không
            var username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                return NotFound("Người dùng không tồn tại hoặc chưa đăng nhập.");
            }

            // Tìm người dùng trong cơ sở dữ liệu dựa trên Username
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                return NotFound("Không tìm thấy người dùng.");
            }

            // Tìm khách hàng liên kết với User
            var customer = _context.Customers.FirstOrDefault(c => c.User_ID == user.User_ID);

            // Nếu khách hàng chưa có thông tin, tạo đối tượng mới với giá trị trống để hiển thị
            if (customer == null)
            {
                customer = new Customer
                {
                    FullName = "Tên khách hàng mặc định", // Gán giá trị mặc định
                    Address = "Địa chỉ mặc định",    // Gán giá trị mặc định
                    PhoneNumber = "0000000000",             // Gán số điện thoại mặc định
                    Email = user.Username             // Sử dụng username làm email nếu chưa có thông tin
                };
            }
            else
            {
                // Kiểm tra và gán giá trị mặc định nếu có trường nào null
                customer.FullName = customer.FullName ?? "Tên khách hàng mặc định";
                customer.Address = customer.Address ?? "Địa chỉ mặc định";
                customer.PhoneNumber = customer.PhoneNumber ?? "0000000000";
                customer.Email = customer.Email ?? user.Username;
            }

            // Tạo view model để truyền dữ liệu tới view
            var model = new UserInfoViewModel
            {
                Username = user.Username, // Không cho chỉnh sửa
                NameCus = customer.FullName,
                AddressCus = customer.Address,
                PhoneCus = customer.PhoneNumber,
                EmailCus = customer.Email
            };

            return View(model);
        }



        [HttpPost]
        public IActionResult EditInfoPost(UserInfoViewModel model)
        {
            // Kiểm tra xem session có Username không
            var username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                return NotFound("Người dùng không tồn tại hoặc chưa đăng nhập.");
            }

            // Tìm người dùng dựa trên Username
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                return NotFound("Không tìm thấy người dùng.");
            }

            // Tìm khách hàng liên kết với User
            var customer = _context.Customers.FirstOrDefault(c => c.User_ID == user.User_ID);
            if (customer == null)
            {
                return NotFound("Không tìm thấy thông tin khách hàng.");
            }

            // Cập nhật thông tin khách hàng
            customer.FullName = model.NameCus;
            customer.Address = model.AddressCus;
            customer.PhoneNumber = model.PhoneCus;
            customer.Email = model.EmailCus;

            _context.SaveChanges();

            TempData["SuccessMessage"] = "Cập nhật thông tin thành công!";
            return RedirectToAction("EditInfo");
        }
    }
}
