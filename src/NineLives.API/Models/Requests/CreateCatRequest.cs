using NineLives.API.Models.Enums;

namespace NineLives.API.Models.Requests
{
    public class CreateCatRequest
    {
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
    }
}
