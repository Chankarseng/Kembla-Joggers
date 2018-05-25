using System;
using Foundation;
using KemblaJoggers.Classes;
namespace KemblaJoggers
{
    public static class saveDataToCloud
    {
        public static void Save()
        {

            // Contacts 
            NSDictionary toWriteDict = ListToDict();

            AppData.ContactNode.GetChild("contacts")
                   .SetValue<NSDictionary>(toWriteDict);
        }

        /*
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
        public DateTime handicapTime { get; set; }
        public int raceCount { get; set; }
        public int pointScores { get; set; }
         * */
        static NSDictionary ListToDict()
        {
            var allItemsDict = new NSMutableDictionary();

            foreach (ContactClass item in AppData.offlineContactList)
            {
                NSMutableDictionary eachItemDict = new NSMutableDictionary();

                eachItemDict.SetValueForKey((NSString)item.ContactID,
                                            (NSString)"contact_id");
                eachItemDict.SetValueForKey((NSString)item.FirstName,
                                            (NSString)"first_name");
                eachItemDict.SetValueForKey((NSString)(item.LastName),
                                            (NSString)"last_name");
                eachItemDict.SetValueForKey((NSString)(item.Email),
                                            (NSString)"email");
                eachItemDict.SetValueForKey((NSString)(item.Age.ToString()),
                                            (NSString)"age");
                eachItemDict.SetValueForKey((NSString)(item.PhoneNumber),
                                            (NSString)"phonenumber");
                eachItemDict.SetValueForKey((NSString)(item.Address),
                                            (NSString)"address");
                eachItemDict.SetValueForKey((NSString)(item.City),
                                            (NSString)"city");
                eachItemDict.SetValueForKey((NSString)(item.Country),
                                            (NSString)"country");
                eachItemDict.SetValueForKey((NSString)(item.PostCode.ToString()),
                                            (NSString)"postcode");
                eachItemDict.SetValueForKey((NSString)(item.Gender),
                                            (NSString)"gender");
                eachItemDict.SetValueForKey((NSString)(item.Birthday.ToShortDateString().ToString()),
                                            (NSString)"birthday");
                eachItemDict.SetValueForKey((NSString)(item.EmergencyContact),
                                            (NSString)"emergencycontact");
                eachItemDict.SetValueForKey((NSString)(item.EmergencyNumber),
                                            (NSString)"emergencynumber");
                eachItemDict.SetValueForKey((NSString)(item.MarshalingPreferenceID.ToString()),
                                            (NSString)"marshaling_preference");
                eachItemDict.SetValueForKey((NSString)(item.MedicalCondition),
                                            (NSString)"medical_condition");
                eachItemDict.SetValueForKey((NSString)(item.DietaryCondition),
                                            (NSString)"dietary_condition");
                eachItemDict.SetValueForKey((NSString)(item.FirstAid.ToString()),
                                            (NSString)"first_aid");
                eachItemDict.SetValueForKey((NSString)(item.AsterGroupID.ToString()),
                                            (NSString)"aster_groupid");
                eachItemDict.SetValueForKey((NSString)(item.MemberID.ToString()),
                                            (NSString)"member_id");
                eachItemDict.SetValueForKey((NSString)(item.ANSWNumber.ToString()),
                                            (NSString)"answ_number");
                eachItemDict.SetValueForKey((NSString)(item.LifeMember.ToString()),
                                            (NSString)"life_member");
                eachItemDict.SetValueForKey((NSString)(item.ClubName),
                                            (NSString)"club_name");
                eachItemDict.SetValueForKey((NSString)(item.ActiveStatus.ToString()),
                                            (NSString)"active_status");
                eachItemDict.SetValueForKey((NSString)(item.handicapTime.ToShortTimeString().ToString()),
                                            (NSString)"handicap_time");
                eachItemDict.SetValueForKey((NSString)(item.raceCount.ToString()),
                                            (NSString)"race_count");
                eachItemDict.SetValueForKey((NSString)(item.pointScores.ToString()),
                                            (NSString)"point_score");
                allItemsDict.SetValueForKey(eachItemDict,
                                            (NSString)(item.FirstName + " " + item.LastName));

            }

            return allItemsDict;
        }
    }
}
