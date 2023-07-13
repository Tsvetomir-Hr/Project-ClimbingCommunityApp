﻿namespace ClimbingCommunity.Web.ViewModels.Profile
{
    public class ClimberProfileViewModel
    {
        public ClimberProfileViewModel()
        {
            this.Photos = new HashSet<string>();
        }

        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ProfilePicture { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Speciality { get; set; } = null!;
        public string TypeOfUser { get; set; } = null!;
        public int ClimbingExperience { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string Level { get; set; } = null!;
        public ICollection<string> Photos { get; set; }

    }
}