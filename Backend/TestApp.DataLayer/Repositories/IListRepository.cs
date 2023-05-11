using Microsoft.EntityFrameworkCore.ChangeTracking;
using TestApp.Models.Entities;

namespace TestApp.DataLayer.Repositories;

/// <summary>
/// Репозиторий управления списком
/// </summary>
public interface IListRepository
{
    /// <summary>
    /// Сохранить список элементов в БД
    /// </summary>
    Task PutListAsync(IEnumerable<Element> listElements);

    /// <summary>
    /// Получить список элементов
    /// </summary>
    Task<List<Element>> GetListAsync(int pageNumber, int pageSize);
    
    /// <summary>
    /// Сохранить контекст
    /// </summary>
    /// <returns></returns>
    Task<int> SaveChangesAsync();

    /// <summary>
    /// Очистить список
    /// </summary>
    Task ClearListAsync();
}