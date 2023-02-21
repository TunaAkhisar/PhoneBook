namespace PhoneBook
{
    public class ExistPerson
    {
        public static List<Person> personList = new List<Person>();

        static ExistPerson()
        {
            personList.Add(new Person("name1", "surname1", "number1"));
            personList.Add(new Person("name2", "surname2", "number2"));
            personList.Add(new Person("name3", "surname3", "number3"));
            personList.Add(new Person("name4", "surname4", "number4"));
            personList.Add(new Person("name5", "surname5", "number5"));
        }

        public Person FindNameOrSurname(string nameORsurname)
        {
            var item = personList.Find((x) => x.Name == nameORsurname || x.Surname == nameORsurname);
            return item;
        }

        public void RemovePerson(Person person)
        {
            personList.Remove(person);
        }

        public void AddNewPerson(string _name, string _surname, string _phoneNumber)
        {
            personList.Add(new Person(_name, _surname, _phoneNumber));
        }

        public void EditThePerson(Person person)
        {
            Console.WriteLine("Name :");
            person.Name = Console.ReadLine();
            Console.WriteLine("Surname :");
            person.Surname = Console.ReadLine();
            Console.WriteLine("Phone Number :");
            person.PhoneNumber = Console.ReadLine();
        }

        public List<Person> SearchThePhoneNumber(string number)
        {
            var item = personList.FindAll((x) => x.PhoneNumber == number);
            return item;
        }

        public List<Person> SearchTheNameOrSurname(string nameORsurname)
        {
            var item = personList.FindAll((x) => (x.Name == nameORsurname || x.Surname == nameORsurname));
            return item;
        }



        public void DisplayList()
        {
            Console.WriteLine("Phone Book");
            Console.WriteLine("***********************************");

            foreach (Person person in personList)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Name         : " + person.Name);
                Console.WriteLine("Surname      : " + person.Surname);
                Console.WriteLine("Phone Number : " + person.PhoneNumber);
                Console.WriteLine("**************************");
            }
        }

    }
}