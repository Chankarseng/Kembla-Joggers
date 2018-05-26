using System;
using System.Collections.Generic;
using KemblaJoggers.Classes;

namespace KemblaJoggers
{
    public class PrepareRaceResultFirstList
    {
        public static void Prepare(){
            AppData.offlineRaceResultList = new List<RaceResultClass>();
            string[] temp = { "00:00:00:93","00:00:01:44","00:00:00:75","00:00:01:11","00:00:01:29" };
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
