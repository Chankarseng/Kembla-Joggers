using System;
using System.Collections.Generic;
using KemblaJoggers.Classes;

namespace KemblaJoggers
{
    public class PrepareRaceResultFirstList
    {
        public static void Prepare(){
            AppData.offlineRaceResultList = new List<RaceResult>();

            string[] temp = new string[10];
            for (int i = 0; i < 10; i++)
            {
                temp[i] = "0" + i;
            }

            AppData.offlineRaceResultList.Add(new RaceResult
            {
                raceid = "1234",
                date = DateTime.UtcNow,
                raceContacts = AppData.offlineContactList,
                raceTimings = temp
            });

        }
    }
}
