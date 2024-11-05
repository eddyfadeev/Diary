using System.Linq.Expressions;
using DiaryApp.Models;

namespace DiaryApp.Repository;

public interface IDiaryEntryRepository
{
    Task<List<DiaryEntry>> GetAsync(
        Expression<Func<DiaryEntry, bool>>? filter = null,
        Func<IQueryable<DiaryEntry>, IOrderedQueryable<DiaryEntry>>? orderBy = null);
    Task<DiaryEntry?> GetByIdAsync(int entryId);
    Task CreateAsync(DiaryEntry entry);
    Task DeleteAsync(DiaryEntry entry);
    Task DeleteAsync(int entryId);
    Task UpdateAsync(DiaryEntry entry);
    Task<bool> ExistsAsync(Expression<Func<DiaryEntry, bool>> filter);
}