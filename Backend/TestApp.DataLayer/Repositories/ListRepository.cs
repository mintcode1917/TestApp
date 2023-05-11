using Microsoft.EntityFrameworkCore;
using TestApp.Models.Entities;

namespace TestApp.DataLayer.Repositories;

/// <summary>
/// Репозиторий работы со списком
/// </summary>
public class ListRepository : IListRepository
{
    private readonly DataDbContext _context;

    public ListRepository(DataDbContext context)
    {
        _context = context;
    }

    public async Task PutListAsync(IEnumerable<Element> listElements)
    {
        _context.Elements.AddRange(listElements);
        await _context.SaveChangesAsync();
    }

    public Task<List<Element>> GetListAsync(int pageNumber, int pageSize) =>
        _context.Elements.AsNoTracking().Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToListAsync();

    public async Task ClearListAsync()
    {
        _context.Elements.RemoveRange(_context.Elements);
        await SaveChangesAsync();
    }

    public Task<int> SaveChangesAsync() =>
        _context.SaveChangesAsync();
}