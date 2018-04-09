using System;
using Intents;
namespace KemblaJoggers
{
    public class ContactClass
    {
        public string ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyNumber { get; set; }
        public int MarshalingPreferenceID { get; set; }
        public string MedicalCondition { get; set; }
        public string DietaryCondition { get; set; }
        public bool FirstAid { get; set; }
        public int AsterGroupID { get; set; }
        public int MemberID { get; set; }
        public int ANSWNumber { get; set; }
        public bool LifeMember { get; set; }
        public string ClubName { get; set; }
    }
}
