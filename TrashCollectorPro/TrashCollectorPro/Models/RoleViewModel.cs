using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollectorPro.Models
{
    public class RoleViewModel
        //3b. Added from FoxLearn
    {
        public RoleViewModel() { }

        public RoleViewModel (ApplicationRole role)
        {
            Id = role.Id;
            Name = role.Name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}