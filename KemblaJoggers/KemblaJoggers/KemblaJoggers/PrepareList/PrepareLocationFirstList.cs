using System;
using KemblaJoggers.Classes;    
using System.Collections.Generic;
using EventKit;
namespace KemblaJoggers
{
    public class PrepareLocationFirstList
    {
        public static void Prepare()
        {
            // TODO : Prepare location list here
            AppData.offlineLocationList = new List<LocationClass>();
            AppData.offlineLocationList.Add(new LocationClass
            {
                locationID = "123",
                locationName = "Wilandra",
                courses = new List<CoursesClass>(),
				posX = 32.42,
                posY = -140.123,
            });
            AppData.offlineLocationList[0].courses.Add(new CoursesClass
            {
                Uid = "123141",
                CourseName = "4x100 relay",
                LocationID = "123144233",
                LocationName = "Wilandra Track",
                SurfaceType = "Track",
                Distance = 400,
                Units = "Meters",
                Handicap = false,
                HandicapBuffer = "-",
                HandicapCutOff = "-",
                IsRelay = false,
                NumberOfLegs = 0,
            });
            AppData.offlineLocationList[0].courses.Add(new CoursesClass
            {
                Uid = "123142",
                CourseName = "400 meters",
                LocationID = "123144233",
                LocationName = "Wilandra Track",
                SurfaceType = "Track",
                Distance = 400,
                Units = "Meters",
                Handicap = false,
                HandicapBuffer = "-",
                HandicapCutOff = "-",
                IsRelay = false,
                NumberOfLegs = 0,
            });
            AppData.offlineLocationList.Add(new LocationClass
            {
                locationID = "1234",
                locationName = "Kerry McCann Athletic Track",
                courses = new List<CoursesClass>(),
                posX = 30.42,
                posY = -137.123,
            });
            AppData.offlineLocationList[1].courses.Add(new CoursesClass
            {
                Uid = "123143",
                CourseName = "4x100 relay",
                LocationID = "123144233",
                LocationName = "Kerryn McCann Athletics Track",
                SurfaceType = "Track",
                Distance = 400,
                Units = "Meters",
                Handicap = false,
                HandicapBuffer = "-",
                HandicapCutOff = "-",
                IsRelay = false,
                NumberOfLegs = 0,
            });
            AppData.offlineLocationList.Add(new LocationClass
            {
                locationID = "1235545",
                locationName = "John O' Dwyer Oval",
                courses = new List<CoursesClass>(),
                posX = 31.42,
                posY = -133.123,
            });
        }
    }
}
