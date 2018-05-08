using System;
using KemblaJoggers.Classes;    
namespace KemblaJoggers
{
    public class PrepareLocationFirstList
    {
        public static void Prepare()
        {
            // TODO : Prepare location list here
            AppData.offlineLocationList.Add(new LocationClass
            {
                locationID = "123",
                locationName = "Location1 name here",
                posX = 32.42,
                posY = -140.123,
            });
            AppData.offlineLocationList.Add(new LocationClass
            {
                locationID = "123",
                locationName = "Location2 name here",
                posX = 30.42,
                posY = -137.123,
            });
            AppData.offlineLocationList.Add(new LocationClass
            {
                locationID = "123",
                locationName = "Location3 name here",
                posX = 31.42,
                posY = -133.123,
            });
        }
    }
}
