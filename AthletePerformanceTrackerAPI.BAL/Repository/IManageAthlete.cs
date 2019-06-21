using AthletePerformanceTrackerAPI.BAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AthletePerformanceTrackerAPI.BAL.Repository
{
    /// <summary>
    /// Interface for methods related to Athlete
    /// </summary>
   public interface IManageAthlete
    {
        string AddAthleteInTest(AthleteTest athleteTest);
        List<GetTestAthlete> GetAthleteListForAddNUpdate(string auFlag, long testId);
        string DeleteAthleteFromTest(long userTestId);
        List<GetTestAthlete> GetTestAthlete(long testId);
        string UpdateAthleteInTest(AthleteTest athleteTest);
        List<AthleteResult> GetAthleteResult(long userId);
        UserDetail GetPersonDetail(UserDetail userDetail);
    }
}
