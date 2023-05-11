namespace TestApp.Models.Entities.Requests;

/// <summary>
/// Сущность элемента из запроса на запись
/// </summary>
public class RequestElement
{
    
    /// <summary>
    /// Код записи
    /// </summary>
    public int Code { get; set; }
    
    /// <summary>
    /// Значение
    /// </summary>
    public string Value { get; set; }
}