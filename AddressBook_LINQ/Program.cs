using System;

namespace AddressBook_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The AddressBook Program Using LINQ");

            AddressModel model = new AddressModel();
            AddressBook_DataTable dataTable = new AddressBook_DataTable();
            dataTable.CreateTable(model);
            dataTable.Display();
        }
    }
}
