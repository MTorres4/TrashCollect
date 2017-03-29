using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollectorPro.Models
{
    public class Day
    {
        public int Id { get; set; }
        public string CurrentPickUpDay { get; set; }
        //public DateTime? ChangePickUpDay { get; set; }
        //public DateTime? SuspendService { get; set; }
        //public DateTime? ResumeService { get; set; }
        public string ChanegPickUpDay { get; set; }
        public string SuspendService { get; set; }
        public string ResumeService { get; set; }
        public bool CurrentlyActive { get; set; }

        public enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }

        public Days DayOptions { get; set; }
    }
}