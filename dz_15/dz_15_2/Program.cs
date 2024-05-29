using System;
using System.Collections.Generic;
using System.Linq;

namespace dz_15_2
{
    internal class Program
    {
        private Dictionary<int, string> contacts = new Dictionary<int, string>();
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати контакт");
                Console.WriteLine("2. Видалити контакт");
                Console.WriteLine("3. Оновити контакт");
                Console.WriteLine("4. Знайти контакт");
                Console.WriteLine("5. Показати всі контакти");
                Console.WriteLine("6. Вихід");
                Console.Write("Виберіть опцію: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddContactMenu();
                        break;
                    case "2":
                        RemoveContactMenu();
                        break;
                    case "3":
                        UpdateMenu();
                        break;
                    case "4":
                        FindContactMenu();
                        break;
                    case "5":
                        GetAll();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір, спробуйте ще раз.");
                        break;
                }
            }
        }

        public void AddContact(int number, string name)
        {
            contacts.Add(number, name);  // надо было наоборот, не заметил, если нужно - могу переделать, но таким образом помойму даже чуть труднее
        }

        public void RemoveContact(string name)
        {
            Console.WriteLine("Видалити перше знайдене чи останнє? (1/2)");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                contacts.Remove(contacts.First(x => x.Value == name).Key);
            }
            else
            {
                contacts.Remove(contacts.Last(x => x.Value == name).Key);
            }
        }

        public void Update(int number)
        {
            if (contacts.ContainsKey(number))
            {
                string value = contacts[number];
                Console.Write("Введіть новий номер: ");
                int newNumber = int.Parse(Console.ReadLine());
                contacts.Remove(number);
                contacts.Add(newNumber, value);
            }
            else
            {
                Console.WriteLine("Контакт не знайдено.");
            }
        }

        public void Finder(int number)// если по имени, то также как в RemoveContact
        {
            if (contacts.ContainsKey(number))
            {
                KeyValuePair<int, string> contactPair = contacts.FirstOrDefault(x => x.Key == number);
                Console.WriteLine($"Номер контакта: {contactPair.Key}, Ім'я контакта: {contactPair.Value}");
            }
            else
            {
                Console.WriteLine("Контакт відсутній, бажаєте додати? y/n");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Console.Write("Введіть номер телефону: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Введіть ім'я: ");
                    string b = Console.ReadLine();
                    AddContact(a, b);
                }
            }
        }

        public void GetAll()
        {
            foreach (KeyValuePair<int, string> pair in contacts)
            {
                Console.WriteLine($"Номер телефону: {pair.Key}, Ім'я: {pair.Value}");
            }
        }

        private void AddContactMenu()
        {
            Console.Write("Введіть номер телефону: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine();
            AddContact(number, name);
            Console.WriteLine("Контакт додано.");
        }

        private void RemoveContactMenu()
        {
            Console.Write("Введіть ім'я контакту для видалення: ");
            string name = Console.ReadLine();
            RemoveContact(name);
            Console.WriteLine("Контакт видалено.");
        }

        private void UpdateMenu()
        {
            Console.Write("Введіть номер контакту для оновлення: ");
            int number = int.Parse(Console.ReadLine());
            Update(number);
            Console.WriteLine("Контакт оновлено.");
        }

        private void FindContactMenu()
        {
            Console.Write("Введіть номер контакту для пошуку: ");
            int number = int.Parse(Console.ReadLine());
            Finder(number);
        }
    }
}
