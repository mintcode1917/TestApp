namespace TestApp.Models.Entities;

/// <summary>
/// Сущность элемента списка
/// </summary>
public class Element
{
    /// <summary>
    /// Порядковый номер
    /// </summary>
    public int Number { get; private set; }

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
    public Element(int number, int code, string value)
    {
        Number = number;
        Code = code;
        Value = value;
    }
}