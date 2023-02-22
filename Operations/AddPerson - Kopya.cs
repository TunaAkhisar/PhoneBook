namespace PhoneBook
{
    public class AddPerson : AllOperations
    {
        public override void AddingOperation()
        {
            while (true)
            {
                Console.WriteLine("Please Enter A Name : ");
                string _name = Console.ReadLine();
                Console.WriteLine("Please Enter A Surname : ");
                string _surname = Console.ReadLine();
                Console.WriteLine("Please Enter A Phone Number : ");
                string _phoneNumber = Console.ReadLine();

                ExistPerson existPerson = new ExistPerson();
                existPerson.AddNewPerson(_name, _surname, _phoneNumber);

                Console.WriteLine("* Adding successfully.\n\n");
                Console.WriteLine("* To return to main menu: (1)");
                Console.WriteLine("* To see the adding page again: (2)");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    break;
                }
                else if (choose == "2")
                {
                    continue;
                }

            }
        }
    }
}