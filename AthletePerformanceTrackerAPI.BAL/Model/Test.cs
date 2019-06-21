using System;
using System.Collections.Generic;
using System.Text;

namespace AthletePerformanceTrackerAPI.BAL.Model
{
    /// <summary>
    /// Model for getting Test details
    /// </summary>
    public class Test
    {
        public long TestId { get; set; }
        public long TestMasterId { get; set; }
        public DateTime Date { get; set; }
    }

    /// <summary>
    /// Model for getting Test details with Athlete count
    /// </summary>
    public class GetAllTest
    {
        public long TestId { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int AthleteCount { get; set; }
    }

    /// <summary>
    /// Model for all user details
    /// </summary>
    public class UserDetail
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long RoleId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string token { get; set; }
    }
}
