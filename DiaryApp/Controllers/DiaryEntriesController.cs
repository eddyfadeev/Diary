using System.Linq.Expressions;
using DiaryApp.Enums;
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
    public async Task<IActionResult> Index(
        SortingOrder? sortOrder,
        string? currentFilter,
        string? searchString,
        int? pageNumber)
    {
        const int pageSize = 10;
        
        ViewData["SortOrder"] = 
            sortOrder is SortingOrder.Descending or null
            ? SortingOrder.Ascending 
            : SortingOrder.Descending;

        if (!string.IsNullOrEmpty(searchString))
        {
            pageNumber = 1;
        }
        else
        {
            searchString = currentFilter;
        }

        ViewData["AppliedFilter"] = searchString ?? string.Empty;

        Func<IQueryable<DiaryEntry>, IOrderedQueryable<DiaryEntry>> sortQuery = 
            sortOrder is null or SortingOrder.Descending
                ? q => q.OrderByDescending(e => e.Created)
                : q => q.OrderBy(e => e.Created); 
        
        Expression<Func<DiaryEntry, bool>>? filterQuery = 
            string.IsNullOrWhiteSpace(searchString) 
                ? default 
                : entry => entry.Content.Contains(searchString) || entry.Title.Contains(searchString);
        
        var entries = await _repository.GetAsync(
            filter: filterQuery,
            orderBy: sortQuery
        );
        
        return View(PaginatedList<DiaryEntry>.CreateAsync(entries, pageNumber ?? 1, pageSize));
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