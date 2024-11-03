using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers;

public class DiaryEntriesController : Controller
{
    private readonly ApplicationDbContext _context;

    public DiaryEntriesController(ApplicationDbContext context) => _context = context;
    // GET
    public async Task<IActionResult> Index()
    {
        var entries = await _context.DiaryEntries.ToListAsync();
        
        return View(entries);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(DiaryEntry entry)
    {
        // if (!ModelState.IsValid)
        // {
        //     return View(entry);
        // }
        
        await _context.AddAsync(entry);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}