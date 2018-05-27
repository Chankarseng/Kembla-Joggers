using System;
using KemblaJoggers.Classes;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.IO;
namespace KemblaJoggers
{
    public static class PrepareCourseFirstList
    {
        public static void Prepare()
        {
            AppData.offlineCourseList = new List<CoursesClass>();
            AppData.offlineCourseList.Add(new CoursesClass
            {
                Uid = "123141",
                CourseName = "4x100 relay",
                LocationID = "123144233",
                LocationName =  "Kerryn McCann Athletics Track",
                SurfaceType = "Track",
                Distance = 400,
                Units = "Meters",
                Handicap = false,
                HandicapBuffer = "-",
                HandicapCutOff = "-",
                IsRelay = false,
                NumberOfLegs = 0
            });
            AppData.offlineCourseList.Add(new CoursesClass
            {
                Uid = "123142",
                CourseName = "4x300 relay",
                LocationID = "123144233",
                LocationName = "Kerryn McCann Athletics Track",
                SurfaceType = "Track",
                Distance = 400,
                Units = "Meters",
                Handicap = false,
                HandicapBuffer = "-",
                HandicapCutOff = "-",
                IsRelay = false,
                NumberOfLegs = 0
            });
        }
    }
}
