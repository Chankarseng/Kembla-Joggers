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
                location_name = "Wilandra",
                course_name = "4x100 relay",
                raceContacts = AppData.offlineContactList,
                raceTimings = temp
            });

        }
    }
}
