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
            Validator.AssertValueInRange(value,1950,2024,"Year");
            _year = value;
        }
    }
    public int Rating
    {
        get { return _rating;}
        set
        {
            Validator.AssertValueInRange(value, 0, 10, "Rating");
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

