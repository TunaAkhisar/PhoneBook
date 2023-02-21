namespace PhoneBook
{
    public class Person
    {
        private string name;
        private string surname;
        private string phoneNumber;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Person(string _name, string _surname, string _phoneNumber)
        {
            Name = _name;
            Surname = _surname;
            PhoneNumber = _phoneNumber;
        }

    }
}