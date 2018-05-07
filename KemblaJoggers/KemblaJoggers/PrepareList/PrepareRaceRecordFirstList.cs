using System;
using System.Collections.Generic;

namespace KemblaJoggers.Classes
{
    public class PrepareRaceRecordFirstList
    {
        public static void Prepare()
        {
            AppData.offlineRecordList = new List<RecordClass>();
            AppData.offlineRecordList.Add(new RecordClass
            {
                AgeGroup = "<18",
                CourseID = 1001,
                Date = DateTime.UtcNow,
                FirstName = "John",
                LastName = "Garfunkel",
                Gender = "Male",
                Line = 1,
                Location = "Kerry McCann Athletics Track",
                MemberNo = 0001,
                OpenRecord = false,
                Time = DateTime.UtcNow
            });

            AppData.offlineRecordList.Add(new RecordClass
            {
                AgeGroup = "<30",
                CourseID = 1002,
                Date = DateTime.UtcNow,
                FirstName = "Simon",
                LastName = "Mars",
                Gender = "Male",
                Line = 2,
                Location = "Kerry McCann Athletics Track",
                MemberNo = 0001,
                OpenRecord = false,
                Time = DateTime.UtcNow
            });
        }
    }
}
