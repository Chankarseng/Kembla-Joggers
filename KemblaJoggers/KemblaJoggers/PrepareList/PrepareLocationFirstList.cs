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
                locationName = "Wilandra",
                posX = 32.42,
                posY = -140.123,
            });
            AppData.offlineLocationList.Add(new LocationClass
            {
                locationID = "1234",
                locationName = "Kerry McCann Athletic Track",
                posX = 30.42,
                posY = -137.123,
            });
            AppData.offlineLocationList.Add(new LocationClass
            {
                locationID = "12356",
                locationName = "John O' Dwyer Oval",
                posX = 31.42,
                posY = -133.123,
            });
        }
    }
}
