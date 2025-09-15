using TestApp.DataLayer.Repositories;
using TestApp.Models.Dtos;
using TestApp.Models.Entities;

namespace TestApp.Application;

public class ListService : IListService
{
    private readonly IListRepository _listRepository;

    public ListService(IListRepository listRepository)
    {
        _listRepository = listRepository;
    }

    public async Task PutListAsync(PutListDto[] list)
    {
        await _listRepository.ClearListAsync();

        var number = 1;
        var listElements = list
            .Select(s => new Element(s.Code, s.Value))
            .OrderBy(el => el.Code)
            .ToList();

        await _listRepository.PutListAsync(listElements);
    }

    public async Task<IEnumerable<Element>> GetListAsync(GetListDto request)
    {
        return await _listRepository.GetListAsync(request.PageNumber, request.PageSize);
    }
}