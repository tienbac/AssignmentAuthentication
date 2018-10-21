using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AssignmentAuthentication.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AssignmentAuthenticationUser class
    public class AssignmentAuthenticationUser : IdentityUser
    {
        [PersonalData] public string FullName { get; set; }
        [PersonalData] public string RollNumber { get; set; }
        [PersonalData] public DateTime Birthday { get; set; }
        [PersonalData] public string Address { get; set; }
        [PersonalData] public string Gender { get; set; }
    }
}
