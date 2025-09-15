using TestApp.Models.Dtos;
using TestApp.Models.Entities;

namespace TestApp.Application;

public interface IListService
{
   public Task PutListAsync(PutListDto[] list);

   public Task<IEnumerable<Element>> GetListAsync(GetListDto request);
}