namespace PhoneBook
{
    public class DeletePerson : AllOperations
    {
        public override void DeletingOperation()
        {
            while (true)
            {
                Console.WriteLine("Please enter the name or surname of the person whose number you want to delete:");
                string input = Console.ReadLine();

                ExistPerson existPerson = new ExistPerson();
                var item = existPerson.FindNameOrSurname(input);

                if (item != null)
                {
                    Console.WriteLine(item.Name + " " + item.Surname + " is about to be deleted from the directory, do you confirm? (y/n)");
                    string yesOrNo = Console.ReadLine();

                    if (yesOrNo == "y" || yesOrNo== "Y")
                    {
                        existPerson.RemovePerson(item);

                        Console.WriteLine("* Delete successfully.\n\n");
                        Console.WriteLine("* To return to main menu: (1)");
                        Console.WriteLine("* To see the delete page again: (2)");
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
                        Console.WriteLine("* Cancel .\n\n");
                        Console.WriteLine("* To return to main menu: (1)");
                        Console.WriteLine("* To see the delete page again: (2)");
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
                else
                {
                    Console.WriteLine("* Person To Delete Could Not Be Found .\n\n");
                    Console.WriteLine("* To return to main menu: (1)");
                    Console.WriteLine("* To see the delete page again: (2)");
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