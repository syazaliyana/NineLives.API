using NineLives.API.Models.Enums;

namespace NineLives.API.Models.Responses
{
    public class CatResponse
    {
        public int Id { get; set; }
        public required string RescueId { get; set; }
        public string? Name { get; set; }
        public int? EstimateAge { get; set; }
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
    }
}
