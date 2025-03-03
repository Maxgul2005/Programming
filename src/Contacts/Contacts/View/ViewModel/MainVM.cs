using System;
using System.ComponentModel;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private Contact _contact;
        private readonly ContactSerializer _contactSerializer;

        public ICommand SaveCommand { get; }
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

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetContact(Contact contact)
        {
            _contact = contact;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }
    }
}
