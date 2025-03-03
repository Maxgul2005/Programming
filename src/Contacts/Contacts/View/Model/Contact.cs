using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact
    {
        /// <summary>
        /// Задает и возращает имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Задает и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Задает и возращает почту контакта.
        /// </summary>
        public string Email { get; set; }

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
            Name = "Гуляев Максим";
            PhoneNumber = "Кто знает, тот знает";
            Email = "Trulaladvanula00gmail.com";
        }
    }
}
