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
                FirstName = "First Name Test",
                LastName = "Last Name Test",
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
            });

        }
    }
}
