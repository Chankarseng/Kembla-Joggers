using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Foundation;

namespace KemblaJoggers.Classes
{
    public class readDataFromCloud
    {
        public static async Task Read()
        {
            AppData.offlineContactList = new List<ContactClass>();


            bool done = false;

            // Get child with the current user ID
            // Goes through the node and return everything that is called snapshot
            AppData.ContactNode.GetChild("contacts").ObserveSingleEvent(DataEventType.Value, (snapshot) =>
            {
                // If the uID doesn't exit or deleted or not in the database
                if (!snapshot.HasChildren)
                    return;

                // Convert the data into a dictionary
                var allListsData = snapshot.GetValue<NSDictionary>();

                // If there is no data
                if (allListsData.Count == 0)
                    return;
                if (!(allListsData.IsKindOfClass(new ObjCRuntime.Class(typeof(NSDictionary)))))
                    return;

                NSString listName = (NSString)allListsData.ValueForKey((NSString)"contacts");


                done = true;
            });
            while (!done)
            {
                await Task.Delay(50);
            }
        }
    }
}
