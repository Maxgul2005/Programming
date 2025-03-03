using System;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        /// <summary>
        /// Полный путь к файлу хранения контакта.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создает экземпляр <see cref="ContactSerializer"/> с путем к файлу по умолчанию.
        /// </summary>
        public ContactSerializer()
        {
            string directoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");

            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }

            _filePath = Path.Combine(directoryName, "contacts.json");
        }

        /// <summary>
        /// Сохраняет контакт в файл.
        /// </summary>
        /// <param name="contact">Контакт для сохранения.</param>
        public void SaveToFile(Contact contact)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
            }
        }

        /// <summary>
        /// Загружает контакт из файла.
        /// </summary>
        /// <returns>Загруженный контакт или новый объект, если файл отсутствует.</returns>
        public Contact LoadFromFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return new Contact();
                }

                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<Contact>(json) ?? new Contact();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке файла: {ex.Message}");
                return new Contact();
            }
        }
    }
}
