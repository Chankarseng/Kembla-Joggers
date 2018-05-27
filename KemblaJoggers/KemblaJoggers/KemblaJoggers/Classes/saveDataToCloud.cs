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
            NSDictionary toWriteDict = contactToDict();

            AppData.ContactNode.GetChild("contacts")
                   .SetValue<NSDictionary>(toWriteDict);

            // Courses
            toWriteDict = courseToDict();

            AppData.CourseNode.GetChild("courses")
                   .SetValue<NSDictionary>(toWriteDict);

			// Location
            locationToDict();

            // Race Result
            raceToDict();

            //Record
            toWriteDict = recordToDict();
            AppData.RecordNode.GetChild("record")
                   .SetValue<NSDictionary>(toWriteDict);

        }

        static NSDictionary contactToDict()
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

        static NSDictionary courseToDict()
        {
            var allItemsDict = new NSMutableDictionary();
            foreach (CoursesClass item in AppData.offlineCourseList)
            {
                NSMutableDictionary eachItemDict = new NSMutableDictionary();
                eachItemDict.SetValueForKey((NSString)item.Uid,
                                            (NSString)"uid");
                eachItemDict.SetValueForKey((NSString)item.CourseName,
                                            (NSString)"course_name");
                eachItemDict.SetValueForKey((NSString)item.LocationID,
                                            (NSString)"location_id");
                eachItemDict.SetValueForKey((NSString)item.LocationName,
                                            (NSString)"location_name");
                eachItemDict.SetValueForKey((NSString)item.SurfaceType,
                                            (NSString)"surface_type");
                eachItemDict.SetValueForKey((NSString)item.Distance.ToString(),
                                            (NSString)"distance");
                eachItemDict.SetValueForKey((NSString)item.Units,
                                            (NSString)"units");
                eachItemDict.SetValueForKey((NSString)item.ConversionFactor.ToString(),
                                            (NSString)"conversion_factor");
                eachItemDict.SetValueForKey((NSString)item.HandicapBuffer,
                                            (NSString)"handicap_buffer");
                eachItemDict.SetValueForKey((NSString)item.HandicapCutOff,
                                            (NSString)"handicap_cutoff");
                eachItemDict.SetValueForKey((NSString)item.IsRelay.ToString(),
                                            (NSString)"is_relay");
                eachItemDict.SetValueForKey((NSString)item.RelayIDs.ToString(),
                                            (NSString)"relay_id");
                eachItemDict.SetValueForKey((NSString)item.MinAge.ToString(),
                                            (NSString)"min_age");
                eachItemDict.SetValueForKey((NSString)item.TrophyAwards.ToString(),
                                            (NSString)"trophy_awards");
                eachItemDict.SetValueForKey((NSString)item.TrophyID.ToString(),
                                            (NSString)"trophy_id");
                eachItemDict.SetValueForKey((NSString)item.NumberOfLegs.ToString(),
                                            (NSString)"num_legs");

                allItemsDict.SetValueForKey(eachItemDict,
                                            (NSString)(item.CourseName));

            }

            return allItemsDict;
        }


        static void locationToDict()
        {
            for (int i = 0; i < AppData.offlineLocationList.Count; i++)
            {
                var allItemsDict = new NSMutableDictionary();
                NSMutableDictionary anyListDataDict = new NSMutableDictionary();
                LocationClass location = AppData.offlineLocationList[i];
                for (int j = 0; j < location.courses.Count; j++)
                {
                    CoursesClass item = location.courses[j];
                    NSMutableDictionary eachItemDict = new NSMutableDictionary();
                    eachItemDict.SetValueForKey((NSString)item.Uid,
                                                (NSString)"uid");
                    eachItemDict.SetValueForKey((NSString)item.CourseName,
                                                (NSString)"course_name");
                    eachItemDict.SetValueForKey((NSString)item.LocationID,
                                                (NSString)"location_id");
                    eachItemDict.SetValueForKey((NSString)item.LocationName,
                                                (NSString)"location_name");
                    eachItemDict.SetValueForKey((NSString)item.SurfaceType,
                                                (NSString)"surface_type");
                    eachItemDict.SetValueForKey((NSString)item.Distance.ToString(),
                                                (NSString)"distance");
                    eachItemDict.SetValueForKey((NSString)item.Units,
                                                (NSString)"units");
                    eachItemDict.SetValueForKey((NSString)item.ConversionFactor.ToString(),
                                                (NSString)"conversion_factor");
                    eachItemDict.SetValueForKey((NSString)item.HandicapBuffer,
                                                (NSString)"handicap_buffer");
                    eachItemDict.SetValueForKey((NSString)item.HandicapCutOff,
                                                (NSString)"handicap_cutoff");
                    eachItemDict.SetValueForKey((NSString)item.IsRelay.ToString(),
                                                (NSString)"is_relay");
                    eachItemDict.SetValueForKey((NSString)item.RelayIDs.ToString(),
                                                (NSString)"relay_id");
                    eachItemDict.SetValueForKey((NSString)item.MinAge.ToString(),
                                                (NSString)"min_age");
                    eachItemDict.SetValueForKey((NSString)item.TrophyAwards.ToString(),
                                                (NSString)"trophy_awards");
                    eachItemDict.SetValueForKey((NSString)item.TrophyID.ToString(),
                                                (NSString)"trophy_id");
                    eachItemDict.SetValueForKey((NSString)item.NumberOfLegs.ToString(),
                                                (NSString)"num_legs");

                    allItemsDict.SetValueForKey(eachItemDict,
                                                (NSString)(item.CourseName));
                }
                    


                object[] locationKeys = { "location_id", "location_name", "location_X", "location_Y" };
                object[] locationValues = { location.locationID, location.locationName, location.posX, location.posY };

                var locationDict = NSDictionary.FromObjectsAndKeys(locationValues, locationKeys);

                //anyListDataDict = new NSMutableDictionary();

                anyListDataDict.SetValueForKey(allItemsDict, (NSString)location.locationName);
                allItemsDict.SetValueForKey(locationDict, (NSString)"location_info");

                AppData.LocationNode.GetChild(location.locationName)
                       .SetValue<NSDictionary>(anyListDataDict);
            }

        }

        static void raceToDict()
        {
            var allItemsDict = new NSMutableDictionary();
            NSMutableDictionary anyListDataDict = new NSMutableDictionary();
            foreach (RaceResultClass result in AppData.offlineRaceResultList)
            {
                int index = 0;
                foreach (ContactClass item in result.raceContacts)
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
                    eachItemDict.SetValueForKey((NSString)(result.raceTimings[index]),
                                                (NSString)"race_time");
                    allItemsDict.SetValueForKey(eachItemDict,
                                                (NSString)(item.FirstName + " " + item.LastName));
                    index++;

                }


                object[] locationKeys = { "race_id", "date","location_name","course_name"};
                object[] locationValues = { result.raceid,result.date.ToShortDateString(),result.location_name,result.course_name};

                var locationDict = NSDictionary.FromObjectsAndKeys(locationValues, locationKeys);

                anyListDataDict.SetValueForKey(allItemsDict, (NSString)result.course_name);
                allItemsDict.SetValueForKey(locationDict, (NSString)"race_info");

                AppData.RaceResultNode.GetChild(result.raceid)
                       .SetValue<NSDictionary>(anyListDataDict);

            }
        }


        static NSDictionary recordToDict()
        {
            var allItemsDict = new NSMutableDictionary();

            foreach (RecordClass item in AppData.offlineRecordList)
            {
                NSMutableDictionary eachItemDict = new NSMutableDictionary();

                eachItemDict.SetValueForKey((NSString)item.AgeGroup,
                                            (NSString)"age_group");
                eachItemDict.SetValueForKey((NSString)item.CourseID.ToString(),
                                            (NSString)"course_id");
                eachItemDict.SetValueForKey((NSString)(item.Date.ToShortDateString().ToString()),
                                            (NSString)"date");
                eachItemDict.SetValueForKey((NSString)(item.FirstName),
                                            (NSString)"first_name");
                eachItemDict.SetValueForKey((NSString)(item.LastName),
                                            (NSString)"last_name");
                eachItemDict.SetValueForKey((NSString)(item.Gender),
                                            (NSString)"gender");
                eachItemDict.SetValueForKey((NSString)(item.Line.ToString()),
                                            (NSString)"line");
                eachItemDict.SetValueForKey((NSString)(item.Location),
                                            (NSString)"location");
                eachItemDict.SetValueForKey((NSString)(item.MemberNo.ToString()),
                                            (NSString)"member_no");
                eachItemDict.SetValueForKey((NSString)(item.OpenRecord.ToString()),
                                            (NSString)"openrecord");
                eachItemDict.SetValueForKey((NSString)(item.Time),
                                            (NSString)"time");

                allItemsDict.SetValueForKey(eachItemDict,
                                            (NSString)(item.FirstName + " " + item.LastName));

            }

            return allItemsDict;
        }
    }
}