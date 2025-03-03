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
    public class LoadCommand : ICommand
    {
        private readonly ContactSerializer _serializer;
        private readonly Action<Contact> _setContact;

        public LoadCommand(ContactSerializer serializer, Action<Contact> setContact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _setContact = setContact ?? throw new ArgumentNullException(nameof(setContact));
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            Contact loadedContact = _serializer.LoadFromFile();
            _setContact(loadedContact);
        }
    }
}