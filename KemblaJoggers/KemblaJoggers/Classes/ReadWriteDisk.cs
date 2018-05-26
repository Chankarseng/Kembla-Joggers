using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public static class ReadWriteDisk
    {
        static readonly string mainPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        static readonly string contactsPath = Path.Combine(mainPath, "contacts.json");
        static readonly string coursePath = Path.Combine(mainPath, "course.json");
        static readonly string locationPath = Path.Combine(mainPath, "location.json");
		static readonly string raceResultPath = Path.Combine(mainPath, "raceresult.json");
        static readonly string recordPath = Path.Combine(mainPath, "record.json");

        public static void readContacts()
        {
            AppData.offlineContactList = new List<ContactClass>();
            if (!File.Exists(contactsPath))
            {
                PrepareContactFirstList.Prepare();
            }
            else
            {
                using (StreamReader file = File.OpenText(contactsPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    // Deserialize the data and cast it into the list
                    AppData.offlineContactList = (List<ContactClass>)serializer.Deserialize(file,
                                                                                     typeof(List<ContactClass>));
                }
			}
        }


        public static void readCourses()
        {
            AppData.offlineCourseList = new List<CoursesClass>();
            if (!File.Exists(coursePath))
            {
                PrepareCourseFirstList.Prepare();
            }
            else
            {
                using (StreamReader file = File.OpenText(coursePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    // Deserialize the data and cast it into the list
                    AppData.offlineCourseList = (List<CoursesClass>)serializer.Deserialize(file,
                                                                                            typeof(List<CoursesClass>));
                }
			}
        }
        public static void readLocation()
        {
            AppData.offlineLocationList = new List<LocationClass>();
            if (!File.Exists(locationPath))
            {
                PrepareLocationFirstList.Prepare();
            }
            else
            {
                using (StreamReader file = File.OpenText(locationPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    // Deserialize the data and cast it into the list
                    AppData.offlineLocationList = (List<LocationClass>)serializer.Deserialize(file,
                                                                                            typeof(List<LocationClass>));
                }
			}
        }
        public static void readRaceResults()
        {
            AppData.offlineRaceResultList = new List<RaceResultClass>();
            if (!File.Exists(raceResultPath))
            {
                PrepareRaceResultFirstList.Prepare();
            }
            else
            {
                using (StreamReader file = File.OpenText(raceResultPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    // Deserialize the data and cast it into the list
                    AppData.offlineRaceResultList = (List<RaceResultClass>)serializer.Deserialize(file,
                                                                                           typeof(List<RaceResultClass>));
                }
			}
        }
		
        public static void readRecord()
		{
            AppData.offlineRecordList = new List<RecordClass>();
            if (!File.Exists(recordPath))
            {
                PrepareRaceRecordFirstList.Prepare();
            }
            else
            {
                using (StreamReader file = File.OpenText(recordPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    // Deserialize the data and cast it into the list
                    AppData.offlineRecordList = (List<RecordClass>)serializer.Deserialize(file,
                                                                                           typeof(List<RecordClass>));
                }
			}
        }

        public static void writeContacts()
        {
            List<ContactClass> add = new List<ContactClass>();

            foreach (ContactClass any in AppData.offlineContactList)
            {
                add.Add(any);
            }

            string dataJson = JsonConvert.SerializeObject(add, Formatting.Indented);
            File.WriteAllText(contactsPath, dataJson);
        }
        public static void writeCourses()
        {
            List<CoursesClass> add = new List<CoursesClass>();

            foreach (CoursesClass any in AppData.offlineCourseList)
            {
                add.Add(any);
            }

            string dataJson = JsonConvert.SerializeObject(add, Formatting.Indented);
            File.WriteAllText(coursePath, dataJson);
        }
        public static void writeLocation()
        {
            List<LocationClass> add = new List<LocationClass>();

            foreach (LocationClass any in AppData.offlineLocationList)
            {
                add.Add(any);
            }

            string dataJson = JsonConvert.SerializeObject(add, Formatting.Indented);
            File.WriteAllText(locationPath, dataJson);
        }
        public static void writeRaceResults()
        {
            List<RaceResultClass> add = new List<RaceResultClass>();

            foreach (RaceResultClass any in AppData.offlineRaceResultList)
            {
                add.Add(any);
            }

            string dataJson = JsonConvert.SerializeObject(add, Formatting.Indented);
            File.WriteAllText(raceResultPath, dataJson);
        }
        public static void writeRecord()
        {
            List<RecordClass> add = new List<RecordClass>();

            foreach (RecordClass any in AppData.offlineRecordList)
            {
                add.Add(any);
            }

            string dataJson = JsonConvert.SerializeObject(add, Formatting.Indented);
            File.WriteAllText(recordPath, dataJson);
        }

    }
}
