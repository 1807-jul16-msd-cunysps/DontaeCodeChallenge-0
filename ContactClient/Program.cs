﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactLibrary;

namespace ContactClient
{
    class Program
    {
        public static List<Person> contactList = new List<Person>();

        public static void Main(string[] args)
        {
            int selNum = 0;
            bool exceptable = false;

            while (exceptable == false)
            {
                Console.WriteLine("\n***************************");
                Console.WriteLine("1 : Add a Contact");
                Console.WriteLine("2 : Display Contacts");
                Console.WriteLine("3 : Search for Contact");
                Console.WriteLine("4 : Edit a Contact");
                Console.WriteLine("5 : Delete Contact");
                Console.WriteLine("6 : Save Contact");
                Console.WriteLine("7 : Load Contact");
                Console.WriteLine("8 : Close App");
                Console.WriteLine("\n***************************");
                Console.Write("\nEnter number: ");

                string feedback = Console.ReadLine();
                bool success = Int32.TryParse(feedback, out selNum);
                if (success)
                {
                    switch (selNum)
                    {
                        case 1:
                            ContactData.addContact();
                            break;
                        case 2:
                            ContactData.displayContact();
                            break;
                        case 3:
                            ContactData.searchContact();
                            break;
                        case 4:
                            ContactData.editContact();
                            break;
                        case 5:
                            ContactData.deleteContact();
                            break;
                        case 6:
                            ContactData.saveContact();
                            break;
                        case 7:
                            ContactData.loadContact();
                            break;
                        case 8:
                            exceptable = true;
                            break;
                        default:
                            Console.WriteLine("Error, Try again. ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}