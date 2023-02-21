namespace PhoneBook
{
    public class UpdatePerson : AllOperations
    {
        public override void UpdatingOperation()
        {
            while (true)
            {

                Console.WriteLine("Please enter the name or surname of the person whose number you want to update: ");
                string input = Console.ReadLine();

                ExistPerson existPerson = new ExistPerson();
                var item = existPerson.FindNameOrSurname(input);

                if (item != null)
                {
                    Console.WriteLine(item.Name + " " + item.Surname + " enter the new values : ");
                    existPerson.EditThePerson(item);

                    Console.WriteLine("* Update successfully.\n\n");
                    Console.WriteLine("* To return to main menu: (1)");
                    Console.WriteLine("* To see the update page again: (2)");
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
                else
                {
                    Console.WriteLine("* Person To Delete Could Not Be Found .\n\n");
                    Console.WriteLine("* To return to main menu: (1)");
                    Console.WriteLine("* To see the update page again: (2)");
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