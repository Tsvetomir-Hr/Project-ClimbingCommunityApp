﻿namespace ClimbingCommunity.Web.ViewModels.Profile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClimberProfileViewModel
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ProfilePicture { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Speciality { get; set; } = null!;
        public string TypeOfUser { get; set; } = null!;
        public int ClimbingExperience { get; set; }
        public string PhoneNumber { get; set; } = null!;

    }
}
