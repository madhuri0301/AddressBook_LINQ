using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AddressBook_LINQ
{
    class AddressBook_DataTable
    {
        /// <summary>
        /// Class Name Of Data Table And Its Method and Constructor
        /// </summary>
        public readonly DataTable dataTable = new DataTable();
        /// <summary>
        /// Method To Create Data Table
        /// var : var keyword can take all the datatype
        /// adding colounms to the table
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataTable CreateTable(AddressModel model)
        {
            var taleColumn1 = new DataColumn("firstName");
            dataTable.Columns.Add(taleColumn1);
            var taleColumn2 = new DataColumn("lastName");
            dataTable.Columns.Add(taleColumn2);
            var taleColumn3 = new DataColumn("city");
            dataTable.Columns.Add(taleColumn3);
            var taleColumn4 = new DataColumn("state");
            dataTable.Columns.Add(taleColumn4);
            var taleColumn5 = new DataColumn("zip");
            dataTable.Columns.Add(taleColumn5);
            var taleColumn6 = new DataColumn("phoneNumber");
            dataTable.Columns.Add(taleColumn6);

            //Inserting Information To The Table
            dataTable.Rows.Add("Anand", "Patil", "Pune", "Maharashtra", "111045", "9878765456");
            dataTable.Rows.Add("Pratik", "Hajare", "Mumbai", "Maharashtra", "230532", "9000998889");
            dataTable.Rows.Add("Ritik", "Manglani", "Ahemdabad", "Gujrat", "320008", "8567870999");
            dataTable.Rows.Add("Bhavesh", "Chaudhari", "Pansemal", "MP", "451770", "9333118889");
            dataTable.Rows.Add("Akash", "Girase", "Banglore", "Karnatak", "530068", "86878909100");
            dataTable.Rows.Add("Pulkit", "Chopra", "Mumbai", "Maharashtra", "230532", "76890987867");

            return dataTable;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            foreach (var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + table.Field<string>("firstName"));
                Console.WriteLine("LastName:-" + table.Field<string>("lastName"));
                Console.WriteLine("City:-" + table.Field<string>("city"));
                Console.WriteLine("State:-" + table.Field<string>("state"));
                Console.WriteLine("ZipCode:-" + table.Field<string>("zip"));
                Console.WriteLine("PhoneNumber:-" + table.Field<string>("phoneNumber"));
            }
        }
    }
}
    
