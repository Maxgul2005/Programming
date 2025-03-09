using System;
using System.ComponentModel;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    ///  Основная модель представления для управления контактами и их сохранением.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий контакт, с которым работает модель представления.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Объект, выполняющий сериализацию и десериализацию контактов.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Команда для сохранения контакта в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команда для загрузки контакта из файла.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Создает экземпляр <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _contactSerializer = new ContactSerializer();
            _contact = new Contact();

            SaveCommand = new SaveCommand(_contactSerializer, () => _contact);
            LoadCommand = new LoadCommand(_contactSerializer, SetContact);
        }

        /// <summary>
        ///  Возвращает и задает текущее имя контакта.
        /// </summary>
        public string Name
        {
            get => _contact.Name;
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        ///  Возвращает и задает номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        ///  Возвращает и задает почту контакта.
        /// </summary>
        public string Email
        {
            get => _contact.Email;
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Событие, уведомляющее об изменениях в свойствах.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Обработчик события, если мы меняем текстбокс
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// Обновление свойства Name, PhoneNumber, и Emai. 
        /// </summary>
        /// <param name="contact"></param>
        private void SetContact(Contact contact)
        {
            _contact = contact;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }
    }
}
