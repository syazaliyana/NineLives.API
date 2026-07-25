using Microsoft.AspNetCore.Mvc;
using NineLives.API.Models.Entities;
using NineLives.API.Models.Enums;

namespace NineLives.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CatsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllCats()
    {
        var cats = new List<Cat>
        {
            new Cat
            {
                Id = 1,
                RescueId = "CAT000001",
                Name = "Candy",
                EstimatedAge = 11,
                AgeUnit = AgeUnit.Years,
                Gender = Gender.Male,
                Color = "White brownish",
                RescueDate = DateTime.Today,
                RescueLocation = "Pasir Gudang",
                CurrentStatusId = 1,
                VaccinationStatusId = 1
            },

            new Cat
            {
                Id = 2,
                RescueId = "CAT000002",
                Name = "Jelly",
                EstimatedAge = 1,
                AgeUnit = AgeUnit.Years,
                Gender = Gender.Male,
                Color = "Orange",
                RescueDate = DateTime.Today,
                RescueLocation = "Pasir Gudang",
                CurrentStatusId = 1,
                VaccinationStatusId = 1
            }
        };

        return Ok(cats);
    }
}

