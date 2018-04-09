using System;
using System.Collections.Generic;
using Firebase.Database;
using Firebase.Auth;
using Firebase.Core;
namespace KemblaJoggers
{
    public class AppData
    {
        private static AppData instance;

        public static List<CoursesClass> offlineCourseList;
        public static List<ContactClass> offlineContactList;

        #region firebaseandonline
        public static List<CoursesClass> onlineCourseList;
        public static List<ContactClass> onlineContactList;

        public static DatabaseReference CourseNode { get; set; }
        public static DatabaseReference ContactNode { get; set; }

        public static Auth auth; // For authentication for login and register and such
        #endregion


        private AppData()
        {
            offlineCourseList = new List<CoursesClass>();

            App.Configure(); // Goes through the Googleservices plist and connects to firebase

            auth = Auth.DefaultInstance;
        }

        public static AppData GetInstnace()
        {
            if (instance == null)
            {
                instance = new AppData();
            }
            return instance;
        }
    }
}
