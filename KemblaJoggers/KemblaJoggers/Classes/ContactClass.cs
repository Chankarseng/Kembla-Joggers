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
        public int MarshalingPreferenceID { get; set; } // contactVMarshallID
        public string MedicalCondition { get; set; } // contactVMedicalCondition
        public string DietaryCondition { get; set; } // contactVDietaryCondition
        public bool FirstAid { get; set; } // contactVFirstAid
        public int AsterGroupID { get; set; } // contactVAsterID
        public int MemberID { get; set; } // contactVMemberID
        public int ANSWNumber { get; set; } // contactVANSWNumber
        public bool LifeMember { get; set; } // contactVLifeMember
        public string ClubName { get; set; } // contactVClubName
        public bool ActiveStatus { get; set; }
    }
}
