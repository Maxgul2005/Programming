using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский элемент управления, представляющий адрес с полями для ввода и отображения.
    /// Позволяет управлять данными адреса и обновлять их отображение на основе ввода пользователя.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Поле, которое хранит адресс.
        /// </summary>
        Address _address;

        /// <summary>
        /// Флаг для корректного обновления полей адреса.
        /// </summary>
        public bool IsUpdatingFieldFlag = true;

        /// <summary>
        /// Получает или устанавливает объект <see cref="Address"/>.
        /// При установке нового значения обновляются данные в пользовательском элементе управления.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateData();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/> и устанавливает начальное значение для <see cref="Address"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            Address =  new Address();
            
        }


        

       

        /// <summary>
        /// Создает подсказку с сообщением об ошибке для текстового поля.
        /// </summary>
        /// <param name="textBox">Текстовое поле, для которого создается подсказка.</param>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        public void CreateTooltip(TextBox textBox, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 500;
            toolTip.SetToolTip(textBox, errorMessage);
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле индекса почты.
        /// Проверяет валидность введенного значения и обновляет свойство <see cref="Address.Index"/> если значение корректно.
        /// </summary>
       private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PostIndexTextBox.Text, out int index) || index < 100000 || index > 999999) // Пример проверки на диапазон
            {
                PostIndexTextBox.BackColor = Color.Pink;
                CreateTooltip(PostIndexTextBox, "Индекс почты должен быть числом и в диапазоне от 100000 до 999999.");
                return;
            }

            try
            {
                PostIndexTextBox.BackColor = Color.White;
                _address.Index = index;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(PostIndexTextBox, error.Message);
                PostIndexTextBox.BackColor = Color.Pink;
            }
        }
        
        /// <summary>
        /// Обрабатывает событие изменения текста в поле страны.
        /// Обновляет свойство <see cref="Address.Country"/> на основе введенного текста.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    Address.Country = CountryTextBox.Text;
                    CountryTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    CountryTextBox.BackColor = Color.Pink; 
                }
            }

        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле города.
        /// Обновляет свойство <see cref="Address.City"/> на основе введенного текста.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    CityTextBox.BackColor = Color.White;
                    Address.City = CityTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    CreateTooltip(CityTextBox, error.Message);
                    CityTextBox.BackColor = Color.Pink;
                }
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле улицы.
        /// Обновляет свойство <see cref="Address.Street"/> на основе введенного текста.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            { 
                try
                {
                    StreetTextBox.BackColor = Color.White;
                    Address.Street = StreetTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    CreateTooltip(StreetTextBox, error.Message);
                    StreetTextBox.BackColor = Color.Pink;
                }
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле здания.
        /// Обновляет свойство <see cref="Address.Building"/> на основе введенного текста.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    BuildingTextBox.BackColor = Color.White;
                    Address.Building = BuildingTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    CreateTooltip(BuildingTextBox, error.Message);
                    BuildingTextBox.BackColor = Color.Pink;
                }
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле квартиры.
        /// Обновляет свойство <see cref="Address.Apartment"/> на основе введенного текста.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == true)
            {
                try
                {
                    ApartmentTextBox.BackColor = Color.White;
                    Address.Apartment = ApartmentTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    CreateTooltip(ApartmentTextBox, error.Message);
                    ApartmentTextBox.BackColor = Color.Pink;
                }
            }
        } 

        /// <summary>
        /// Очистка текстовых полей после нажатия кнопки Add
        /// </summary>
        public void ClearTextBox()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
            PostIndexTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обновляет данные в пользовательском элементе управления на основе текущих значений свойства <see cref="Address"/>.
        /// </summary>
        public void UpdateData()
        {

            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text =_address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;

        }
       

        /// <summary>
        /// Проверяет, является ли адрес пустым или отсутствующим.
        /// </summary>
        /// <returns>true, если хотя бы одно поле адреса пустое; иначе false.</returns>
        public bool AddressIsNullOrEmpty()
        {
            if (string.IsNullOrEmpty(PostIndexTextBox.Text) ||
                string.IsNullOrEmpty(CountryTextBox.Text) ||
                string.IsNullOrEmpty(CityTextBox.Text) ||
                string.IsNullOrEmpty(StreetTextBox.Text) ||
                string.IsNullOrEmpty(BuildingTextBox.Text) ||
                string.IsNullOrEmpty(ApartmentTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
    }
}