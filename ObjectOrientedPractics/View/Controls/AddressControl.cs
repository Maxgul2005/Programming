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
        public bool IsUpdatingFieldFlag = false;

       

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
                NewAddress.Address.Index = index;
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
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    
                    CountryTextBox.BackColor = Color.White;
                    
                    NewAddress.Address.Country = CountryTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    CreateTooltip(CountryTextBox, error.Message);
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
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    CityTextBox.BackColor = Color.White;
                    NewAddress.Address.City = CityTextBox.Text;
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
            if (IsUpdatingFieldFlag == false)
            { 
                try
                {
                    StreetTextBox.BackColor = Color.White;
                    NewAddress.Address.Street = StreetTextBox.Text;
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
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    BuildingTextBox.BackColor = Color.White;
                    NewAddress.Address.Building = BuildingTextBox.Text;
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
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    ApartmentTextBox.BackColor = Color.White;
                    NewAddress.Address.Apartment = ApartmentTextBox.Text;
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
        public AddressControl NewAddress;
        /// <summary>
        /// При выборе обьекта в листбокс показывает текстбоксы <see cref="Address"/>.
        /// </summary>
        public void UpdateData(Address SomeAddress)
        {


            NewAddress.Address = SomeAddress;

            PostIndexTextBox.Text = NewAddress.Address.Index.ToString();
            CountryTextBox.Text = NewAddress.Address.Country.ToString();
            CityTextBox.Text = NewAddress.Address.City.ToString();
            StreetTextBox.Text = NewAddress.Address.Street.ToString();
            BuildingTextBox.Text = NewAddress.Address.Building.ToString();
            ApartmentTextBox.Text = NewAddress.Address.Apartment.ToString();

        }

        /// <summary>
        /// Инициализируем обьект адресс на основе ткущих значениях текстбокс
        /// </summary>
        /// <returns></returns>
        public Address GiveValues()
        {
            return new Address(Convert.ToInt32(PostIndexTextBox.Text), CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text, ApartmentTextBox.Text);
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

        private void AddressControl_Load(object sender, EventArgs e)
        {
            NewAddress = new AddressControl();
        }
    }
}