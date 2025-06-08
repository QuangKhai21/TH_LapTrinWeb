using Microsoft.EntityFrameworkCore;
using NguyenTranQuangKhai_Tuan3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace NguyenTranQuangKhai_Tuan3.Data

{


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //lấy ánh xạ lưu vào CSDL
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //khai báo các bảng sẽ sử dụng
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }



    }

}
