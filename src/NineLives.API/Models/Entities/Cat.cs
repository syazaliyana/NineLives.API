using NineLives.API.Models.Enums;

namespace NineLives.API.Models.Entities
{
    public class Cat
    {
        public int Id { get; set; }
        public required string RescueId { get; set; }
        public string? Name { get; set; }
        public int? EstimatedAge { get; set; }
        public AgeUnit? AgeUnit { get; set; }
        public required Gender Gender { get; set; }
        public string? Breed { get; set; }
        public required string Color { get; set; }
        public string? Description { get; set; }
        public string? HealthNotes { get; set; }
        public required DateTime RescueDate { get; set; }
        public required string RescueLocation { get; set; }
        public required int CurrentStatusId { get; set; }
        public required int VaccinationStatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
