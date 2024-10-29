using DiaryApp.Data;
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

    public IActionResult Create()
    {
        return View();
    }
}