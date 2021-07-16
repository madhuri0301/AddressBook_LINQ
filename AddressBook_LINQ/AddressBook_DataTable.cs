using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace AddressBook_LINQ
{
    public class AddressBook_DataTable
    {
        public readonly DataTable dataTable = new DataTable();
        public void CreateTable()
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

            //return dataTable;
        }
        /// <summary>
        /// Method To Add COntact
        /// </summary>
        /// <param name="Model"></param>
        public void AddContact(AddressModel Model)
        {
            dataTable.Rows.Add(Model.first_Name, Model.last_Name, Model.city,
                Model.state, Model.zip, Model.phone_Number);
            Console.WriteLine("Contact Added Succesfully...");
        }
        /// <summary>
        /// Method To Edit Contact
        /// </summary>
        /// <param name="model"></param>
        public void EditContact(AddressModel model)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("firstName") == model.first_Name).First();
            if (recordData != null)
            {
                recordData.SetField("LastName", model.last_Name);
                recordData.SetField("Address", model.address);
                recordData.SetField("City", model.city);
                recordData.SetField("State", model.state);
                recordData.SetField("ZipCode", model.zip);
                recordData.SetField("PhoneNumber", model.phone_Number);
            }
        }
        public void DeleteContact(AddressModel model)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("firstName") == model.first_Name).First();
            if (recordData != null)
            {
                recordData.Delete();
                Console.WriteLine("....Deleted Success....");
            }
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
