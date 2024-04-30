using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Movie
{
    public string Name { get; set; }
    private int _minutes;
    private int _year;
    public string Genre { get; set; }
    private int _rating;

    /// <summary>
    /// Получает и задает продолжительность фильма в минутах.
    /// </summary>
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            Validator.AssertOnPositiveValue(value, "minutes");
            _minutes = value;
        }
    }

    /// <summary>
    /// получает и задает год выпуска фильма с проверкой условия диапозона.
    /// </summary>
    public int Year
    {
        get { return _year; }
        set
        {
            Validator.AssertValueInRange(value, 1950, 2024, "Year");
            _year = value;
        }
    }

    /// <summary>
    /// получает и задает рейтинг фильма с проверкой условия диапозона.
    /// </summary>
    public int Rating
    {
        get { return _rating; }
        set
        {
            Validator.AssertValueInRange(value, 0, 10, "Rating");
            _rating = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Movie"/> с заданными параметрами.
    /// </summary>
    /// <param name="name">Название фильма.</param>
    /// <param name="minutes">Продолжительность фильма в минутах.</param>
    /// <param name="year">Год выпуска фильма.</param>
    /// <param name="genre">Жанр фильма.</param>
    /// <param name="rating">Рейтинг фильма.</param>
    public Movie(string name, int minutes, int year, string genre, int rating)
    {
        Name = name;
        Minutes = minutes;
        Year = year;
        Genre = genre;
        Rating = rating;
    }
}





