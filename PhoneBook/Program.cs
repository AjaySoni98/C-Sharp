using System;

namespace PhoneBook
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ContactServiceImpl csiObj1 = new ContactServiceImpl();

            int continuance = 1;

            while(continuance!=0){
                Console.WriteLine("Enter 1 to Insert a Contact.");
                Console.WriteLine("Enter 2 to Update a Contact.");
                Console.WriteLine("Enter 3 to Search a Contact.");
                Console.WriteLine("Enter 4 to Display all Contacts.");
                Console.WriteLine("Enter 5 to Copy a Contact.");
                Console.WriteLine("Enter 6 to Copy all Contact.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                int switchCase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------------");

                switch(switchCase){
                    case 1:
                        Console.Write("Enter Name: ");
                        string name1 = Console.ReadLine();
                        Console.Write("Enter Mobile Number: ");
                        long mNumber1 = long.Parse(Console.ReadLine());
                        Console.Write("Enter Email Id: ");
                        string emailId1 = Console.ReadLine();
                        Console.Write("Enter memory type in which you want to save: ");
                        string memory1 = Console.ReadLine();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        
                        Contacts cObj1 = new Contacts(name1, mNumber1, emailId1);
                        csiObj1.insertContact(cObj1, memory1);
                        break;
                    case 2:
                        Console.Write("Enter Name: ");
                        string name2 = Console.ReadLine();
                        Console.Write("Enter Mobile Number: ");
                        long mNumber2 = long.Parse(Console.ReadLine());
                        Console.Write("Enter Email Id: ");
                        string emailId2 = Console.ReadLine();
                        Console.Write("Enter memory type in which you want to update: ");
                        string memory2 = Console.ReadLine();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        
                        Contacts cObj2 = new Contacts(name2, mNumber2, emailId2);
                        csiObj1.updateContact(cObj2, memory2);
                        break;
                    case 3:
                        Console.WriteLine("If you want to search by Name skip the Mobile Number input and vice versa.");
                        Console.WriteLine();
                        Console.Write("Enter Name: ");
                        string name3 = Console.ReadLine();
                        Console.Write("Enter Mobile Number: ");
                        string mNumber3string = Console.ReadLine();
                        Console.Write("Enter memory type in which you want to search: ");
                        string memory3 = Console.ReadLine();
                        try{
                            long mNumber3 = long.Parse(mNumber3string);
                            Contacts b = csiObj1.searchContact(mNumber3, memory3);
                            Console.WriteLine("-----------------------------------------------------------------------------------");
                            Console.WriteLine("Found");
                            Console.WriteLine("Name: {0}, Mobile Number: {1}, Email Id: {2}", b.Name, b.MobileNumber, b.EmailId);
                            Console.WriteLine("-----------------------------------------------------------------------------------");
                        }catch{
                            Contacts a = csiObj1.searchContact(name3, memory3);
                            Console.WriteLine("-----------------------------------------------------------------------------------");
                            Console.WriteLine("Found");
                            Console.WriteLine("Name: {0}, Mobile Number: {1}, Email Id: {2}", a.Name, a.MobileNumber, a.EmailId);
                            Console.WriteLine("-----------------------------------------------------------------------------------");
                        }
                        break;
                    case 4:
                        csiObj1.Display();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;
                    case 5:
                        Console.Write("Enter Name: ");
                        string namen = Console.ReadLine();
                        Console.Write("Enter Mobile Number: ");
                        long mNumbern = long.Parse(Console.ReadLine());
                        Console.Write("Enter Email Id: ");
                        string emailIdn = Console.ReadLine();

                        Contacts cObj3 = new Contacts(namen, mNumbern, emailIdn);

                        Console.Write("Enter memory type from which you want to copy: ");
                        string memory4 = Console.ReadLine();
                        Console.Write("Enter memory type to which you want to copy: ");
                        string memory5 = Console.ReadLine();
                        Console.WriteLine("-----------------------------------------------------------------------------------");

                        csiObj1.Copy(cObj3, memory4, memory5);
                        break;
                    case 6:
                        Console.Write("Enter memory type from which you want to copy: ");
                        string memory6 = Console.ReadLine();
                        Console.Write("Enter memory type to which you want to copy: ");
                        string memory7 = Console.ReadLine();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        csiObj1.CopyAll(memory6, memory7);
                        break;
                    default:
                        Console.WriteLine("Invalid choice selected.");
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;
                }

                Console.WriteLine("Enter 1 to continue or 0 to exit.");
                continuance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
        }
    }
}