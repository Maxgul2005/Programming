using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Класс контакта пользователя, хранящий имя, номер телефона и почту.
    /// </summary>
    public class Contact: INotifyPropertyChanged
    {
        /// <summary>
        /// Поле, хранящее имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// поле, хранящее номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Поле, хранящее почту контакта.
        /// </summary>
        private string _email;


        /// <summary>
        /// Задает и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value)
                {
                    return;
                }

                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Задает и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (_phoneNumber == value)
                {
                    return;
                }

                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Задает и возвращает почту контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (_email == value)
                {
                    return;
                }

                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }


        /// <summary>
        /// Конструктор Contact с параметрами.
        /// </summary>
        /// <param name="name">Имя Контакта</param>
        /// <param name="phoneNumber">Телефонный номер контакта</param>
        /// <param name="email">Почта контакта</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Конструктор класса Contact, без параметров.
        /// Инициализирует значениями по умолчанию.
        /// </summary>
        public Contact()
        {
            
        }

        /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/> для обновления интерфейса.
        /// </summary>
        /// <param name="propertyName">Имя измененного свойства.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
