using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace KemblaJoggers
{
    public static class ReadWriteDisk
    {
        static readonly string mainPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        static readonly string contactsPath = Path.Combine(mainPath, "contacts.json");
        static readonly string coursePath = Path.Combine(mainPath, "course.json");
        static readonly string locationPath = Path.Combine(mainPath, "location.json");
		static readonly string raceResultPath = Path.Combine(mainPath, "racereults.json");
        static readonly string recordPath = Path.Combine(mainPath, "record.json");

        public static void readContacts()
        {
            
        }


        public static void readCourses()
        {

        }
        public static void readLocation()
        {

        }
        public static void readRaceResults()
        {

        }
		
        public static void readRecord()
		{
			
		}

        public static void writeContacts()
        {
            
        }
        public static void writeCourses()
        {
            
        }
        public static void writeLocation()
        {
            
        }
        public static void writeRaceResults()
        {
            
        }
        public static void writeRecord()
        {

        }

    }
}
