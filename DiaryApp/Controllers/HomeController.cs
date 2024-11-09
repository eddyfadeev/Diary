using System.Diagnostics;
using System.Linq.Expressions;
using DiaryApp.Enums;
using DiaryApp.Models;
using DiaryApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers;

public class HomeController : Controller
{
    private readonly IDiaryEntryRepository _repository;

    public HomeController(IDiaryEntryRepository repository) => 
        _repository = repository;
    
    public async Task<IActionResult> Index(
        int? page,
        SortingOrder sortBy = SortingOrder.Descending,
        string? search = null)
    {
        const int pageSize = 10;
        
        ViewData["SortOrder"] = sortBy;

        if (string.IsNullOrWhiteSpace(search) && page is null)
        {
            page = 1;
        }

        ViewData["AppliedFilter"] = search ?? string.Empty;
        
        var entries = await _repository.GetAsync(
            filter: GetFilterExpression(search),
            orderBy: GetSortPredicate(sortBy)
        );
        
        var paginatedList = 
            PaginatedList<DiaryEntry>.Create(
                entries, 
                page ?? 1, 
                pageSize
            );
        
        return View(paginatedList);
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
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    private static Func<IQueryable<DiaryEntry>, IOrderedQueryable<DiaryEntry>> 
        GetSortPredicate(SortingOrder sortingOrder) =>
        sortingOrder is SortingOrder.Ascending
            ? q => q.OrderBy(e => e.Created)
            : q => q.OrderByDescending(e => e.Created);
    
    private static Expression<Func<DiaryEntry, bool>>? GetFilterExpression(string? searchQuery) =>
        string.IsNullOrWhiteSpace(searchQuery) 
            ? null 
            : entry => entry.Content.Contains(searchQuery) || entry.Title.Contains(searchQuery);
}