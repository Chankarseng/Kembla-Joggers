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
                LastName = "Sontag",
                Age = 31,
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
                ClubName = "",
                ActiveStatus = true,
                handicapTime = new DateTime(10, 10, 10, 0, 10, 0),
                raceCount = 2,
                pointScores = 100
            });
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "41515123",
                FirstName = "Art",
                LastName = "Garfunkel",
                Age = 20,
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
                ClubName = "",
                ActiveStatus = false,
                raceCount = 1,
                pointScores = 20,
            });
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "41513844",
                FirstName = "Rick",
                LastName = "Marshall",
                Age = 17,
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
                ClubName = "",
                MedicalCondition = "none",
                DietaryCondition = "none",
                ActiveStatus = true,
                handicapTime = new DateTime(10, 10, 10, 1,0, 0),
                raceCount = 4,
                pointScores = 13,
            });
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "41515124",
                FirstName = "Tina",
                LastName = "Fergoson",
                Age = 23,
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
                ClubName = "",
                ActiveStatus = true,
                handicapTime = new DateTime(10, 10, 10, 0, 13, 0),
                raceCount = 10,
                pointScores = 300,
            });
            AppData.offlineContactList.Add(new ContactClass
            {
                ContactID = "41515125",
                FirstName = "David",
                LastName = "William",
                Age = 27,
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
                ClubName = "",
                ActiveStatus = false,
                handicapTime = new DateTime(),
                raceCount = 3,
                pointScores = 200
            });


        }
    }
}
