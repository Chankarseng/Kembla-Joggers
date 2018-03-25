using System;
using System.Collections.Generic;
namespace KemblaJoggers.Classes
{
    public static class PrepareContactFirstList
    {
        public static void Prepare()
        {
            AppData.offlineContactList = new List<ContactClass>();
            AppData.offlineContactList.Add(new ContactClass
            {
                FirstName = "First Name Test",
                LastName = "Last Name Test"
            });

        }
    }
}
