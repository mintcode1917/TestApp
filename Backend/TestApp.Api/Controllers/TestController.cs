using Microsoft.AspNetCore.Mvc;
using TestApp.DataLayer.Repositories;
using TestApp.Models.Entities;

namespace TestApp.Api.Controllers;

/// <summary>
/// Контроллер работы со списком
/// </summary>
[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly IListRepository _listRepository;

    public TestController(IListRepository listRepository)
    {
        _listRepository = listRepository;
    }

    /// <summary>
    /// Записать список в БД
    /// </summary>
    /// <param name="requestList">Список элементов</param>
    [HttpPut]
    [Route("PutList")]
    public async Task Put([FromBody] Dictionary<int,string> requestList)
    {
        await _listRepository.ClearListAsync();

        var number = 1;
         var listElements = requestList
             .OrderBy(el => el.Key)
             .Select(requestElement => new Element(number++, requestElement.Key, requestElement.Value))
             .ToList();

        await _listRepository.PutListAsync(listElements);
    }
    
    /// <summary>
    /// Получить список из БД с учетом фильтров и пагинации
    /// </summary>
    /// <param name="pageNumber">Номер страницы</param>
    /// <param name="pageSize">Размер страницы</param>
    [HttpGet]
    [Route("GetList")]
    public async Task<IEnumerable<Element>> Get(int pageNumber, int pageSize)
    {
        return await _listRepository.GetListAsync(pageNumber, pageSize);
    }
}