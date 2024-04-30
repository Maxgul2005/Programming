using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_1.Model
{
    public partial class Movies : UserControl
    {
        public Movies()
        {
            InitializeComponent();
            MovieInitiaziation();
        }
        Random _random = new Random();
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;
        private string[] moviesName = { "Бойцовский клуб", "Форрест Гамп", "Криминальное чтиво", "Механик", "Знахарь" };
        private string[] listBoxMovie = new string[5];

        /// <summary>
        /// Инициализация фильмов.
        /// </summary>
        public void MovieInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                int Minutes = _random.Next(280);
                int Year = _random.Next(1950, 2025);
                string Genre = "Криминалл";
                int Rating = _random.Next(1, 11);
                _movies[i] = new Movie(moviesName[i], Minutes, Year, Genre, Rating);
                listBoxMovie[i] = ($"Movie {i + 1}");
            }
            ListBoxClassesMovie.Items.AddRange(listBoxMovie);

        }

        /// <summary>
        /// Находит фильм с максимальным рейтингом.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        /// <returns>Индекс фильма с максимальным рейтингом.</returns>
        private int FindMovieMaxRating(Movie[] movies)
        {
            int maxIndexRating = 0; // Изначально считаем, что максимальный рейтинг первого фильма
            int maxRating = movies[0].Rating; // Изначально берем рейтинг первого фильма

            for (int i = 1; i < movies.Length; i++)
                if (movies[i].Rating > maxRating) // Если текущий фильм имеет рейтинг выше предыдущего максимального
                {
                    maxIndexRating = i; // Сохраняем индекс фильма с максимальным рейтингом
                    maxRating = movies[i].Rating; // Обновляем максимальный рейтинг
                }

            return maxIndexRating;
        }

        private void Movies_Load(object sender, EventArgs e)
        {

        }

        private void ListBoxClassesMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = ListBoxClassesMovie.SelectedIndex;
            _currentMovie = _movies[SelectedIndex];
            TextBoxMovieName.Text = _currentMovie.Name;
            TextBoxMovieMinutes.Text = _currentMovie.Minutes.ToString();
            TextBoxMovieYear.Text = _currentMovie.Year.ToString();
            TextBoxMovieGenre.Text = _currentMovie.Genre;
            TextBoxMovieRaiting.Text = _currentMovie.Rating.ToString();
        }

        private void TextBoxMovieMinutes_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null)
            {
                TextBoxMovieMinutes.BackColor = AppColors.ValidationColor;
            }

            try
            {
                _currentMovie.Minutes = int.Parse(TextBoxMovieMinutes.Text);
                TextBoxMovieMinutes.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                TextBoxMovieMinutes.BackColor = AppColors.ValidationColor;
            }
        }

        private void TextBoxMovieYear_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null)
            {
                TextBoxMovieYear.BackColor = AppColors.ValidationColor;
            }
            try
            {
                _currentMovie.Year = int.Parse(TextBoxMovieYear.Text);
                TextBoxMovieYear.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                TextBoxMovieYear.BackColor = AppColors.ValidationColor;
            }
        }

        private void TextBoxMovieRaiting_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null)
            {
                TextBoxMovieRaiting.BackColor = AppColors.ValidationColor; 
            }
            try
            {
                _currentMovie.Rating = int.Parse(TextBoxMovieRaiting.Text);
                TextBoxMovieRaiting.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                TextBoxMovieRaiting.BackColor = AppColors.ValidationColor; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indexRating = FindMovieMaxRating(_movies);
            ListBoxClassesMovie.SelectedIndex = indexRating;
        }
    }
}
