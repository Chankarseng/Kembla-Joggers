using System;
using System.Threading.Tasks;

namespace KemblaJoggers.Classes
{
    public class readDataFromCloud
    {
        /*public static async Task Read()
        {
            AppData.onlineCourseList = new List<CoursesClass>();

            // If there is no user
            if (AppData.auth.CurrentUser == null)
                return;

            bool done = false;

            // Get child with the current user ID
            // Goes through the node and return everything that is called snapshot
            AppData.DataNode.GetChild(AppData.curUser.Uid).ObserveSingleEvent(DataEventType.Value, (snapshot) =>
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

                foreach (NSDictionary eachListAllVals in allListsData.Values)
                {

                    NSString listName = (NSString)eachListAllVals.ValueForKey((NSString)"listName");

                    List<ItemClass> itemsInList = new List<ItemClass>();

                    if (eachListAllVals.ValueForKey((NSString)"items") != null)
                    {
                        if ((eachListAllVals.ValueForKey((NSString)"items")).IsKindOfClass(new ObjCRuntime.Class(typeof(NSDictionary))))
                        {
                            NSDictionary itemsOfListVals = (NSDictionary)NSObject.FromObject(eachListAllVals.ValueForKey((NSString)"items"));

                            for (int j = 0; j < (int)itemsOfListVals.Values.Length; j++)
                            {
                                NSDictionary eachItemVals = (NSDictionary)NSObject.FromObject(itemsOfListVals.Values[j]);
                                var fetchedItemName = (NSString)eachItemVals.ValueForKey((NSString)"itemName");
                                var fetchedItemTime = (NSString)eachItemVals.ValueForKey((NSString)"itemTime");
                                var fetchedItemPurchasedStr = ((NSString)(eachItemVals.ValueForKey((NSString)"itemPurchased")));

                                bool fetchedItemPurchased = (fetchedItemPurchasedStr == "true" || fetchedItemPurchasedStr == "True") ? true : false;

                                itemsInList.Add(new ItemClass
                                {
                                    ItemName = fetchedItemName,
                                    ItemPurchased = fetchedItemPurchased,
                                    ItemTime = DateTime.Parse(fetchedItemTime.ToString())
                                });
                            }
                        }
                    }

                    AppData.onlineLst.Add(new GroceryListClass
                    {
                        ListName = listName,
                        ListOwner = AppData.curUser,
                        ListItems = itemsInList
                    });
                }
                done = true;
            });
            while (!done)
            {
                await Task.Delay(50);
            }
        }*/
    }
}
