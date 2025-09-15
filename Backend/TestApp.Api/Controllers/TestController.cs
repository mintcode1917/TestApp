using Microsoft.AspNetCore.Mvc;
using TestApp.Application;
using TestApp.DataLayer.Repositories;
using TestApp.Models.Dtos;
using TestApp.Models.Entities;

namespace TestApp.Api.Controllers;

/// <summary>
/// Контроллер работы со списком
/// </summary>
[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly IListService _listService;

    public TestController(IListService listService)
    {
        _listService = listService;
    }

    /// <summary>
    /// Записать список в БД
    /// </summary>
    /// <param name="requestList">Список элементов</param>
    [HttpPut]
    [Route("PutList")]
    public async Task Put([FromBody] PutListDto[] requestList)
    {
       await _listService.PutListAsync(requestList);
    }
    
    /// <summary>
    /// Получить список из БД с учетом фильтров и пагинации
    /// </summary>
    [HttpGet]
    [Route("GetList")]
    public async Task<IEnumerable<Element>> Get(GetListDto request)
    {
        return await _listService.GetListAsync(request);
    }
}