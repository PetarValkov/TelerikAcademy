using System;

class CompanyAndManager
{
    class Company
    {
        private static string nameOfCompany, address, phoneNumber, faxNumber, website, manager;

        static Company()
        {
            nameOfCompany = null;
            address = null;
            phoneNumber = null;
            faxNumber = null;
            website = null;
            manager = null;
        }

        public void input()
        {
            Console.WriteLine("Please write the name of the company");
            nameOfCompany = Console.ReadLine();

            Console.WriteLine("Please write the address of the company.");
            address = Console.ReadLine();

            Console.WriteLine("Please write the phone number of the company.");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Please write the fax number of the company.");
            faxNumber = Console.ReadLine();

            Console.WriteLine("Please write the website of the company.");
            website = Console.ReadLine();

            Console.WriteLine("Please write the name of the manager of the company.");
            manager = Console.ReadLine();
        }

        public void output()
        {
            Console.WriteLine("The company's name is {0} and it is located at {1}. If you want to contact us please call us at {2}, or send us a fax at {3}, or you can visit our website {4}"
                ,nameOfCompany, address, phoneNumber,faxNumber, website);
        }
    }

    class Manager
    {
        private static string firstName, lastName, phoneNumber;
        private static int age;

        static Manager()
        {
            firstName = null;
            lastName = null;
            phoneNumber = null;
            age = 0;
        }

        public void input()
        {
            Console.WriteLine("Please write the first name of the manager.");
            firstName = Console.ReadLine();

            Console.WriteLine("Please write the last name of the manager.");
            lastName = Console.ReadLine();

            Console.WriteLine("Please write the age of the manager.");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write phone number of the manager.");
            phoneNumber = Console.ReadLine();

        }

        public void output()
        {
        Console.WriteLine("The company's manager name is {0} {1}. He is {2} years old. If you want to contact him, you can do it by calling {3}. "
            ,firstName, lastName, age,phoneNumber);
        }
    }
    

    static void Main(string[] args)
    {
        Company company = new Company();
        Manager manager = new Manager();

        Console.Clear();

        company.input();
        manager.input();

        company.output();
        manager.output();
    }
}

