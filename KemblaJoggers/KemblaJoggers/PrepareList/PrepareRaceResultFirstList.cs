using System;
using System.Collections.Generic;
using KemblaJoggers.Classes;

namespace KemblaJoggers
{
    public class PrepareRaceResultFirstList
    {
        public static void Prepare(){
            AppData.offlineRaceResultList = new List<RaceResultClass>();

            string[] temp = new string[10];
            for (int i = 0; i < 10; i++)
            {
                temp[i] = "0" + i;
            }

            AppData.offlineRaceResultList.Add(new RaceResultClass
            {
                raceid = "1234",
                date = DateTime.UtcNow,
                location = AppData.offlineLocationList[0],
                currentCourse = AppData.offlineLocationList[0].courses[0],
                raceContacts = AppData.offlineContactList,
                raceTimings = temp
            });

        }
    }
}
