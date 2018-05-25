using System;
using System.Collections.Generic;

namespace KemblaJoggers.Classes
{
    // TODO change location class that a location can have many courses
    public class LocationClass
    {
        public string locationName { get; set; }
        public string locationID { get; set; }
        public List<CoursesClass> courses { get; set; }
        public double posX { get; set; }
        public double posY { get; set; }
    }
}
