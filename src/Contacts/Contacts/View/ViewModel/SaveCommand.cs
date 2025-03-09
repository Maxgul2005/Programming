using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для сохранения контакта в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {

        /// <summary>
        /// Объект, выполняющий сериализацию контактов в файл.
        /// </summary>
        private readonly ContactSerializer _serializer;
        /// <summary>
        /// Делегат, возрающий текущий контакт для сохранения.
        /// </summary>
        private readonly Func<Contact> _getContact;

        /// <summary>
        /// Инициализирует новый экземпляр команды <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="serializer">Обьект, выполняющий сериализацию контактов в файл.</param>
        /// <param name="getContact">Функция возращающая текущий контакт</param>
        /// <exception cref="ArgumentNullException">Выбрасывается если вызван null</exception>
        public SaveCommand(ContactSerializer serializer, Func<Contact> getContact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _getContact = getContact ?? throw new ArgumentNullException(nameof(getContact));
        }

        /// <inheritdoc/>
        public event EventHandler? CanExecuteChanged;

        /// <inheritdoc/>
        public bool CanExecute(object? parameter) => true;

        /// <inheritdoc/>
        public void Execute(object? parameter)
        {
            _serializer.SaveToFile(_getContact());
        }
    }
}