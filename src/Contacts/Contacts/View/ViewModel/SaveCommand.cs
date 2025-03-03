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
    public class SaveCommand : ICommand
    {
        private readonly ContactSerializer _serializer;
        private readonly Func<Contact> _getContact;

        public SaveCommand(ContactSerializer serializer, Func<Contact> getContact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _getContact = getContact ?? throw new ArgumentNullException(nameof(getContact));
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _serializer.SaveToFile(_getContact());
        }
    }
}