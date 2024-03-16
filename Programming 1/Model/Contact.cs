using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;



    class Contact
    {
        private string _name;
        private string _surname;
        public string Name
        {
            get { return _name; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        private void AssertStringContainsOnlyLetters(string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Строка должна содержать только символы английского алфавита.");
            }
        }
    }

