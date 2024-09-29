using System.ComponentModel.DataAnnotations;

namespace Task1433
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты 
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            var sortedContacts = phoneBook.OrderBy(s => s.Name).ThenBy(s => s.LastName);

            foreach (var contact in sortedContacts)
                Console.WriteLine($"{contact.Name} - {contact.LastName} p# {contact.PhoneNumber}");

        }
    }
}

    public class Contact // модель класса 
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор 
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
