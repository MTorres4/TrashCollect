using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorPro.Models
{
    public class UserViewModels
    {
        [Required]
        [Display(Name = "Currently Active?")]
        public bool CurrentlyActive { get; set; }

        [Display(Name = "Current Day")]
        public string CurrentPickUpDay { get; set; }

        [Display(Name = "Suspend Service On")]
        public string SuspendService { get; set; }

        [Display(Name = "Resume Service On")]
        public string ResumeService { get; set; }
    }
}