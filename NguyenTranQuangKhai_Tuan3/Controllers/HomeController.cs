using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenTranQuangKhai_Tuan3.Models;
using NguyenTranQuangKhai_Tuan3.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace NguyenTranQuangKhai_Tuan3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAllAsync(); // Lấy danh sách sản phẩm
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}