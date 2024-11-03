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
        if (!ModelState.IsValid)
        {
            return View(entry);
        }
        
        await _context.DiaryEntries.AddAsync(entry);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null or 0)
        {
            return NotFound();
        }
        
        var entry = await _context.DiaryEntries.FindAsync(id);

        if (entry is null)
        {
            return NotFound();
        }
        
        return View(entry);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(DiaryEntry entry)
    {
        if (!ModelState.IsValid)
        {
            return View(entry);
        }

        await Task.Run(() => _context.DiaryEntries.Update(entry));
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    //[HttpPost]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id is null or 0)
        {
            return NotFound();
        }

        var entity = await _context.DiaryEntries.FindAsync(id);

        if (entity is null)
        {
            return NotFound();
        }

        await Task.Run(() => _context.Remove(entity));
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}