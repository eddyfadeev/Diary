using System.Linq.Expressions;
using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Repository;

public class DiaryEntryRepository : IDiaryEntryRepository
{
    private readonly ApplicationDbContext _context;

    public DiaryEntryRepository(ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
        _context.Database.EnsureCreated();
    }

    public async Task<List<DiaryEntry>> GetAsync(
        Expression<Func<DiaryEntry, bool>>? filter = null, 
        Func<IQueryable<DiaryEntry>, IOrderedQueryable<DiaryEntry>>? orderBy = null)
    {
        IQueryable<DiaryEntry> query = _context.DiaryEntries.AsNoTracking();

        if (filter is not null)
        {
            query = query.Where(filter);
        }
        
        return orderBy is not null ?
            await orderBy(query).ToListAsync() :
            await query.ToListAsync();
    }

    public async Task<DiaryEntry?> GetByIdAsync(int entryId)
    {
        var entity = await GetAsync(entry => entry.Id == entryId);

        return entity.FirstOrDefault();
    }

    public async Task CreateAsync(DiaryEntry entry)
    {
        await _context.AddAsync(entry);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(DiaryEntry entry)
    {
        await Task.Run(() => _context.Remove(entry));
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int entryId)
    {
        var entryToDelete = await GetByIdAsync(entryId);

        if (entryToDelete is null)
        {
            return;
        }
        
        await DeleteAsync(entryToDelete);
    }

    public async Task UpdateAsync(DiaryEntry entry)
    {
        await Task.Run(() => _context.Update(entry));
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(Expression<Func<DiaryEntry, bool>> filter) =>
        await _context.DiaryEntries
            .AsNoTracking()
            .Where(filter)
            .AnyAsync();
}