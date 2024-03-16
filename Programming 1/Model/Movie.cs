using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Movie
    {
        public  string Name{  get; set; }
        private int _minutes;
        private int _year;
        public string Genre { get; set; }
        private int _rating;

    public int Minutes
    {
        get
        { return _minutes;}
        set
        {
            Validator.AssertOnPositiveValue(value, "minutes");
            _minutes = value;
        }
    }
    public int Year
    {
        get
        { return _year;}
        set
        {
            if ((value < 1950) || (value > 2024))
            {
                throw new ArgumentException("Год должен быть в диапозоне от 1950 до 2024");
            }
            _year = value;
        }
    }
    public int Rating
    {
        get { return _rating;}
        set
        {
            if ((value < 0) || (value > 10))
            {
                throw new ArgumentException("Рейтинг должен быть в диапозоне от 0+ до 10");
            }
            _rating = value;
        }
    }
    public Movie(string name, int minutes, int year, string genre,int rating)
    {
        Name = name;
        Minutes = minutes;
        Year = year;
        Genre = genre;
        Rating = rating;

    }


    }

