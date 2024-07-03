using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BestReg.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BestRegUser class
public class BestRegUser : IdentityUser
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Province { get; set; }

    [Required]
    public string SourceOfFunding { get; set; }

}

