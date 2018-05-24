using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace KemblaJoggers.Classes
{
    public static class PrepareContactFirstList
    {
        public static void Prepare()
        {
            AppData.offlineContactList = new List<ContactClass>();
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "1232131",
                FirstName = "John",
                LastName = "Malone",
                Email = "test@gmail.com",
                PhoneNumber = "434818232",
                Address = "Test apartment complex, test street, test postcode",
                City = "test city",
                Country = "test country",
                PostCode = 10000,
                Gender = "HUMAN",
                Birthday = DateTime.UtcNow,
                EmergencyContact = "HELP",
                EmergencyNumber = "433292102",
                MedicalCondition = "none",
                DietaryCondition = "none",
                ActiveStatus = true,
                handicapTime = new DateTime(10, 10, 10, 0, 10, 0),
            });
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "41515123",
                FirstName = "Art",
                LastName = "Garfunkel",
                Email = "test@gmail.com",
                PhoneNumber = "434818232",
                Address = "Test apartment complex, test street, test postcode",
                City = "test city",
                Country = "test country",
                PostCode = 10000,
                Gender = "HUMAN",
                Birthday = DateTime.UtcNow,
                EmergencyContact = "HELP",
                EmergencyNumber = "433292102",
                MedicalCondition = "none",
                DietaryCondition = "none",
                ActiveStatus = false
            });
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "41515123",
                FirstName = "Rick",
                LastName = "Marshall",
                Email = "test@gmail.com",
                PhoneNumber = "434818232",
                Address = "Test apartment complex, test street, test postcode",
                City = "test city",
                Country = "test country",
                PostCode = 10000,
                Gender = "HUMAN",
                Birthday = DateTime.UtcNow,
                EmergencyContact = "HELP",
                EmergencyNumber = "433292102",
                MedicalCondition = "none",
                DietaryCondition = "none",
                ActiveStatus = true,
                handicapTime = new DateTime(10, 10, 10, 1,0, 0),
            });
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "41515124",
                FirstName = "Tina",
                LastName = "Fergoson",
                Email = "test@gmail.com",
                PhoneNumber = "434818232",
                Address = "Test apartment complex, test street, test postcode",
                City = "test city",
                Country = "test country",
                PostCode = 10000,
                Gender = "HUMAN",
                Birthday = DateTime.UtcNow,
                EmergencyContact = "HELP",
                EmergencyNumber = "433292102",
                MedicalCondition = "none",
                DietaryCondition = "none",
                ActiveStatus = true,
                handicapTime = new DateTime(10, 10, 10, 0, 13, 0),
            });
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "41515125",
                FirstName = "David",
                LastName = "William",
                Email = "test@gmail.com",
                PhoneNumber = "434818232",
                Address = "Test apartment complex, test street, test postcode",
                City = "test city",
                Country = "test country",
                PostCode = 10000,
                Gender = "HUMAN",
                Birthday = DateTime.UtcNow,
                EmergencyContact = "HELP",
                EmergencyNumber = "433292102",
                MedicalCondition = "none",
                DietaryCondition = "none",
                ActiveStatus = false,
                handicapTime = new DateTime(),
            });


        }
    }
}
