﻿namespace ClimbingCommunity.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.ClimbingTrip;
    /// <summary>
    /// Trip enitity
    /// </summary>
    public class ClimbingTrip
    {
        public ClimbingTrip()
        {
            this.Climbers = new HashSet<TripClimber>();
        }
        [Comment("Globaly unique identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Title of the trip")]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [Comment("Destination or location of the climbing trip.")]
        [MaxLength(DestinationMaxLength)]
        public string Destination { get; set; } = null!;

        [ForeignKey(nameof(TripType))]
        public int TripTypeId { get; set; }
        [Comment("Type of the trip.")]
        public virtual TripType TripType { get; set; } = null!;

        [ForeignKey(nameof(Organizator))]
        public string OrganizatorId { get; set; } = null!;
        [Comment("The climber who created the trip.")]
        public virtual Climber Organizator { get; set; } = null!;

        [Comment("Duration of the trip in days.")]
        public int Duration { get; set; }

        [Comment("Property for soft delete.")]
        public bool IsActive { get; set; } = true;

        [Comment("Collection of the climber who joined that trip.")]
        public virtual ICollection<TripClimber> Climbers { get; set; }

    }
}