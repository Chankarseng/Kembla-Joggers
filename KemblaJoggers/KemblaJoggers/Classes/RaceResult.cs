﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public class RaceResult
    {
        public string raceid { get; set; }
        public DateTime date { get; set; }
        public List<ContactClass> raceContacts { get; set; }
        public string[] raceTimings { get; set; }

    }
}
