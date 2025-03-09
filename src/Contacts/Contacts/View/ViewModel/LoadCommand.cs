using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для загрузки контакта из файла.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        ///  Объект, выполняющий сериализацию контактов в файл.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Делегат, который устанавливает загруженный контакт в модели представления.
        /// Используется для обновления состояния объекта Contact.
        /// </summary>
        private readonly Action<Contact> _setContact;

        /// <summary>
        /// Инициализирует новый экземпляр команды <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="serializer">Объект, выполняющий сериализацию контактов в файл.</param>
        /// <param name="setContact">Делегат для передачи загруженного контакта в ViewModel.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если передан null.</exception>
        public LoadCommand(ContactSerializer serializer, Action<Contact> setContact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _setContact = setContact ?? throw new ArgumentNullException(nameof(setContact));
        }
        /// <inheritdoc/>
        public event EventHandler? CanExecuteChanged;
        /// <inheritdoc/>
        public bool CanExecute(object? parameter) => true;
        /// <inheritdoc/>
        public void Execute(object? parameter)
        {
            Contact loadedContact = _serializer.LoadFromFile();
            _setContact(loadedContact);
        }
    }
}