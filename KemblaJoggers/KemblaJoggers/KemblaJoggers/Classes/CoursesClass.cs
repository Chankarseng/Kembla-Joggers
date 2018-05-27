using System;
namespace KemblaJoggers
{
    public class CoursesClass
    {
        public string Uid { get; set; }
        public string CourseName { get; set; }
        public string LocationID { get; set; }
        public string LocationName { get; set; }
        public string SurfaceType { get; set; }
        public int Distance { get; set; }
        public string Units { get; set; }
        public bool Handicap { get; set; }
        public float ConversionFactor { get; set; } // AKA Handicap Factor
        public string HandicapCutOff { get; set; }
        public string HandicapBuffer { get; set; } // AKA Penalty Factor
        public bool IsRelay { get; set; } 
        public int RelayIDs { get; set; }
        public int MinAge { get; set; }
        public bool TrophyAwards { get; set; }
        public int TrophyID { get; set; }
        public int NumberOfLegs { get; set; }
    }
}
