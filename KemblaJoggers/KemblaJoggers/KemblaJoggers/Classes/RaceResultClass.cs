﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public class RaceResultClass
    {
        public string raceid { get; set; }
        public DateTime date { get; set; }
        public string location_name { get; set; }
        public string course_name { get; set;}
        public List<ContactClass> raceContacts { get; set; }
        public string[] raceTimings { get; set; }
    }
}
