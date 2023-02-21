namespace PhoneBook
{
    public class SearchPerson : AllOperations
    {
        public override void SearchingOperation()
        {
            while (true)
            {
                Console.WriteLine("Select the method you want to search:");
                Console.WriteLine("****************************************");
                Console.WriteLine("To search by first or last name: (1)");
                Console.WriteLine("To search by number: (2)");

                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Please enter first or last name: ");
                    string input1 = Console.ReadLine();

                    ExistPerson existPerson = new ExistPerson();
                    List<Person> allSearchingPeople = existPerson.SearchTheNameOrSurname(input1);

                    foreach (Person item in allSearchingPeople)
                    {
                        Console.WriteLine("Name            : " + item.Name);
                        Console.WriteLine("Surname         : " + item.Surname);
                        Console.WriteLine("Phone Number    : " + item.PhoneNumber);
                        Console.WriteLine("******************************");
                    }

                    Console.WriteLine("* To return to main menu: (1)");
                    Console.WriteLine("* To see the search page again: (2)");
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
                else if (input == 2)
                {
                    Console.WriteLine("Please enter the Phone Number:");
                    string input2 = Console.ReadLine();

                    ExistPerson existPerson = new ExistPerson();
                    List<Person> allSearchingPeople = existPerson.SearchThePhoneNumber(input2);

                    foreach (Person item in allSearchingPeople)
                    {
                        Console.WriteLine("Name            : " + item.Name);
                        Console.WriteLine("Surname         : " + item.Surname);
                        Console.WriteLine("Phone Number    : " + item.PhoneNumber);
                        Console.WriteLine("******************************");
                    }

                    Console.WriteLine("* To return to main menu: (1)");
                    Console.WriteLine("* To see the search page again: (2)");
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
}