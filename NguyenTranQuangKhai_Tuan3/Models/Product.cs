using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Thêm dòng này để dùng [Precision]

namespace NguyenTranQuangKhai_Tuan3.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(0.01, 10000.00)]
        [Precision(18, 2)] // Thêm dòng này để tránh lỗi làm tròn giá trị
        public decimal Price { get; set; }

        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public List<ProductImage>? Images { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
