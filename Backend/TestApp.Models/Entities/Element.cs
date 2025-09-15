namespace TestApp.Models.Entities;

/// <summary>
/// Сущность элемента списка
/// </summary>
public class Element
{
    /// <summary>
    /// Порядковый номер
    /// </summary>
    public int Id { get;}

    /// <summary>
    /// Код записи
    /// </summary>
    public int Code { get; private set; }

    /// <summary>
    /// Значение
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="number"><see cref="Number"/></param>
    /// <param name="code"><see cref="Code"/></param>
    /// <param name="value"><see cref="Value"/></param>
    public Element(int code, string value)
    {
        Code = code;
        Value = value;
    }
}