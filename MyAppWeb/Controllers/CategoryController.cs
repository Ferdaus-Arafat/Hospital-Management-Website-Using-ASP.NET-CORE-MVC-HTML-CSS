﻿using Microsoft.AspNetCore.Mvc;
using MyAppWeb.Data;
using MyAppWeb.Models;

namespace MyAppWeb.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories;
            return View(categories);
        }
    }
}
