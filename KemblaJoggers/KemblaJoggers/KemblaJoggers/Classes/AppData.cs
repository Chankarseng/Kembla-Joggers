using System;
using System.Collections.Generic;
using Firebase.Database;
using Firebase.Auth;
using Firebase.Core;
using KemblaJoggers.Classes;
using Intents;
using System.Diagnostics;

namespace KemblaJoggers
{
    public class AppData
    {
        private static AppData instance;

        public static List<CoursesClass> offlineCourseList; // For a list of courses (containing location name and id)
        public static List<ContactClass> offlineContactList; // For a list of contacts
        public static List<RecordClass> offlineRecordList; // For a list of record
        public static List<LocationClass> offlineLocationList; // For a list of locations
        public static List<RaceResultClass> offlineRaceResultList; // For a list of race results
        #region race event
        public static int i = 0;
        public static Stopwatch stopwatch = new Stopwatch();
        public static string[] lapTime = new string[1000];
        public static string currentTime = "00:00:00:00";
        public static int index = 0;
        public static string[] currentRaceLapTime; // For inserting and displaying at the event screen
        public static int curLocIndex;
        public static CoursesClass _curCourse;
        public static List<CoursesClass> cur_listCourse;
        #endregion

        #region setting for course management
        public static bool chooseCourse = false;
        public static int viewcontroller = 0;
        public static LocationClass _curLoc;
        #endregion

        public static DatabaseReference CourseNode { get; set; }
        public static DatabaseReference ContactNode { get; set; }
        public static DatabaseReference LocationNode { get; set; }
        public static DatabaseReference RaceResultNode { get; set; }
        public static DatabaseReference RecordNode { get; set; }

        public static Auth auth; // For authentication for login and register and such
        public static bool online = false;


        private AppData()
        {
            offlineCourseList = new List<CoursesClass>();
            offlineContactList = new List<ContactClass>();
            offlineRecordList = new List<RecordClass>();
            offlineRaceResultList = new List<RaceResultClass>();

            App.Configure(); // Goes through the Googleservices plist and connects to firebase

            CourseNode = Database.DefaultInstance.GetRootReference().GetChild("courses");
            ContactNode = Database.DefaultInstance.GetRootReference().GetChild("contacts");
            LocationNode = Database.DefaultInstance.GetRootReference().GetChild("location");
            RaceResultNode = Database.DefaultInstance.GetRootReference().GetChild("raceresults");
            RecordNode = Database.DefaultInstance.GetRootReference().GetChild("record");
            auth = Auth.DefaultInstance;
            ReadWriteDisk.readContacts();
            ReadWriteDisk.readCourses();
            //PrepareLocationFirstList.Prepare();
            ReadWriteDisk.readLocation();
            ReadWriteDisk.readRaceResults();
            ReadWriteDisk.readRecord();
        }

        public static AppData GetInstance()
        {
            if (instance == null)
            {
                instance = new AppData();
            }
            return instance;
        }
    }
}
