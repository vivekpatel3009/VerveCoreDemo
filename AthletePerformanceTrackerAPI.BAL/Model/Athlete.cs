using System;
using System.Collections.Generic;
using System.Text;

namespace AthletePerformanceTrackerAPI.BAL.Model
{
    /// <summary>
    /// Model for all details related to test and athlete
    /// </summary>
    public class GetTestAthlete
    {
        public long UserTestId { get; set; }
        public long TestId { get; set; }
        public Int16 TestMasterId { get; set; }
        public decimal Score { get; set; }
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    /// <summary>
    /// Model for score details
    /// </summary>
    public class AthleteTest
    {
        public long UserId { get; set; }
        public long TestId { get; set; }
        public decimal Score { get; set; }
    }

    /// <summary>
    /// Model for athlete
    /// </summary>
    public class AthleteResult
    {
        public long UserTestId { get; set; }
        public string TestName { get; set; }
        public DateTime Date { get; set; }
        public decimal Score { get; set; }
    }
}
