﻿using System;

namespace AddressBook_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The AddressBook Program Using LINQ");

            AddressModel model = new AddressModel();
            AddressBook_DataTable dataTable = new AddressBook_DataTable();
            dataTable.CreateTable();
            while (true)
            {
                Console.WriteLine("Enter Choice \n1.Display \n2.Add Contact \n 3.Edit Contact \n4.Delete Contact \n5.SearchByCIty \n6.SearchByState \n7.CountByCityAndState \n8.Exit ");
                int choise = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choise)
                    {
                        case 1:
                            dataTable.Display();
                            break;
                        case 2:
                            Console.Write("Enter the first name: ");
                            model.first_Name = Console.ReadLine();
                            Console.Write("Enter the last name :");
                            model.last_Name = Console.ReadLine();
                            Console.Write("Enter the city : ");
                            model.city = Console.ReadLine();
                            Console.Write("Enter the state :");
                            model.state = Console.ReadLine();
                            Console.Write("Enter the zip code : ");
                            model.zip = Console.ReadLine();
                            Console.Write("Enter the phone number : ");
                            model.phone_Number = Console.ReadLine();
                            dataTable.AddContact(model);
                            break;
                        case 3:
                            Console.Write("Enter the first name: ");
                            model.first_Name = Console.ReadLine();
                            Console.Write("Enter the last name :");
                            model.last_Name = Console.ReadLine();
                            Console.Write("Enter the city : ");
                            model.city = Console.ReadLine();
                            Console.Write("Enter the state :");
                            model.state = Console.ReadLine();
                            Console.Write("Enter the zip code : ");
                            model.zip = Console.ReadLine();
                            Console.Write("Enter the phone number : ");
                            model.phone_Number = Console.ReadLine();
                            dataTable.EditContact(model);
                            break;
                        case 4:
                            Console.Write("Enter First Name: ");
                            model.first_Name = Console.ReadLine();
                            dataTable.DeleteContact(model);
                            break;
                        case 5:
                            Console.Write("Enter City: ");
                            model.city = Console.ReadLine();
                            dataTable.RetriveData_By_CityState(model);
                            break;
                        case 6:
                            Console.Write("Enter State: ");
                            model.state = Console.ReadLine();
                            dataTable.RetriveData_By_State(model);
                            break;
                        case 7:
                            Console.WriteLine("Count of Address Book : ");
                            dataTable.Count_BY_City_State();
                            break;

                        case 0:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }
        }
    }
}

