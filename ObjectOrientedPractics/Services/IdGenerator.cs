class IdGenerator
{
    // Поле-счетчик для генерации уникальных ID
    private static int _idCounter = 0;

    /// <summary>
    /// Метод для генерации уникальных Id
    /// </summary>
    /// <returns></returns>
    public static int GetNextId()
    {
        return ++_idCounter;
    }
}

