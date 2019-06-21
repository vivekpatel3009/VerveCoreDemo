using AthletePerformanceTrackerAPI.BAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AthletePerformanceTrackerAPI.BAL.Repository
{
    /// <summary>
    /// Interface for method related to Test
    /// </summary>
    public interface IManageTest
    {
        string CreateTest(AthletePerformanceTrackerAPI.BAL.Model.Test test);
        string IsTestExist(AthletePerformanceTrackerAPI.BAL.Model.Test test);
        string DeleteTest(long testId);
        List<GetAllTest> GetAllTest();
    }
}
