namespace PhoneBook
{
    public class PersonList : AllOperations
    {
        public override void ListingOperation()
        {
            while (true)
            {
                ExistPerson existPerson = new ExistPerson();
                existPerson.DisplayList();

                Console.WriteLine("* List successfully.\n\n");
                Console.WriteLine("* To return to main menu: (1)");
                Console.WriteLine("* To see the list page again: (2)");
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