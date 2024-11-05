using DiaryApp.Models;
using DiaryApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers;

public class DiaryEntriesController : Controller
{
    private readonly IDiaryEntryRepository _repository;

    public DiaryEntriesController(IDiaryEntryRepository repository) => 
        _repository = repository;
    // GET
    public async Task<IActionResult> Index()
    {
        var entries = await _repository.GetAsync(
            orderBy: query => 
                query.OrderByDescending(entry => entry.Created));
        
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
        
        await _repository.CreateAsync(entry);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null or 0)
        {
            return NotFound();
        }

        var entry = await _repository.GetByIdAsync(id.Value);

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

        await _repository.UpdateAsync(entry);

        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id is null or 0)
        {
            return NotFound();
        }

        await _repository.DeleteAsync(id.Value);

        return RedirectToAction("Index");
    }
}