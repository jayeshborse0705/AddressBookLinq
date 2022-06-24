using AddressBookLinq;
using System;
namespace AddressBookLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Contact contactData = new Contact();
            Contact contactData2 = new Contact();
            AddressBook addressBook = new AddressBook();
            addressBook.CreateDataTable();
            contactData.ID = 1;
            contactData.FirstName = "Hari";
            contactData.LastName = "Sharma";
            contactData.PhoneNumber = 9011951654;
            contactData.Email = "HariSharma04@.com";
            contactData.Address = "ganesh colony";
            contactData.City = "valsad";
            contactData.State = "maharshtra";
            contactData.zip = 424306;
            addressBook.InsertintoDataTable(contactData);

            contactData2.ID = 2;
            contactData2.FirstName = "Shayam";
            contactData2.LastName = "mishra";
            contactData2.PhoneNumber = 9078675490;
            contactData2.Email = "shyammishr@gmail.com";
            contactData2.Address = "IIT Road";
            contactData2.City = "Buranpur";
            contactData2.State = "MP";
            contactData2.zip = 750945;
            addressBook.InsertintoDataTable(contactData2);

            addressBook.Display();
        }
    }
}
