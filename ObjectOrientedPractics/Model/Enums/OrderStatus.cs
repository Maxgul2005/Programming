/// <summary>
/// Перечесление, которое хранит статусы заказа
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// Новый.
    /// </summary>
    New,
    /// <summary>
    /// Обрабатывается.
    /// </summary>
    Processing,
    /// <summary>
    /// Собирается на складе.
    /// </summary>
    Assembly,
    /// <summary>
    /// Отправлен
    /// </summary>
    Sent,
    /// <summary>
    /// Доставлен.
    /// </summary>
    Delivered,
    /// <summary>
    /// Возрат
    /// </summary>
    Returned,
    /// <summary>
    /// Отменен (со стороны магазина).
    /// </summary>
    Abandoned
}