using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Categories.Models;
using Contacts.Data;

namespace Contacts.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        //public List<Category> Index()
        //{
        //    var ViewBag = _context.Category.ToList() != null ? //_context.Category.ToList() : null;
        //    return ViewBag;
        //}
        public IActionResult Index()
        {
            var categories = _context.Category.ToList(); // Pobierz listę kategorii z bazy danych

            if (categories != null)
            {
                ViewBag.Categories = categories; // Przypisz listę kategorii do ViewBag tylko, jeśli są dostępne
            }

            return View();
        }
    }
}
