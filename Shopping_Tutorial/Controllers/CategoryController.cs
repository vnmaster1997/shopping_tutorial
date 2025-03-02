﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_Tutorial.Models;
using Shopping_Tutorial.Repository;

namespace Shopping_Tutorial.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _dataContext;

        public CategoryController(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<IActionResult> Index(string slug = "")
        {
            CategoryModel category = _dataContext.Categories.FirstOrDefault(c => c.Slug == slug);
            if(category == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var productsByCategory = _dataContext.Products.Where(p => p.CategoryId == category.Id);

            return View(await productsByCategory.OrderByDescending(p => p.Id).ToListAsync());
        }
    }
}
