namespace PhoneBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            bool control = true;
            while (control)
            {
                Console.WriteLine("(1) Register Phone Number");
                Console.WriteLine("(2) Delete Phone Number");
                Console.WriteLine("(3) Update Phone Number");
                Console.WriteLine("(4) Directory Listing ");
                Console.WriteLine("(5) Search in the Directory");
                Console.WriteLine("(0) Quit");

                Console.WriteLine("**********************");

                Console.WriteLine("\nPlease Choose One Of Them : ");
                int choosed = int.Parse(Console.ReadLine());

                if (choosed == 1)
                {
                    Console.WriteLine("Adding Person Operation!!!\n\n");

                    AddPerson addPerson = new AddPerson();
                    addPerson.AddingOperation();
                }
                else if (choosed == 2)
                {
                    Console.WriteLine("Deletin Person Operation!!!\n\n");

                    DeletePerson deletePerson = new DeletePerson();
                    deletePerson.DeletingOperation();
                }
                else if (choosed == 3)
                {
                    Console.WriteLine("Update Phone Number Operation!!!\n\n");

                    UpdatePerson updatePerson = new UpdatePerson();
                    updatePerson.UpdatingOperation();
                }
                else if (choosed == 4)
                {
                    Console.WriteLine("Listing Person Operation!!!\n\n");

                    PersonList personList = new PersonList();
                    personList.ListingOperation();

                }
                else if (choosed == 5)
                {
                    Console.WriteLine("Search the Directory Operation!!!\n\n");

                    SearchPerson searchPerson = new SearchPerson();
                    searchPerson.SearchingOperation();
                }
                else if (choosed == 0)
                {
                    Console.WriteLine("You Have Quit !!!\n\n");
                    control = false;
                }
                else
                {
                    Console.WriteLine("Please Enter A Valid Value!!!\n\n");
                }

            }
        }
    }
}