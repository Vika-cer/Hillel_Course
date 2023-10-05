using System;

namespace User
{
    class User
    {
        private string login = string.Empty;
        public string Login
        {
            get { return login; }
            set { login = GetYourLogin(); }
        }

        private string GetYourLogin()
        {
            bool resParse = false;

            do
            {
                Console.Write("Write your login: ");
                string input = Console.ReadLine();
                resParse = !string.IsNullOrWhiteSpace(input);
                if (resParse)
                {
                    return input;
                }
            }
            while (!resParse);

            return login;
        }

        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = GetYourName(); }
        }

        private string GetYourName()
        {
            bool resParse = false;

            do
            {
                Console.Write("Write your name: ");
                string input = Console.ReadLine();
                resParse = !string.IsNullOrWhiteSpace(input);
                if (resParse)
                {
                    return input;
                }
            }
            while (!resParse);

            return name;
        }

        private string female = string.Empty;
        public string Female
        {
            get { return female; }
            set { female = GetYourFemale(); }
        }

        private string GetYourFemale()
        {
            bool resParse = false;

            do
            {
                Console.Write("Write your female: ");
                string input = Console.ReadLine();
                resParse = !string.IsNullOrWhiteSpace(input);
                if (resParse)
                {
                    return input;
                }
            }
            while (!resParse);

            return female;
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = GetYourAge(); }
        }

        public int GetYourAge()
        {
            bool resParse = false;
            do
            {
                Console.Write("Write your age: ");
                string input = Console.ReadLine();
                resParse = int.TryParse(input, out age);
            }
            while (!resParse || age < 0 || age > 100);

            return age;
        }

        private DateTime time;

        public User()
        {
            time = DateTime.Now;
            Name = name;
            Female = female;
            Login = login;
            Age = age;
        }

        public void WriteAllInfo()
        {
            Console.WriteLine($"Login is {login}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Female is {female}");
            Console.WriteLine($"Time is {time}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User();
                user.WriteAllInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
