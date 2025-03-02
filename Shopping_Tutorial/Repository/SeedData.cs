using Microsoft.EntityFrameworkCore;
using Shopping_Tutorial.Models;

namespace Shopping_Tutorial.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
            if (!_context.Products.Any())
            {
                CategoryModel macbook = new CategoryModel
                {
                    Name = "Macbook",
                    Description = "Macbook is large Product in the word",
                    Slug = "macbook",
                    Status = 1
                };
                CategoryModel pc = new CategoryModel
                {
                    Name = "PC",
                    Description = "PC is large Product in the word",
                    Slug = "pc",
                    Status = 1
                };

                BrandModel apple = new BrandModel
                {
                    Name = "Apple",
                    Description = "Apple is large Brand in the word",
                    Slug = "apple",
                    Status = 1
                };
                BrandModel samsung = new BrandModel
                {
                    Name = "Samsung",
                    Description = "Samsung is large Brand in the word",
                    Slug = "samsung",
                    Status = 1
                };

                _context.Products.AddRange(
                    new ProductModel
                    {
                        Name = "Macbook Pro 2021",
                        Description = "Macbook Pro 2021 is large Product in the word",
                        Slug = "macbook",
                        Price = 2000,
                        Brand = apple,
                        Category = macbook,
                        Image = "1.jpg"
                    },
                    new ProductModel
                    {
                        Name = "PC 2022",
                        Description = "PC is the best",
                        Slug = "pc",
                        Price = 1500,
                        Brand = samsung,
                        Category = pc,
                        Image = "2.jpg"
                    }
                );
                _context.SaveChanges();
            }
        }
    }
}
