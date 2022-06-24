using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class AddressBook
    {
        DataTable dataTable;
        public void CreateDataTable()
        {
            dataTable = new DataTable("AddressBook");
            DataColumn dtColumn;

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "ID";
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "FirstName";
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "LastName";
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Address";
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "City";
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "State";
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Email";
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int64);
            dtColumn.ColumnName = "PhoneNumber";
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int64);
            dtColumn.ColumnName = "Zip";
            dataTable.Columns.Add(dtColumn);

        }
        public int AddValues()
        {
            CreateDataTable();
            Contact contact = new Contact();
            Contact contacts = new Contact();
            contact.ID = 1;
            contact.FirstName = "Rajvardhan";
            contact.LastName = "Singh";
            contact.PhoneNumber = 8439560765;
            contact.Email = "rajvardhan.2627@gmail.com";
            contact.Address = "Himalayan Colony";
            contact.City = "Najibabad";
            contact.State = "UP";
            contact.zip = 246763;
            InsertintoDataTable(contact);

            contacts.ID = 2;
            contacts.FirstName = "Kshitij";
            contacts.LastName = "Puri";
            contacts.PhoneNumber = 7012657852;
            contacts.Email = "puri.kshitij@gmail.com";
            contacts.Address = "IIT Road";
            contacts.City = "Roorke";
            contacts.State = "UK";
            contacts.zip = 247001;
            InsertintoDataTable(contacts);

            return dataTable.Rows.Count;
        }

        public void InsertintoDataTable(Contact contact)
        {
            DataRow dtRow = dataTable.NewRow();
            dtRow["ID"] = contact.ID;
            dtRow["FirstName"] = contact.FirstName;
            dtRow["LastName"] = contact.LastName;
            dtRow["Address"] = contact.Address;
            dtRow["City"] = contact.City;
            dtRow["State"] = contact.State;
            dtRow["Zip"] = contact.zip;
            dtRow["PhoneNumber"] = contact.PhoneNumber;
            dtRow["Email"] = contact.Email;
            dataTable.Rows.Add(dtRow);
        }
        public void Display()
        {
            foreach (DataRow dtRows in dataTable.Rows)
            {
                Console.WriteLine(" ID: {0} \n First Name: {1} \n Last Name: {2} \n Address: {3} \n City: {4} \n State: {5} \n Zip: {6} \n Phone Number: {7} \n Email: {8} \n", dtRows["ID"], dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"]);
            }
        }
        public int EditDataTable(string FirstName, string ColumnName)
        {
            AddValues();
            var modifiedList = (from ContactList in dataTable.AsEnumerable() where ContactList.Field<string>("FirstName") == FirstName select ContactList).FirstOrDefault();
            if (modifiedList != null)
            {
                modifiedList[ColumnName] = "Sharma";
                Display();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
